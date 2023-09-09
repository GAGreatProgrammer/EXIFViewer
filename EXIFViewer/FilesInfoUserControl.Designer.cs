namespace EXIFViewer
{
    partial class FilesInfoUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilesInfoUserControl));
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.pbFile = new System.Windows.Forms.PictureBox();
            this.lblFile = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblHash = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbFile)).BeginInit();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 20;
            this.Elipse.TargetControl = this;
            // 
            // btnClose
            // 
            this.btnClose.ActiveImage = null;
            this.btnClose.AllowAnimations = true;
            this.btnClose.AllowBuffering = false;
            this.btnClose.AllowToggling = false;
            this.btnClose.AllowZooming = true;
            this.btnClose.AllowZoomingOnFocus = false;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ErrorImage")));
            this.btnClose.FadeWhenInactive = false;
            this.btnClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnClose.Image = global::EXIFViewer.Properties.Resources.CloseFile;
            this.btnClose.ImageActive = null;
            this.btnClose.ImageLocation = null;
            this.btnClose.ImageMargin = 5;
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.ImageZoomSize = new System.Drawing.Size(25, 25);
            this.btnClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnClose.InitialImage")));
            this.btnClose.Location = new System.Drawing.Point(520, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0;
            this.btnClose.ShowActiveImage = true;
            this.btnClose.ShowCursorChanges = true;
            this.btnClose.ShowImageBorders = true;
            this.btnClose.ShowSizeMarkers = false;
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 26;
            this.btnClose.ToolTipText = "";
            this.btnClose.WaitOnLoad = false;
            this.btnClose.Zoom = 5;
            this.btnClose.ZoomSpeed = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbFile
            // 
            this.pbFile.Image = global::EXIFViewer.Properties.Resources.File;
            this.pbFile.Location = new System.Drawing.Point(10, 12);
            this.pbFile.Name = "pbFile";
            this.pbFile.Size = new System.Drawing.Size(35, 35);
            this.pbFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFile.TabIndex = 27;
            this.pbFile.TabStop = false;
            // 
            // lblFile
            // 
            this.lblFile.AllowParentOverrides = false;
            this.lblFile.AutoEllipsis = false;
            this.lblFile.AutoSize = false;
            this.lblFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFile.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFile.ForeColor = System.Drawing.Color.White;
            this.lblFile.Location = new System.Drawing.Point(55, 7);
            this.lblFile.Name = "lblFile";
            this.lblFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFile.Size = new System.Drawing.Size(430, 21);
            this.lblFile.TabIndex = 28;
            this.lblFile.Text = "C:\\Users\\giorg\\source\\repos\\...";
            this.lblFile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblFile.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblHash
            // 
            this.lblHash.AllowParentOverrides = false;
            this.lblHash.AutoEllipsis = false;
            this.lblHash.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblHash.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblHash.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblHash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.lblHash.Location = new System.Drawing.Point(135, 35);
            this.lblHash.Name = "lblHash";
            this.lblHash.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHash.Size = new System.Drawing.Size(234, 17);
            this.lblHash.TabIndex = 32;
            this.lblHash.Text = "D651AFF55A919DC77BBC01D27520FDCE";
            this.lblHash.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblHash.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.bunifuLabel2.Location = new System.Drawing.Point(55, 35);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(73, 17);
            this.bunifuLabel2.TabIndex = 31;
            this.bunifuLabel2.Text = "MD5 HASH:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // FilesInfoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.lblHash);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.pbFile);
            this.Controls.Add(this.btnClose);
            this.Name = "FilesInfoUserControl";
            this.Size = new System.Drawing.Size(560, 60);
            this.Load += new System.EventHandler(this.FilesInfoUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private Bunifu.UI.WinForms.BunifuLabel lblHash;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel lblFile;
        private System.Windows.Forms.PictureBox pbFile;
        private Bunifu.UI.WinForms.BunifuImageButton btnClose;
    }
}
