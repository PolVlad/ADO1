namespace datenbank
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
            this.buttonConOpen = new System.Windows.Forms.Button();
            this.buttonSQLCommand = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.listBoxDatenbank = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonConOpen
            // 
            this.buttonConOpen.Location = new System.Drawing.Point(24, 22);
            this.buttonConOpen.Name = "buttonConOpen";
            this.buttonConOpen.Size = new System.Drawing.Size(156, 23);
            this.buttonConOpen.TabIndex = 0;
            this.buttonConOpen.Text = "Connection öffnen";
            this.buttonConOpen.UseVisualStyleBackColor = true;
            this.buttonConOpen.Click += new System.EventHandler(this.buttonConOpen_Click);
            // 
            // buttonSQLCommand
            // 
            this.buttonSQLCommand.Enabled = false;
            this.buttonSQLCommand.Location = new System.Drawing.Point(24, 68);
            this.buttonSQLCommand.Name = "buttonSQLCommand";
            this.buttonSQLCommand.Size = new System.Drawing.Size(156, 23);
            this.buttonSQLCommand.TabIndex = 1;
            this.buttonSQLCommand.Text = "SQL - Command";
            this.buttonSQLCommand.UseVisualStyleBackColor = true;
            this.buttonSQLCommand.Click += new System.EventHandler(this.buttonSQLCommand_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Enabled = false;
            this.buttonRead.Location = new System.Drawing.Point(24, 113);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(156, 23);
            this.buttonRead.TabIndex = 2;
            this.buttonRead.Text = "auslesen";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // listBoxDatenbank
            // 
            this.listBoxDatenbank.FormattingEnabled = true;
            this.listBoxDatenbank.Location = new System.Drawing.Point(24, 154);
            this.listBoxDatenbank.Name = "listBoxDatenbank";
            this.listBoxDatenbank.Size = new System.Drawing.Size(248, 95);
            this.listBoxDatenbank.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.listBoxDatenbank);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.buttonSQLCommand);
            this.Controls.Add(this.buttonConOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConOpen;
        private System.Windows.Forms.Button buttonSQLCommand;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.ListBox listBoxDatenbank;
    }
}

