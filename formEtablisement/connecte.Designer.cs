namespace formEtablisement
{
    partial class connecte
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
            this.btnconecole = new System.Windows.Forms.Button();
            this.btnconetudiant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnconecole
            // 
            this.btnconecole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnconecole.Location = new System.Drawing.Point(24, 58);
            this.btnconecole.Name = "btnconecole";
            this.btnconecole.Size = new System.Drawing.Size(138, 51);
            this.btnconecole.TabIndex = 0;
            this.btnconecole.Text = "  Ecole";
            this.btnconecole.UseVisualStyleBackColor = true;
            this.btnconecole.Click += new System.EventHandler(this.btnconecole_Click);
            // 
            // btnconetudiant
            // 
            this.btnconetudiant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnconetudiant.Location = new System.Drawing.Point(24, 185);
            this.btnconetudiant.Name = "btnconetudiant";
            this.btnconetudiant.Size = new System.Drawing.Size(138, 51);
            this.btnconetudiant.TabIndex = 1;
            this.btnconetudiant.Text = "Etudiant";
            this.btnconetudiant.UseVisualStyleBackColor = true;
            this.btnconetudiant.Click += new System.EventHandler(this.btnconetudiant_Click);
            // 
            // connecte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 293);
            this.Controls.Add(this.btnconetudiant);
            this.Controls.Add(this.btnconecole);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "connecte";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnconecole;
        private System.Windows.Forms.Button btnconetudiant;
    }
}