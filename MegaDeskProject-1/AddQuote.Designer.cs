namespace MegaDeskProject_1
{
    partial class AddQuote
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.DeskDepthLabel = new System.Windows.Forms.Label();
            this.DrawerNumberLabel = new System.Windows.Forms.Label();
            this.SurfaceMaterialLabel = new System.Windows.Forms.Label();
            this.RushOrderLabel = new System.Windows.Forms.Label();
            this.TxtFullName = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnAddQuote = new System.Windows.Forms.Button();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.cmbxSurfaceMaterial = new System.Windows.Forms.ComboBox();
            this.cmbxRushOrder = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(24, 43);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(226, 30);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Customer Name:";
            // 
            // DeskDepthLabel
            // 
            this.DeskDepthLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.DeskDepthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskDepthLabel.Location = new System.Drawing.Point(24, 144);
            this.DeskDepthLabel.Name = "DeskDepthLabel";
            this.DeskDepthLabel.Size = new System.Drawing.Size(100, 30);
            this.DeskDepthLabel.TabIndex = 3;
            this.DeskDepthLabel.Text = "Depth:";
            // 
            // DrawerNumberLabel
            // 
            this.DrawerNumberLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.DrawerNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawerNumberLabel.Location = new System.Drawing.Point(270, 95);
            this.DrawerNumberLabel.Name = "DrawerNumberLabel";
            this.DrawerNumberLabel.Size = new System.Drawing.Size(264, 30);
            this.DrawerNumberLabel.TabIndex = 4;
            this.DrawerNumberLabel.Text = "Number of Drawers:";
            // 
            // SurfaceMaterialLabel
            // 
            this.SurfaceMaterialLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.SurfaceMaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurfaceMaterialLabel.Location = new System.Drawing.Point(303, 144);
            this.SurfaceMaterialLabel.Name = "SurfaceMaterialLabel";
            this.SurfaceMaterialLabel.Size = new System.Drawing.Size(231, 30);
            this.SurfaceMaterialLabel.TabIndex = 5;
            this.SurfaceMaterialLabel.Text = "Surface Material:";
            // 
            // RushOrderLabel
            // 
            this.RushOrderLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.RushOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushOrderLabel.Location = new System.Drawing.Point(303, 193);
            this.RushOrderLabel.Name = "RushOrderLabel";
            this.RushOrderLabel.Size = new System.Drawing.Size(231, 30);
            this.RushOrderLabel.TabIndex = 6;
            this.RushOrderLabel.Text = "Production Time:";
            // 
            // TxtFullName
            // 
            this.TxtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFullName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtFullName.Location = new System.Drawing.Point(256, 43);
            this.TxtFullName.Name = "TxtFullName";
            this.TxtFullName.Size = new System.Drawing.Size(231, 30);
            this.TxtFullName.TabIndex = 8;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(371, 303);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(205, 69);
            this.BtnExit.TabIndex = 13;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnAddQuote
            // 
            this.BtnAddQuote.Location = new System.Drawing.Point(12, 303);
            this.BtnAddQuote.Name = "BtnAddQuote";
            this.BtnAddQuote.Size = new System.Drawing.Size(205, 69);
            this.BtnAddQuote.TabIndex = 14;
            this.BtnAddQuote.Text = "Add This Quote";
            this.BtnAddQuote.UseVisualStyleBackColor = true;
            this.BtnAddQuote.Click += new System.EventHandler(this.BtnAddQuote_Click);
            // 
            // WidthLabel
            // 
            this.WidthLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.WidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthLabel.Location = new System.Drawing.Point(24, 96);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(97, 30);
            this.WidthLabel.TabIndex = 2;
            this.WidthLabel.Text = "Width:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(540, 99);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(53, 30);
            this.numericUpDown1.TabIndex = 16;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown3.Location = new System.Drawing.Point(127, 99);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(107, 26);
            this.numericUpDown3.TabIndex = 18;
            this.numericUpDown3.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown4.Location = new System.Drawing.Point(127, 147);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(107, 26);
            this.numericUpDown4.TabIndex = 19;
            this.numericUpDown4.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // cmbxSurfaceMaterial
            // 
            this.cmbxSurfaceMaterial.FormattingEnabled = true;
            this.cmbxSurfaceMaterial.Location = new System.Drawing.Point(540, 153);
            this.cmbxSurfaceMaterial.Name = "cmbxSurfaceMaterial";
            this.cmbxSurfaceMaterial.Size = new System.Drawing.Size(219, 24);
            this.cmbxSurfaceMaterial.TabIndex = 20;
            this.cmbxSurfaceMaterial.SelectedIndexChanged += new System.EventHandler(this.CmbxSurfaceMaterial_SelectedIndexChanged);
            // 
            // cmbxRushOrder
            // 
            this.cmbxRushOrder.FormattingEnabled = true;
            this.cmbxRushOrder.Items.AddRange(new object[] {
            "14 Day - Free",
            "7 Day",
            "5 Day",
            "3 Day"});
            this.cmbxRushOrder.Location = new System.Drawing.Point(540, 202);
            this.cmbxRushOrder.Name = "cmbxRushOrder";
            this.cmbxRushOrder.Size = new System.Drawing.Size(219, 24);
            this.cmbxRushOrder.TabIndex = 21;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 477);
            this.Controls.Add(this.cmbxRushOrder);
            this.Controls.Add(this.cmbxSurfaceMaterial);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.BtnAddQuote);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.TxtFullName);
            this.Controls.Add(this.RushOrderLabel);
            this.Controls.Add(this.SurfaceMaterialLabel);
            this.Controls.Add(this.DrawerNumberLabel);
            this.Controls.Add(this.DeskDepthLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DeskDepthLabel;
        private System.Windows.Forms.Label DrawerNumberLabel;
        private System.Windows.Forms.Label SurfaceMaterialLabel;
        private System.Windows.Forms.Label RushOrderLabel;
        private System.Windows.Forms.TextBox TxtFullName;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnAddQuote;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.ComboBox cmbxSurfaceMaterial;
        private System.Windows.Forms.ComboBox cmbxRushOrder;
    }
}