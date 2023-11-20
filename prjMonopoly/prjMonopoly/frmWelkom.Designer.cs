namespace prjMonopoly
{
    partial class frmWelkom
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
            this.btnSpeel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSpeel
            // 
            this.btnSpeel.Location = new System.Drawing.Point(13, 415);
            this.btnSpeel.Name = "btnSpeel";
            this.btnSpeel.Size = new System.Drawing.Size(75, 23);
            this.btnSpeel.TabIndex = 0;
            this.btnSpeel.Text = "Speel";
            this.btnSpeel.UseVisualStyleBackColor = true;
            this.btnSpeel.Click += new System.EventHandler(this.btnSpeel_Click);
            // 
            // frmWelkom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSpeel);
            this.Name = "frmWelkom";
            this.Text = "Welkom";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSpeel;
    }
}

