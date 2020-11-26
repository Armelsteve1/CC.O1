namespace formEtablisement
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcontactee = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmaile = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.pictureBoxlogoecole = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewecole = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.txtRecherchEcole = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogoecole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewecole)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(352, 47);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(148, 24);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom de l\'etablisement";
            // 
            // cancel
            // 
            this.cancel.ForeColor = System.Drawing.Color.Red;
            this.cancel.Location = new System.Drawing.Point(1, 304);
            this.cancel.Margin = new System.Windows.Forms.Padding(4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(78, 41);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contacte";
            // 
            // txtcontactee
            // 
            this.txtcontactee.Location = new System.Drawing.Point(352, 116);
            this.txtcontactee.Margin = new System.Windows.Forms.Padding(4);
            this.txtcontactee.Name = "txtcontactee";
            this.txtcontactee.Size = new System.Drawing.Size(148, 24);
            this.txtcontactee.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // txtEmaile
            // 
            this.txtEmaile.Location = new System.Drawing.Point(352, 184);
            this.txtEmaile.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmaile.Name = "txtEmaile";
            this.txtEmaile.Size = new System.Drawing.Size(148, 24);
            this.txtEmaile.TabIndex = 5;
            // 
            // btnsave
            // 
            this.btnsave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnsave.Location = new System.Drawing.Point(257, 304);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(85, 41);
            this.btnsave.TabIndex = 7;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // pictureBoxlogoecole
            // 
            this.pictureBoxlogoecole.Location = new System.Drawing.Point(12, 69);
            this.pictureBoxlogoecole.Name = "pictureBoxlogoecole";
            this.pictureBoxlogoecole.Size = new System.Drawing.Size(143, 184);
            this.pictureBoxlogoecole.TabIndex = 8;
            this.pictureBoxlogoecole.TabStop = false;
            this.pictureBoxlogoecole.Click += new System.EventHandler(this.pictureBoxlogoecole_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "logo";
            // 
            // dataGridViewecole
            // 
            this.dataGridViewecole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewecole.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.column2,
            this.Column3,
            this.Column4});
            this.dataGridViewecole.Location = new System.Drawing.Point(558, 99);
            this.dataGridViewecole.Name = "dataGridViewecole";
            this.dataGridViewecole.Size = new System.Drawing.Size(433, 261);
            this.dataGridViewecole.TabIndex = 10;
            this.dataGridViewecole.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Logo";
            this.Column1.Name = "Column1";
            // 
            // column2
            // 
            this.column2.HeaderText = "Nom";
            this.column2.Name = "column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Contacte";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Email";
            this.Column4.Name = "Column4";
            // 
            // btnmodifier
            // 
            this.btnmodifier.ForeColor = System.Drawing.Color.DimGray;
            this.btnmodifier.Location = new System.Drawing.Point(142, 304);
            this.btnmodifier.Margin = new System.Windows.Forms.Padding(4);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(75, 41);
            this.btnmodifier.TabIndex = 11;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = true;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.ForeColor = System.Drawing.Color.Red;
            this.btnsupprimer.Location = new System.Drawing.Point(394, 304);
            this.btnsupprimer.Margin = new System.Windows.Forms.Padding(4);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(91, 41);
            this.btnsupprimer.TabIndex = 12;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = true;
            this.btnsupprimer.Click += new System.EventHandler(this.btnsupprimer_Click);
            // 
            // txtRecherchEcole
            // 
            this.txtRecherchEcole.Location = new System.Drawing.Point(558, 69);
            this.txtRecherchEcole.Name = "txtRecherchEcole";
            this.txtRecherchEcole.Size = new System.Drawing.Size(433, 24);
            this.txtRecherchEcole.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(555, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Recherche";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 386);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRecherchEcole);
            this.Controls.Add(this.btnsupprimer);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.dataGridViewecole);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBoxlogoecole);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmaile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcontactee);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogoecole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewecole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcontactee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmaile;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.PictureBox pictureBoxlogoecole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewecole;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.TextBox txtRecherchEcole;
        private System.Windows.Forms.Label label5;
    }
}