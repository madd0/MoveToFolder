using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Outlook = Microsoft.Office.Interop.Outlook;

namespace Madd0.MoveToFolder
{
    /// <summary>
    /// Interaction logic for FolderSelectionWindow.xaml
    /// </summary>
    public partial class FolderSelectionWindow : Window
    {

        /// <summary>
        /// Gets or sets the summary.
        /// </summary>
        /// <value>The summary.</value>
        public Outlook.MAPIFolder SelectedFolder
        {
            get;
            set;
        }

        public FolderSelectionWindow()
        {
            InitializeComponent();
        }

        private void OnPreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                this.DialogResult = false;
                this.Close();
            }
            else if (e.Key == Key.Enter)
            {
                this.DialogResult = true;
                this.SelectedFolder = (Outlook.MAPIFolder)tb.SelectedItem;
                this.Close();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FocusManager.SetFocusedElement(this, tb);
            TraversalRequest tRequest = new TraversalRequest(FocusNavigationDirection.Next);
            UIElement keyboardFocus = Keyboard.FocusedElement as UIElement;

            if (keyboardFocus != null)
            {
                keyboardFocus.MoveFocus(tRequest);
            }
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
