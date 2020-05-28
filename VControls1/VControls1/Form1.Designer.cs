namespace VControls1
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
            this.textBoxEingabe = new System.Windows.Forms.TextBox();
            this.buttonGibAus = new System.Windows.Forms.Button();
            this.pictureUnpassend = new System.Windows.Forms.PictureBox();
            this.labelAusgabe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUnpassend)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxEingabe
            // 
            this.textBoxEingabe.Location = new System.Drawing.Point(53, 38);
            this.textBoxEingabe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEingabe.Name = "textBoxEingabe";
            this.textBoxEingabe.Size = new System.Drawing.Size(149, 26);
            this.textBoxEingabe.TabIndex = 0;
            this.textBoxEingabe.Text = "Eingabe";
            // 
            // buttonGibAus
            // 
            this.buttonGibAus.Location = new System.Drawing.Point(52, 96);
            this.buttonGibAus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonGibAus.Name = "buttonGibAus";
            this.buttonGibAus.Size = new System.Drawing.Size(150, 45);
            this.buttonGibAus.TabIndex = 1;
            this.buttonGibAus.Text = "gib aus";
            this.buttonGibAus.UseVisualStyleBackColor = true;
            this.buttonGibAus.Click += new System.EventHandler(this.buttonGibAus_Click);
            // 
            // pictureUnpassend
            // 
            this.pictureUnpassend.Location = new System.Drawing.Point(301, 38);
            this.pictureUnpassend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureUnpassend.Name = "pictureUnpassend";
            this.pictureUnpassend.Size = new System.Drawing.Size(480, 659);
            this.pictureUnpassend.TabIndex = 2;
            this.pictureUnpassend.TabStop = false;
            // 
            // labelAusgabe
            // 
            this.labelAusgabe.AutoSize = true;
            this.labelAusgabe.Location = new System.Drawing.Point(60, 165);
            this.labelAusgabe.Name = "labelAusgabe";
            this.labelAusgabe.Size = new System.Drawing.Size(73, 20);
            this.labelAusgabe.TabIndex = 3;
            this.labelAusgabe.Text = "Ausgabe";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 725);
            this.Controls.Add(this.labelAusgabe);
            this.Controls.Add(this.pictureUnpassend);
            this.Controls.Add(this.buttonGibAus);
            this.Controls.Add(this.textBoxEingabe);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureUnpassend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAusgabe;
        private System.Windows.Forms.PictureBox pictureUnpassend;
        private System.Windows.Forms.Button buttonGibAus;
        private System.Windows.Forms.TextBox textBoxEingabe;
    }
}

