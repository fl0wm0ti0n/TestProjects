namespace JSON_Deserealising_Test
{
    partial class jsonparser
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
            this.rawjsonBox = new System.Windows.Forms.GroupBox();
            this.checkPeriodically = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cleardebugButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.deserializeButton = new System.Windows.Forms.Button();
            this.rawjsonTextbox = new System.Windows.Forms.TextBox();
            this.debugjsonBox = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.debugTextbox = new System.Windows.Forms.TextBox();
            this.deserializeListButton = new System.Windows.Forms.Button();
            this.rawjsonBox.SuspendLayout();
            this.debugjsonBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // rawjsonBox
            // 
            this.rawjsonBox.Controls.Add(this.deserializeListButton);
            this.rawjsonBox.Controls.Add(this.checkPeriodically);
            this.rawjsonBox.Controls.Add(this.progressBar1);
            this.rawjsonBox.Controls.Add(this.cleardebugButton);
            this.rawjsonBox.Controls.Add(this.listBox1);
            this.rawjsonBox.Controls.Add(this.deserializeButton);
            this.rawjsonBox.Controls.Add(this.rawjsonTextbox);
            this.rawjsonBox.Location = new System.Drawing.Point(12, 12);
            this.rawjsonBox.Name = "rawjsonBox";
            this.rawjsonBox.Size = new System.Drawing.Size(544, 139);
            this.rawjsonBox.TabIndex = 0;
            this.rawjsonBox.TabStop = false;
            this.rawjsonBox.Text = "Raw JSON";
            this.rawjsonBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkPeriodically
            // 
            this.checkPeriodically.AutoSize = true;
            this.checkPeriodically.Location = new System.Drawing.Point(235, 110);
            this.checkPeriodically.Name = "checkPeriodically";
            this.checkPeriodically.Size = new System.Drawing.Size(112, 17);
            this.checkPeriodically.TabIndex = 2;
            this.checkPeriodically.Text = "Check periodically";
            this.checkPeriodically.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 48);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(340, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // cleardebugButton
            // 
            this.cleardebugButton.Location = new System.Drawing.Point(88, 104);
            this.cleardebugButton.Name = "cleardebugButton";
            this.cleardebugButton.Size = new System.Drawing.Size(75, 23);
            this.cleardebugButton.TabIndex = 3;
            this.cleardebugButton.Text = "Clear Debug";
            this.cleardebugButton.UseVisualStyleBackColor = true;
            this.cleardebugButton.Click += new System.EventHandler(this.cleardebugButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(353, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(185, 108);
            this.listBox1.TabIndex = 4;
            // 
            // deserializeButton
            // 
            this.deserializeButton.Location = new System.Drawing.Point(6, 77);
            this.deserializeButton.Name = "deserializeButton";
            this.deserializeButton.Size = new System.Drawing.Size(75, 23);
            this.deserializeButton.TabIndex = 2;
            this.deserializeButton.Text = "Deserialize";
            this.deserializeButton.UseVisualStyleBackColor = true;
            this.deserializeButton.Click += new System.EventHandler(this.deserializeButton_Click);
            // 
            // rawjsonTextbox
            // 
            this.rawjsonTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rawjsonTextbox.Location = new System.Drawing.Point(7, 19);
            this.rawjsonTextbox.Multiline = true;
            this.rawjsonTextbox.Name = "rawjsonTextbox";
            this.rawjsonTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rawjsonTextbox.Size = new System.Drawing.Size(340, 23);
            this.rawjsonTextbox.TabIndex = 0;
            // 
            // debugjsonBox
            // 
            this.debugjsonBox.Controls.Add(this.listView1);
            this.debugjsonBox.Controls.Add(this.debugTextbox);
            this.debugjsonBox.Location = new System.Drawing.Point(12, 157);
            this.debugjsonBox.Name = "debugjsonBox";
            this.debugjsonBox.Size = new System.Drawing.Size(544, 287);
            this.debugjsonBox.TabIndex = 1;
            this.debugjsonBox.TabStop = false;
            this.debugjsonBox.Text = "Debug Output";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(353, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(185, 262);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // debugTextbox
            // 
            this.debugTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.debugTextbox.Location = new System.Drawing.Point(7, 19);
            this.debugTextbox.Multiline = true;
            this.debugTextbox.Name = "debugTextbox";
            this.debugTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.debugTextbox.Size = new System.Drawing.Size(340, 262);
            this.debugTextbox.TabIndex = 1;
            // 
            // deserializeListButton
            // 
            this.deserializeListButton.Location = new System.Drawing.Point(88, 77);
            this.deserializeListButton.Name = "deserializeListButton";
            this.deserializeListButton.Size = new System.Drawing.Size(85, 23);
            this.deserializeListButton.TabIndex = 5;
            this.deserializeListButton.Text = "Deserialize List";
            this.deserializeListButton.UseVisualStyleBackColor = true;
            this.deserializeListButton.Click += new System.EventHandler(this.deserializeListButton_Click);
            // 
            // jsonparser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 456);
            this.Controls.Add(this.debugjsonBox);
            this.Controls.Add(this.rawjsonBox);
            this.Name = "jsonparser";
            this.Text = "JSON-Parser";
            this.rawjsonBox.ResumeLayout(false);
            this.rawjsonBox.PerformLayout();
            this.debugjsonBox.ResumeLayout(false);
            this.debugjsonBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox rawjsonBox;
        private System.Windows.Forms.GroupBox debugjsonBox;
        private System.Windows.Forms.Button deserializeButton;
        private System.Windows.Forms.Button cleardebugButton;
        private System.Windows.Forms.TextBox rawjsonTextbox;
        private System.Windows.Forms.TextBox debugTextbox;
        private System.Windows.Forms.CheckBox checkPeriodically;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button deserializeListButton;
    }
}

