namespace Turtle
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // mdiManager
            // 
            this.mdiManager.AllowDragDrop = DevExpress.Utils.DefaultBoolean.True;
            this.mdiManager.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.mdiManager.AppearancePage.Header.Font = new System.Drawing.Font("Arial", 9F);
            this.mdiManager.AppearancePage.Header.Options.UseFont = true;
            this.mdiManager.AppearancePage.HeaderActive.Font = new System.Drawing.Font("Arial", 9F);
            this.mdiManager.AppearancePage.HeaderActive.Options.UseFont = true;
            this.mdiManager.AppearancePage.HeaderDisabled.Font = new System.Drawing.Font("Arial", 9F);
            this.mdiManager.AppearancePage.HeaderDisabled.Options.UseFont = true;
            this.mdiManager.AppearancePage.HeaderHotTracked.Font = new System.Drawing.Font("Arial", 9F);
            this.mdiManager.AppearancePage.HeaderHotTracked.Options.UseFont = true;
            this.mdiManager.AppearancePage.PageClient.Font = new System.Drawing.Font("Arial", 9F);
            this.mdiManager.AppearancePage.PageClient.Options.UseFont = true;
            this.mdiManager.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.mdiManager.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.mdiManager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeaderAndOnMouseHover;
            this.mdiManager.CloseTabOnMiddleClick = DevExpress.XtraTabbedMdi.CloseTabOnMiddleClick.OnMouseUp;
            this.mdiManager.FloatOnDrag = DevExpress.Utils.DefaultBoolean.True;
            this.mdiManager.HeaderButtons = DevExpress.XtraTab.TabButtons.Close;
            this.mdiManager.HeaderButtonsShowMode = DevExpress.XtraTab.TabButtonShowMode.WhenNeeded;
            this.mdiManager.MdiParent = this;
            this.mdiManager.PageImagePosition = DevExpress.XtraTab.TabPageImagePosition.None;
            this.mdiManager.PinPageButtonShowMode = DevExpress.XtraTab.PinPageButtonShowMode.InActiveTabPageHeaderAndOnMouseHover;
            this.mdiManager.UseDocumentSelector = DevExpress.Utils.DefaultBoolean.False;
            this.mdiManager.UseFormIconAsPageImage = DevExpress.Utils.DefaultBoolean.True;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "MFS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.mdiManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager mdiManager;
    }
}