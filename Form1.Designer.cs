namespace EasierMocking
{
    partial class Form1
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
            this.openConverterButton = new System.Windows.Forms.Button();
            this.toggleCb = new System.Windows.Forms.CheckBox();
            this.cTextbox = new System.Windows.Forms.RichTextBox();
            this.cButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openConverterButton
            // 
            this.openConverterButton.Location = new System.Drawing.Point(12, 12);
            this.openConverterButton.Name = "openConverterButton";
            this.openConverterButton.Size = new System.Drawing.Size(145, 23);
            this.openConverterButton.TabIndex = 0;
            this.openConverterButton.Text = "Converter";
            this.openConverterButton.UseVisualStyleBackColor = true;
            // 
            // toggleCb
            // 
            this.toggleCb.AutoSize = true;
            this.toggleCb.Location = new System.Drawing.Point(12, 41);
            this.toggleCb.Name = "toggleCb";
            this.toggleCb.Size = new System.Drawing.Size(59, 17);
            this.toggleCb.TabIndex = 1;
            this.toggleCb.Text = "Toggle";
            this.toggleCb.UseVisualStyleBackColor = true;
            // 
            // cTextbox
            // 
            this.cTextbox.Location = new System.Drawing.Point(207, 2);
            this.cTextbox.Name = "cTextbox";
            this.cTextbox.Size = new System.Drawing.Size(312, 67);
            this.cTextbox.TabIndex = 2;
            this.cTextbox.Text = "";
            // 
            // cButton
            // 
            this.cButton.BackColor = System.Drawing.Color.Transparent;
            this.cButton.FlatAppearance.BorderSize = 0;
            this.cButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cButton.Location = new System.Drawing.Point(525, 2);
            this.cButton.Name = "cButton";
            this.cButton.Size = new System.Drawing.Size(54, 60);
            this.cButton.TabIndex = 3;
            this.cButton.Text = "Convert";
            this.cButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 67);
            this.Controls.Add(this.cButton);
            this.Controls.Add(this.cTextbox);
            this.Controls.Add(this.toggleCb);
            this.Controls.Add(this.openConverterButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "EasierMocking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openConverterButton;
        private System.Windows.Forms.CheckBox toggleCb;
        private System.Windows.Forms.RichTextBox cTextbox;
        private System.Windows.Forms.Button cButton;
    }
}

