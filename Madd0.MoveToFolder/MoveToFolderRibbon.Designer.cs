namespace Madd0.MoveToFolder
{
    partial class MoveToFolderRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public MoveToFolderRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab = this.Factory.CreateRibbonTab();
            this.group = this.Factory.CreateRibbonGroup();
            this.buttonMove = this.Factory.CreateRibbonButton();
            this.tab.SuspendLayout();
            this.group.SuspendLayout();
            // 
            // tab
            // 
            this.tab.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab.ControlId.OfficeId = "TabMail";
            this.tab.Groups.Add(this.group);
            this.tab.Label = "TabMail";
            this.tab.Name = "tab";
            // 
            // group
            // 
            this.group.Items.Add(this.buttonMove);
            this.group.Label = "Move";
            this.group.Name = "group";
            // 
            // buttonMove
            // 
            this.buttonMove.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonMove.Image = global::Madd0.MoveToFolder.Properties.Resources.ArchiveIcon;
            this.buttonMove.KeyTip = "H";
            this.buttonMove.Label = "Move";
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.ShowImage = true;
            this.buttonMove.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.OnButtonClick);
            // 
            // MoveToFolderRibbon
            // 
            this.Name = "MoveToFolderRibbon";
            this.RibbonType = "Microsoft.Outlook.Explorer";
            this.Tabs.Add(this.tab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.MoveToFolderRibbon_Load);
            this.tab.ResumeLayout(false);
            this.tab.PerformLayout();
            this.group.ResumeLayout(false);
            this.group.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonMove;
    }

    partial class ThisRibbonCollection
    {
        internal MoveToFolderRibbon MoveToFolderRibbon
        {
            get { return this.GetRibbon<MoveToFolderRibbon>(); }
        }
    }
}
