namespace MegaDeskProject_1
{
    partial class MainMenu
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
            this.BtnAddQuote = new System.Windows.Forms.Button();
            this.BtnViewQuotes = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.BtnSeachQuotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAddQuote
            // 
            this.BtnAddQuote.Location = new System.Drawing.Point(45, 57);
            this.BtnAddQuote.Name = "BtnAddQuote";
            this.BtnAddQuote.Size = new System.Drawing.Size(205, 69);
            this.BtnAddQuote.TabIndex = 0;
            this.BtnAddQuote.Text = "Add New Quote";
            this.BtnAddQuote.UseVisualStyleBackColor = true;
            this.BtnAddQuote.Click += new System.EventHandler(this.BtnAddQuote_Click);
            // 
            // BtnViewQuotes
            // 
            this.BtnViewQuotes.Location = new System.Drawing.Point(47, 132);
            this.BtnViewQuotes.Name = "BtnViewQuotes";
            this.BtnViewQuotes.Size = new System.Drawing.Size(205, 69);
            this.BtnViewQuotes.TabIndex = 1;
            this.BtnViewQuotes.Text = "View Quotes";
            this.BtnViewQuotes.UseVisualStyleBackColor = true;
            this.BtnViewQuotes.Click += new System.EventHandler(this.BtnViewQuotes_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(47, 282);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(205, 69);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BtnSeachQuotes
            // 
            this.BtnSeachQuotes.Location = new System.Drawing.Point(47, 207);
            this.BtnSeachQuotes.Name = "BtnSeachQuotes";
            this.BtnSeachQuotes.Size = new System.Drawing.Size(205, 69);
            this.BtnSeachQuotes.TabIndex = 5;
            this.BtnSeachQuotes.Text = "Search Quotes";
            this.BtnSeachQuotes.UseVisualStyleBackColor = true;
            this.BtnSeachQuotes.Click += new System.EventHandler(this.BtnSeachQuotes_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSeachQuotes);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.BtnViewQuotes);
            this.Controls.Add(this.BtnAddQuote);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAddQuote;
        private System.Windows.Forms.Button BtnViewQuotes;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button BtnSeachQuotes;
    }
}

