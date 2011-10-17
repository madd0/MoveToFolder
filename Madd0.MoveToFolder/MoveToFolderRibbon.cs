using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

using Outlook = Microsoft.Office.Interop.Outlook;
using System.Runtime.InteropServices;

namespace Madd0.MoveToFolder
{
    public partial class MoveToFolderRibbon
    {
        List<Outlook.MAPIFolder> _folders;

        private void MoveToFolderRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            this._folders = new List<Outlook.MAPIFolder>();
        }

        private void OnButtonClick(object sender, RibbonControlEventArgs e)
        {
            Outlook.Explorer explorer = (Outlook.Explorer)e.Control.Context;

            if (explorer.Selection.Count == 0)
            {
                return;
            }

            if (this._folders.Count == 0)
            {
                PopulateFolders(explorer.Application.Session.Folders, _folders);
            }

            var window = new FolderSelectionWindow();

            window.DataContext = _folders;

            var result = window.ShowDialog();

            if (result.HasValue && result.Value)
            {
                try
                {
                    foreach (var item in explorer.Selection)
                    {
                        if (item is Outlook.MailItem)
                        {
                            Outlook.MailItem mailItem = (Outlook.MailItem)item;
                            mailItem.UnRead = false;
                            mailItem.Move(window.SelectedFolder);
                        }
                    }
                }
                catch (COMException ce)
                {
                    System.Windows.Forms.MessageBox.Show(ce.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
                catch
                {
                    throw;
                }
            }
        }

        private void PopulateFolders(Outlook.Folders folders, List<Outlook.MAPIFolder> folderList)
        {
            foreach (Outlook.MAPIFolder folder in folders)
            {
                folderList.Add(folder);
                PopulateFolders(folder.Folders, folderList);
            }
        }
    }
}
