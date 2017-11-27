namespace InstrumentSettingsProject
{
    partial class InstrumentSettingsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstrumentSettingsControl));
            this.instrumentEditTabPage = new System.Windows.Forms.TabPage();
            this.instrumentPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.saveButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.errorViewTabPage = new System.Windows.Forms.TabPage();
            this.objInstrument = new BrightIdeasSoftware.ObjectListView();
            this.IDColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.NameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ISINColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.BloombergIDColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PriceColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ErrorColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.instrumentTabControl = new System.Windows.Forms.TabControl();
            this.instrumentEditTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.errorViewTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objInstrument)).BeginInit();
            this.instrumentTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // instrumentEditTabPage
            // 
            this.instrumentEditTabPage.Controls.Add(this.logoPictureBox);
            this.instrumentEditTabPage.Controls.Add(this.closeButton);
            this.instrumentEditTabPage.Controls.Add(this.saveButton);
            this.instrumentEditTabPage.Controls.Add(this.instrumentPropertyGrid);
            this.instrumentEditTabPage.Location = new System.Drawing.Point(4, 22);
            this.instrumentEditTabPage.Name = "instrumentEditTabPage";
            this.instrumentEditTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.instrumentEditTabPage.Size = new System.Drawing.Size(955, 848);
            this.instrumentEditTabPage.TabIndex = 1;
            this.instrumentEditTabPage.Text = "Instrument View";
            this.instrumentEditTabPage.UseVisualStyleBackColor = true;
            // 
            // instrumentPropertyGrid
            // 
            this.instrumentPropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.instrumentPropertyGrid.Location = new System.Drawing.Point(6, 6);
            this.instrumentPropertyGrid.Name = "instrumentPropertyGrid";
            this.instrumentPropertyGrid.Size = new System.Drawing.Size(427, 836);
            this.instrumentPropertyGrid.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(439, 781);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(110, 61);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(555, 781);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(110, 61);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.BackgroundImage")));
            this.logoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logoPictureBox.Location = new System.Drawing.Point(439, 6);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(500, 500);
            this.logoPictureBox.TabIndex = 4;
            this.logoPictureBox.TabStop = false;
            // 
            // errorViewTabPage
            // 
            this.errorViewTabPage.Controls.Add(this.objInstrument);
            this.errorViewTabPage.Location = new System.Drawing.Point(4, 22);
            this.errorViewTabPage.Name = "errorViewTabPage";
            this.errorViewTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.errorViewTabPage.Size = new System.Drawing.Size(955, 848);
            this.errorViewTabPage.TabIndex = 0;
            this.errorViewTabPage.Text = "Error View";
            this.errorViewTabPage.UseVisualStyleBackColor = true;
            // 
            // objInstrument
            // 
            this.objInstrument.AllColumns.Add(this.IDColumn);
            this.objInstrument.AllColumns.Add(this.NameColumn);
            this.objInstrument.AllColumns.Add(this.ISINColumn);
            this.objInstrument.AllColumns.Add(this.BloombergIDColumn);
            this.objInstrument.AllColumns.Add(this.PriceColumn);
            this.objInstrument.AllColumns.Add(this.ErrorColumn);
            this.objInstrument.CellEditUseWholeCell = false;
            this.objInstrument.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDColumn,
            this.NameColumn,
            this.ISINColumn,
            this.BloombergIDColumn,
            this.PriceColumn,
            this.ErrorColumn});
            this.objInstrument.Cursor = System.Windows.Forms.Cursors.Default;
            this.objInstrument.Location = new System.Drawing.Point(6, 6);
            this.objInstrument.Name = "objInstrument";
            this.objInstrument.Size = new System.Drawing.Size(943, 836);
            this.objInstrument.TabIndex = 0;
            this.objInstrument.UseCompatibleStateImageBehavior = false;
            this.objInstrument.View = System.Windows.Forms.View.Details;
            // 
            // IDColumn
            // 
            this.IDColumn.Text = "ID";
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Instrument Name";
            this.NameColumn.Width = 218;
            // 
            // ISINColumn
            // 
            this.ISINColumn.Text = "ISIN";
            this.ISINColumn.Width = 128;
            // 
            // BloombergIDColumn
            // 
            this.BloombergIDColumn.Text = "BloombergID";
            this.BloombergIDColumn.Width = 172;
            // 
            // PriceColumn
            // 
            this.PriceColumn.Text = "Price";
            this.PriceColumn.Width = 83;
            // 
            // ErrorColumn
            // 
            this.ErrorColumn.Text = "Error Message";
            this.ErrorColumn.Width = 270;
            // 
            // instrumentTabControl
            // 
            this.instrumentTabControl.Controls.Add(this.errorViewTabPage);
            this.instrumentTabControl.Controls.Add(this.instrumentEditTabPage);
            this.instrumentTabControl.Location = new System.Drawing.Point(3, 3);
            this.instrumentTabControl.Name = "instrumentTabControl";
            this.instrumentTabControl.SelectedIndex = 0;
            this.instrumentTabControl.Size = new System.Drawing.Size(963, 874);
            this.instrumentTabControl.TabIndex = 1;
            // 
            // InstrumentSettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.instrumentTabControl);
            this.Name = "InstrumentSettingsControl";
            this.Size = new System.Drawing.Size(969, 880);
            this.instrumentEditTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.errorViewTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objInstrument)).EndInit();
            this.instrumentTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage instrumentEditTabPage;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.PropertyGrid instrumentPropertyGrid;
        private System.Windows.Forms.TabPage errorViewTabPage;
        private BrightIdeasSoftware.ObjectListView objInstrument;
        private BrightIdeasSoftware.OLVColumn IDColumn;
        private BrightIdeasSoftware.OLVColumn NameColumn;
        private BrightIdeasSoftware.OLVColumn ISINColumn;
        private BrightIdeasSoftware.OLVColumn BloombergIDColumn;
        private BrightIdeasSoftware.OLVColumn PriceColumn;
        private BrightIdeasSoftware.OLVColumn ErrorColumn;
        public System.Windows.Forms.TabControl instrumentTabControl;
    }
}
