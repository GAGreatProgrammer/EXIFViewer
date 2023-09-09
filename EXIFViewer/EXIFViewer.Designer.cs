namespace EXIFViewer
{
    partial class EXIFViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EXIFViewer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.bunifuLabel7 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dgvEXIF = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btnChooseFile = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblText = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.FilesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.pbFile = new System.Windows.Forms.PictureBox();
            this.panelUploadFile = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnExport = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.ScrollBar = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.btnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnInspect = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.lblFilePath = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEXIF)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFile)).BeginInit();
            this.bunifuPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.bunifuLabel3.Location = new System.Drawing.Point(185, 30);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(158, 21);
            this.bunifuLabel3.TabIndex = 5;
            this.bunifuLabel3.Text = "Easily view EXIF data";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel2.Location = new System.Drawing.Point(88, 20);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(81, 37);
            this.bunifuLabel2.TabIndex = 4;
            this.bunifuLabel2.Text = "Viewer";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(30, 20);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(55, 37);
            this.bunifuLabel1.TabIndex = 3;
            this.bunifuLabel1.Text = "EXIF";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel4.Location = new System.Drawing.Point(30, 75);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(108, 30);
            this.bunifuLabel4.TabIndex = 6;
            this.bunifuLabel4.Text = "Upload file";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel5.Location = new System.Drawing.Point(30, 290);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(141, 30);
            this.bunifuLabel5.TabIndex = 7;
            this.bunifuLabel5.Text = "Uploaded files";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "openFileDialog1";
            // 
            // bunifuLabel7
            // 
            this.bunifuLabel7.AllowParentOverrides = false;
            this.bunifuLabel7.AutoEllipsis = false;
            this.bunifuLabel7.CursorType = null;
            this.bunifuLabel7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel7.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel7.Location = new System.Drawing.Point(663, 75);
            this.bunifuLabel7.Name = "bunifuLabel7";
            this.bunifuLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel7.Size = new System.Drawing.Size(94, 30);
            this.bunifuLabel7.TabIndex = 37;
            this.bunifuLabel7.Text = "EXIF Data";
            this.bunifuLabel7.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.dgvEXIF;
            // 
            // dgvEXIF
            // 
            this.dgvEXIF.AllowCustomTheming = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvEXIF.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEXIF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEXIF.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEXIF.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.dgvEXIF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEXIF.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvEXIF.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvEXIF.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEXIF.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEXIF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEXIF.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.dgvEXIF.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.dgvEXIF.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEXIF.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.dgvEXIF.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEXIF.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.dgvEXIF.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.dgvEXIF.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.dgvEXIF.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.dgvEXIF.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEXIF.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.dgvEXIF.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEXIF.CurrentTheme.Name = null;
            this.dgvEXIF.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.dgvEXIF.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.dgvEXIF.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEXIF.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvEXIF.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEXIF.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEXIF.EnableHeadersVisualStyles = false;
            this.dgvEXIF.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.dgvEXIF.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.dgvEXIF.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvEXIF.HeaderForeColor = System.Drawing.Color.White;
            this.dgvEXIF.Location = new System.Drawing.Point(10, 10);
            this.dgvEXIF.Name = "dgvEXIF";
            this.dgvEXIF.ReadOnly = true;
            this.dgvEXIF.RowHeadersVisible = false;
            this.dgvEXIF.RowTemplate.Height = 40;
            this.dgvEXIF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEXIF.ShowCellErrors = false;
            this.dgvEXIF.ShowEditingIcon = false;
            this.dgvEXIF.ShowRowErrors = false;
            this.dgvEXIF.Size = new System.Drawing.Size(505, 490);
            this.dgvEXIF.TabIndex = 33;
            this.dgvEXIF.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.AllowDrop = true;
            this.btnChooseFile.AllowParentOverrides = false;
            this.btnChooseFile.AutoEllipsis = false;
            this.btnChooseFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseFile.CursorType = System.Windows.Forms.Cursors.Hand;
            this.btnChooseFile.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnChooseFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.btnChooseFile.Location = new System.Drawing.Point(420, 205);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnChooseFile.Size = new System.Drawing.Size(106, 30);
            this.btnChooseFile.TabIndex = 43;
            this.btnChooseFile.Text = "choose file";
            this.btnChooseFile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.btnChooseFile.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            this.btnChooseFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnChooseFile_DragDrop);
            this.btnChooseFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnChooseFile_DragEnter);
            this.btnChooseFile.DragLeave += new System.EventHandler(this.btnChooseFile_DragLeave);
            // 
            // lblText
            // 
            this.lblText.AllowDrop = true;
            this.lblText.AllowParentOverrides = false;
            this.lblText.AutoEllipsis = false;
            this.lblText.CursorType = null;
            this.lblText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblText.ForeColor = System.Drawing.Color.White;
            this.lblText.Location = new System.Drawing.Point(127, 205);
            this.lblText.Name = "lblText";
            this.lblText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblText.Size = new System.Drawing.Size(288, 30);
            this.lblText.TabIndex = 42;
            this.lblText.Text = "Drag & drop your file here or ";
            this.lblText.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblText.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblText.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblText_DragDrop);
            this.lblText.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblText_DragEnter);
            this.lblText.DragLeave += new System.EventHandler(this.lblText_DragLeave);
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 20;
            this.bunifuElipse3.TargetControl = this.FilesPanel;
            // 
            // FilesPanel
            // 
            this.FilesPanel.Location = new System.Drawing.Point(10, 8);
            this.FilesPanel.Name = "FilesPanel";
            this.FilesPanel.Size = new System.Drawing.Size(565, 200);
            this.FilesPanel.TabIndex = 30;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.White;
            this.bunifuPanel1.BorderRadius = 30;
            this.bunifuPanel1.BorderThickness = 2;
            this.bunifuPanel1.Controls.Add(this.FilesPanel);
            this.bunifuPanel1.Location = new System.Drawing.Point(30, 326);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(585, 218);
            this.bunifuPanel1.TabIndex = 37;
            // 
            // pbFile
            // 
            this.pbFile.Image = ((System.Drawing.Image)(resources.GetObject("pbFile.Image")));
            this.pbFile.Location = new System.Drawing.Point(297, 130);
            this.pbFile.Name = "pbFile";
            this.pbFile.Size = new System.Drawing.Size(70, 70);
            this.pbFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFile.TabIndex = 45;
            this.pbFile.TabStop = false;
            this.pbFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbFile_DragDrop);
            this.pbFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbFile_DragEnter);
            this.pbFile.DragLeave += new System.EventHandler(this.pbFile_DragLeave);
            // 
            // panelUploadFile
            // 
            this.panelUploadFile.AllowAnimations = true;
            this.panelUploadFile.AllowDrop = true;
            this.panelUploadFile.AllowMouseEffects = true;
            this.panelUploadFile.AllowToggling = false;
            this.panelUploadFile.AnimationSpeed = 200;
            this.panelUploadFile.AutoGenerateColors = false;
            this.panelUploadFile.AutoRoundBorders = false;
            this.panelUploadFile.AutoSizeLeftIcon = true;
            this.panelUploadFile.AutoSizeRightIcon = true;
            this.panelUploadFile.BackColor = System.Drawing.Color.Transparent;
            this.panelUploadFile.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.panelUploadFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelUploadFile.BackgroundImage")));
            this.panelUploadFile.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Dash;
            this.panelUploadFile.ButtonText = "";
            this.panelUploadFile.ButtonTextMarginLeft = 0;
            this.panelUploadFile.ColorContrastOnClick = 45;
            this.panelUploadFile.ColorContrastOnHover = 45;
            this.panelUploadFile.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.panelUploadFile.CustomizableEdges = borderEdges1;
            this.panelUploadFile.DialogResult = System.Windows.Forms.DialogResult.None;
            this.panelUploadFile.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.panelUploadFile.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.panelUploadFile.DisabledForecolor = System.Drawing.Color.White;
            this.panelUploadFile.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.panelUploadFile.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelUploadFile.ForeColor = System.Drawing.Color.White;
            this.panelUploadFile.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelUploadFile.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.panelUploadFile.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.panelUploadFile.IconMarginLeft = 11;
            this.panelUploadFile.IconPadding = 10;
            this.panelUploadFile.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.panelUploadFile.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.panelUploadFile.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.panelUploadFile.IconSize = 25;
            this.panelUploadFile.IdleBorderColor = System.Drawing.Color.White;
            this.panelUploadFile.IdleBorderRadius = 50;
            this.panelUploadFile.IdleBorderThickness = 3;
            this.panelUploadFile.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.panelUploadFile.IdleIconLeftImage = null;
            this.panelUploadFile.IdleIconRightImage = null;
            this.panelUploadFile.IndicateFocus = false;
            this.panelUploadFile.Location = new System.Drawing.Point(30, 110);
            this.panelUploadFile.Name = "panelUploadFile";
            this.panelUploadFile.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.panelUploadFile.OnDisabledState.BorderRadius = 50;
            this.panelUploadFile.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Dash;
            this.panelUploadFile.OnDisabledState.BorderThickness = 3;
            this.panelUploadFile.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.panelUploadFile.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.panelUploadFile.OnDisabledState.IconLeftImage = null;
            this.panelUploadFile.OnDisabledState.IconRightImage = null;
            this.panelUploadFile.onHoverState.BorderColor = System.Drawing.Color.White;
            this.panelUploadFile.onHoverState.BorderRadius = 50;
            this.panelUploadFile.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Dash;
            this.panelUploadFile.onHoverState.BorderThickness = 3;
            this.panelUploadFile.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.panelUploadFile.onHoverState.ForeColor = System.Drawing.Color.White;
            this.panelUploadFile.onHoverState.IconLeftImage = null;
            this.panelUploadFile.onHoverState.IconRightImage = null;
            this.panelUploadFile.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.panelUploadFile.OnIdleState.BorderRadius = 50;
            this.panelUploadFile.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Dash;
            this.panelUploadFile.OnIdleState.BorderThickness = 3;
            this.panelUploadFile.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.panelUploadFile.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.panelUploadFile.OnIdleState.IconLeftImage = null;
            this.panelUploadFile.OnIdleState.IconRightImage = null;
            this.panelUploadFile.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.panelUploadFile.OnPressedState.BorderRadius = 50;
            this.panelUploadFile.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Dash;
            this.panelUploadFile.OnPressedState.BorderThickness = 3;
            this.panelUploadFile.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.panelUploadFile.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.panelUploadFile.OnPressedState.IconLeftImage = null;
            this.panelUploadFile.OnPressedState.IconRightImage = null;
            this.panelUploadFile.Size = new System.Drawing.Size(600, 170);
            this.panelUploadFile.TabIndex = 41;
            this.panelUploadFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.panelUploadFile.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.panelUploadFile.TextMarginLeft = 0;
            this.panelUploadFile.TextPadding = new System.Windows.Forms.Padding(0);
            this.panelUploadFile.UseDefaultRadiusAndThickness = true;
            this.panelUploadFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelUploadFile_DragDrop);
            this.panelUploadFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelUploadFile_DragEnter_1);
            this.panelUploadFile.DragLeave += new System.EventHandler(this.panelUploadFile_DragLeave_1);
            // 
            // btnExport
            // 
            this.btnExport.AllowAnimations = true;
            this.btnExport.AllowMouseEffects = true;
            this.btnExport.AllowToggling = false;
            this.btnExport.AnimationSpeed = 200;
            this.btnExport.AutoGenerateColors = false;
            this.btnExport.AutoRoundBorders = false;
            this.btnExport.AutoSizeLeftIcon = true;
            this.btnExport.AutoSizeRightIcon = true;
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.btnExport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExport.BackgroundImage")));
            this.btnExport.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnExport.ButtonText = "Export to File";
            this.btnExport.ButtonTextMarginLeft = 0;
            this.btnExport.ColorContrastOnClick = 45;
            this.btnExport.ColorContrastOnHover = 45;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnExport.CustomizableEdges = borderEdges2;
            this.btnExport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExport.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btnExport.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.btnExport.DisabledForecolor = System.Drawing.Color.White;
            this.btnExport.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnExport.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnExport.IconMarginLeft = 11;
            this.btnExport.IconPadding = 10;
            this.btnExport.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnExport.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnExport.IconSize = 25;
            this.btnExport.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btnExport.IdleBorderRadius = 10;
            this.btnExport.IdleBorderThickness = 1;
            this.btnExport.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.btnExport.IdleIconLeftImage = null;
            this.btnExport.IdleIconRightImage = null;
            this.btnExport.IndicateFocus = false;
            this.btnExport.Location = new System.Drawing.Point(235, 575);
            this.btnExport.Name = "btnExport";
            this.btnExport.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btnExport.OnDisabledState.BorderRadius = 10;
            this.btnExport.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnExport.OnDisabledState.BorderThickness = 1;
            this.btnExport.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.btnExport.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.btnExport.OnDisabledState.IconLeftImage = null;
            this.btnExport.OnDisabledState.IconRightImage = null;
            this.btnExport.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btnExport.onHoverState.BorderRadius = 10;
            this.btnExport.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnExport.onHoverState.BorderThickness = 1;
            this.btnExport.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.btnExport.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnExport.onHoverState.IconLeftImage = null;
            this.btnExport.onHoverState.IconRightImage = null;
            this.btnExport.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btnExport.OnIdleState.BorderRadius = 10;
            this.btnExport.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnExport.OnIdleState.BorderThickness = 1;
            this.btnExport.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.btnExport.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnExport.OnIdleState.IconLeftImage = null;
            this.btnExport.OnIdleState.IconRightImage = null;
            this.btnExport.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btnExport.OnPressedState.BorderRadius = 10;
            this.btnExport.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnExport.OnPressedState.BorderThickness = 1;
            this.btnExport.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.btnExport.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnExport.OnPressedState.IconLeftImage = null;
            this.btnExport.OnPressedState.IconRightImage = null;
            this.btnExport.Size = new System.Drawing.Size(170, 45);
            this.btnExport.TabIndex = 38;
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExport.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExport.TextMarginLeft = 0;
            this.btnExport.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnExport.UseDefaultRadiusAndThickness = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.bunifuPanel3.BorderRadius = 30;
            this.bunifuPanel3.BorderThickness = 2;
            this.bunifuPanel3.Controls.Add(this.dgvEXIF);
            this.bunifuPanel3.Location = new System.Drawing.Point(645, 110);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.ShowBorders = true;
            this.bunifuPanel3.Size = new System.Drawing.Size(525, 510);
            this.bunifuPanel3.TabIndex = 36;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.White;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(30, 550);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(585, 14);
            this.bunifuSeparator1.TabIndex = 29;
            // 
            // ScrollBar
            // 
            this.ScrollBar.AllowCursorChanges = true;
            this.ScrollBar.AllowHomeEndKeysDetection = false;
            this.ScrollBar.AllowIncrementalClickMoves = true;
            this.ScrollBar.AllowMouseDownEffects = true;
            this.ScrollBar.AllowMouseHoverEffects = true;
            this.ScrollBar.AllowScrollingAnimations = true;
            this.ScrollBar.AllowScrollKeysDetection = true;
            this.ScrollBar.AllowScrollOptionsMenu = true;
            this.ScrollBar.AllowShrinkingOnFocusLost = false;
            this.ScrollBar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.ScrollBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ScrollBar.BackgroundImage")));
            this.ScrollBar.BindingContainer = this.FilesPanel;
            this.ScrollBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.ScrollBar.BorderRadius = 12;
            this.ScrollBar.BorderThickness = 1;
            this.ScrollBar.DurationBeforeShrink = 2000;
            this.ScrollBar.LargeChange = 10;
            this.ScrollBar.Location = new System.Drawing.Point(615, 326);
            this.ScrollBar.Maximum = 100;
            this.ScrollBar.Minimum = 0;
            this.ScrollBar.MinimumThumbLength = 18;
            this.ScrollBar.Name = "ScrollBar";
            this.ScrollBar.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.ScrollBar.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.ScrollBar.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.ScrollBar.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.ScrollBar.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.ScrollBar.ShrinkSizeLimit = 3;
            this.ScrollBar.Size = new System.Drawing.Size(15, 218);
            this.ScrollBar.SmallChange = 1;
            this.ScrollBar.TabIndex = 28;
            this.ScrollBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.ScrollBar.ThumbLength = 21;
            this.ScrollBar.ThumbMargin = 1;
            this.ScrollBar.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.ScrollBar.Value = 0;
            this.ScrollBar.Scroll += new System.EventHandler<Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs>(this.ScrollBar_Scroll);
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
            this.btnClose.Image = global::EXIFViewer.Properties.Resources.Close;
            this.btnClose.ImageActive = null;
            this.btnClose.ImageLocation = null;
            this.btnClose.ImageMargin = 5;
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.ImageZoomSize = new System.Drawing.Size(25, 25);
            this.btnClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnClose.InitialImage")));
            this.btnClose.Location = new System.Drawing.Point(1160, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0;
            this.btnClose.ShowActiveImage = true;
            this.btnClose.ShowCursorChanges = true;
            this.btnClose.ShowImageBorders = true;
            this.btnClose.ShowSizeMarkers = false;
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 27;
            this.btnClose.ToolTipText = "";
            this.btnClose.WaitOnLoad = false;
            this.btnClose.Zoom = 5;
            this.btnClose.ZoomSpeed = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnInspect
            // 
            this.btnInspect.AllowAnimations = true;
            this.btnInspect.AllowMouseEffects = true;
            this.btnInspect.AllowToggling = false;
            this.btnInspect.AnimationSpeed = 200;
            this.btnInspect.AutoGenerateColors = false;
            this.btnInspect.AutoRoundBorders = false;
            this.btnInspect.AutoSizeLeftIcon = true;
            this.btnInspect.AutoSizeRightIcon = true;
            this.btnInspect.BackColor = System.Drawing.Color.Transparent;
            this.btnInspect.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.btnInspect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInspect.BackgroundImage")));
            this.btnInspect.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnInspect.ButtonText = "Inspect";
            this.btnInspect.ButtonTextMarginLeft = 0;
            this.btnInspect.ColorContrastOnClick = 45;
            this.btnInspect.ColorContrastOnHover = 45;
            this.btnInspect.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnInspect.CustomizableEdges = borderEdges3;
            this.btnInspect.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnInspect.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btnInspect.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.btnInspect.DisabledForecolor = System.Drawing.Color.White;
            this.btnInspect.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnInspect.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInspect.ForeColor = System.Drawing.Color.White;
            this.btnInspect.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInspect.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnInspect.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnInspect.IconMarginLeft = 11;
            this.btnInspect.IconPadding = 10;
            this.btnInspect.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInspect.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnInspect.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnInspect.IconSize = 25;
            this.btnInspect.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btnInspect.IdleBorderRadius = 10;
            this.btnInspect.IdleBorderThickness = 1;
            this.btnInspect.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.btnInspect.IdleIconLeftImage = null;
            this.btnInspect.IdleIconRightImage = null;
            this.btnInspect.IndicateFocus = false;
            this.btnInspect.Location = new System.Drawing.Point(30, 575);
            this.btnInspect.Name = "btnInspect";
            this.btnInspect.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btnInspect.OnDisabledState.BorderRadius = 10;
            this.btnInspect.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnInspect.OnDisabledState.BorderThickness = 1;
            this.btnInspect.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.btnInspect.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.btnInspect.OnDisabledState.IconLeftImage = null;
            this.btnInspect.OnDisabledState.IconRightImage = null;
            this.btnInspect.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btnInspect.onHoverState.BorderRadius = 10;
            this.btnInspect.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnInspect.onHoverState.BorderThickness = 1;
            this.btnInspect.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.btnInspect.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnInspect.onHoverState.IconLeftImage = null;
            this.btnInspect.onHoverState.IconRightImage = null;
            this.btnInspect.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btnInspect.OnIdleState.BorderRadius = 10;
            this.btnInspect.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnInspect.OnIdleState.BorderThickness = 1;
            this.btnInspect.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.btnInspect.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnInspect.OnIdleState.IconLeftImage = null;
            this.btnInspect.OnIdleState.IconRightImage = null;
            this.btnInspect.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btnInspect.OnPressedState.BorderRadius = 10;
            this.btnInspect.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnInspect.OnPressedState.BorderThickness = 1;
            this.btnInspect.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.btnInspect.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnInspect.OnPressedState.IconLeftImage = null;
            this.btnInspect.OnPressedState.IconRightImage = null;
            this.btnInspect.Size = new System.Drawing.Size(170, 45);
            this.btnInspect.TabIndex = 14;
            this.btnInspect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInspect.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnInspect.TextMarginLeft = 0;
            this.btnInspect.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnInspect.UseDefaultRadiusAndThickness = true;
            this.btnInspect.Click += new System.EventHandler(this.btnInspect_Click);
            // 
            // lblFilePath
            // 
            this.lblFilePath.AllowDrop = true;
            this.lblFilePath.AllowParentOverrides = false;
            this.lblFilePath.AutoEllipsis = false;
            this.lblFilePath.AutoSize = false;
            this.lblFilePath.CursorType = null;
            this.lblFilePath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFilePath.ForeColor = System.Drawing.Color.Silver;
            this.lblFilePath.Location = new System.Drawing.Point(46, 240);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFilePath.Size = new System.Drawing.Size(570, 20);
            this.lblFilePath.TabIndex = 44;
            this.lblFilePath.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFilePath.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblFilePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblFilePath_DragDrop);
            this.lblFilePath.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblFilePath_DragEnter);
            this.lblFilePath.DragLeave += new System.EventHandler(this.lblFilePath_DragLeave);
            // 
            // EXIFViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.pbFile);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.panelUploadFile);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.bunifuLabel7);
            this.Controls.Add(this.bunifuPanel3);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.ScrollBar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInspect);
            this.Controls.Add(this.bunifuLabel5);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EXIFViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EXIFViewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEXIF)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFile)).EndInit();
            this.bunifuPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnInspect;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.UI.WinForms.BunifuVScrollBar ScrollBar;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.FlowLayoutPanel FilesPanel;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel7;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvEXIF;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnExport;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 panelUploadFile;
        private System.Windows.Forms.PictureBox pbFile;
        private Bunifu.UI.WinForms.BunifuLabel btnChooseFile;
        private Bunifu.UI.WinForms.BunifuLabel lblText;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.UI.WinForms.BunifuLabel lblFilePath;
    }
}

