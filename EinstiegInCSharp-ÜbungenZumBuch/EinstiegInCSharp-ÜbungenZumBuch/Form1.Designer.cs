namespace EinstiegInCSharp_ÜbungenZumBuch
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.anzeigen1 = new System.Windows.Forms.Button();
            this.anzeigen2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // anzeigen1
            // 
            this.anzeigen1.Location = new System.Drawing.Point(172, 7);
            this.anzeigen1.Name = "anzeigen1";
            this.anzeigen1.Size = new System.Drawing.Size(75, 23);
            this.anzeigen1.TabIndex = 0;
            this.anzeigen1.Text = "Anzeigen 1";
            this.anzeigen1.UseVisualStyleBackColor = true;
            this.anzeigen1.Click += new System.EventHandler(this.anzeigen1_Click);
            // 
            // anzeigen2
            // 
            this.anzeigen2.Location = new System.Drawing.Point(172, 37);
            this.anzeigen2.Name = "anzeigen2";
            this.anzeigen2.Size = new System.Drawing.Size(75, 23);
            this.anzeigen2.TabIndex = 1;
            this.anzeigen2.Text = "Anzeigen 2";
            this.anzeigen2.UseVisualStyleBackColor = true;
            this.anzeigen2.Click += new System.EventHandler(this.anzeigen2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 65);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.anzeigen2);
            this.Controls.Add(this.anzeigen1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button anzeigen1;
        private System.Windows.Forms.Button anzeigen2;
        private System.Windows.Forms.Label label1;
    }
}

