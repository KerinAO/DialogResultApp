namespace DialogResultApp
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
            this.btnOtvori = new System.Windows.Forms.Button();
            this.txtRezultat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOtvori
            // 
            this.btnOtvori.Location = new System.Drawing.Point(165, 61);
            this.btnOtvori.Name = "btnOtvori";
            this.btnOtvori.Size = new System.Drawing.Size(238, 35);
            this.btnOtvori.TabIndex = 0;
            this.btnOtvori.Text = "Otvori MessageBox";
            this.btnOtvori.UseVisualStyleBackColor = true;
            this.btnOtvori.Click += new System.EventHandler(this.btnOtvori_Click);
            // 
            // txtRezultat
            // 
            this.txtRezultat.Location = new System.Drawing.Point(84, 124);
            this.txtRezultat.Multiline = true;
            this.txtRezultat.Name = "txtRezultat";
            this.txtRezultat.Size = new System.Drawing.Size(395, 149);
            this.txtRezultat.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 307);
            this.Controls.Add(this.txtRezultat);
            this.Controls.Add(this.btnOtvori);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOtvori;
        private System.Windows.Forms.TextBox txtRezultat;
    }
}

