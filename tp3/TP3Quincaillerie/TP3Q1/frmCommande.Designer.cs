namespace TP3Q1
{
    partial class frmCommande
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstNum = new System.Windows.Forms.ListBox();
            this.lstObjet = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCoûtAprèsRabais = new System.Windows.Forms.Label();
            this.lblRabais = new System.Windows.Forms.Label();
            this.lblCoûtAprèsFrais = new System.Windows.Forms.Label();
            this.lblFraisEmb = new System.Windows.Forms.Label();
            this.lblCoûtArt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboQuantité = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lstAffichage = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quincaillerie du Coin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numéro";
            // 
            // lstNum
            // 
            this.lstNum.FormattingEnabled = true;
            this.lstNum.ItemHeight = 16;
            this.lstNum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.lstNum.Location = new System.Drawing.Point(25, 82);
            this.lstNum.Name = "lstNum";
            this.lstNum.Size = new System.Drawing.Size(55, 212);
            this.lstNum.TabIndex = 3;
            this.lstNum.SelectedIndexChanged += new System.EventHandler(this.lstObjet_SelectedIndexChanged);
            // 
            // lstObjet
            // 
            this.lstObjet.FormattingEnabled = true;
            this.lstObjet.ItemHeight = 16;
            this.lstObjet.Items.AddRange(new object[] {
            "Clou",
            "Vis",
            "Marteau",
            "Perceuse",
            "Écrou",
            "Tournevis",
            "Clé anglaise",
            "Pied-de-biche",
            "Pinces",
            "Vélo",
            "Ruban à mesurer",
            "Ruban adhésif",
            "Pelle",
            "Compresseur à air",
            "Sac de sable",
            ""});
            this.lstObjet.Location = new System.Drawing.Point(126, 82);
            this.lstObjet.Name = "lstObjet";
            this.lstObjet.Size = new System.Drawing.Size(120, 212);
            this.lstObjet.TabIndex = 4;
            this.lstObjet.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCoûtAprèsRabais);
            this.groupBox1.Controls.Add(this.lblRabais);
            this.groupBox1.Controls.Add(this.lblCoûtAprèsFrais);
            this.groupBox1.Controls.Add(this.lblFraisEmb);
            this.groupBox1.Controls.Add(this.lblCoûtArt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 233);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facture Client";
            // 
            // lblCoûtAprèsRabais
            // 
            this.lblCoûtAprèsRabais.AutoSize = true;
            this.lblCoûtAprèsRabais.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCoûtAprèsRabais.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCoûtAprèsRabais.Location = new System.Drawing.Point(322, 198);
            this.lblCoûtAprèsRabais.MinimumSize = new System.Drawing.Size(100, 20);
            this.lblCoûtAprèsRabais.Name = "lblCoûtAprèsRabais";
            this.lblCoûtAprèsRabais.Size = new System.Drawing.Size(100, 20);
            this.lblCoûtAprèsRabais.TabIndex = 9;
            // 
            // lblRabais
            // 
            this.lblRabais.AutoSize = true;
            this.lblRabais.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRabais.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRabais.Location = new System.Drawing.Point(322, 155);
            this.lblRabais.MinimumSize = new System.Drawing.Size(100, 20);
            this.lblRabais.Name = "lblRabais";
            this.lblRabais.Size = new System.Drawing.Size(100, 20);
            this.lblRabais.TabIndex = 8;
            // 
            // lblCoûtAprèsFrais
            // 
            this.lblCoûtAprèsFrais.AutoSize = true;
            this.lblCoûtAprèsFrais.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCoûtAprèsFrais.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCoûtAprèsFrais.Location = new System.Drawing.Point(322, 115);
            this.lblCoûtAprèsFrais.MinimumSize = new System.Drawing.Size(100, 20);
            this.lblCoûtAprèsFrais.Name = "lblCoûtAprèsFrais";
            this.lblCoûtAprèsFrais.Size = new System.Drawing.Size(100, 20);
            this.lblCoûtAprèsFrais.TabIndex = 7;
            // 
            // lblFraisEmb
            // 
            this.lblFraisEmb.AutoSize = true;
            this.lblFraisEmb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFraisEmb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFraisEmb.Location = new System.Drawing.Point(322, 75);
            this.lblFraisEmb.MinimumSize = new System.Drawing.Size(100, 20);
            this.lblFraisEmb.Name = "lblFraisEmb";
            this.lblFraisEmb.Size = new System.Drawing.Size(100, 20);
            this.lblFraisEmb.TabIndex = 6;
            // 
            // lblCoûtArt
            // 
            this.lblCoûtArt.AutoSize = true;
            this.lblCoûtArt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCoûtArt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCoûtArt.Location = new System.Drawing.Point(322, 35);
            this.lblCoûtArt.MinimumSize = new System.Drawing.Size(100, 20);
            this.lblCoûtArt.Name = "lblCoûtArt";
            this.lblCoûtArt.Size = new System.Drawing.Size(100, 20);
            this.lblCoûtArt.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Coût de l\'Article après rabais :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Rabais : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Coût de l\'article après frais : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Frais d\'emballage et d\'expédition : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Coût de l\'article :";
            // 
            // cboQuantité
            // 
            this.cboQuantité.FormattingEnabled = true;
            this.cboQuantité.Location = new System.Drawing.Point(281, 116);
            this.cboQuantité.Name = "cboQuantité";
            this.cboQuantité.Size = new System.Drawing.Size(59, 24);
            this.cboQuantité.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Quantité";
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(281, 201);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(59, 22);
            this.txtPrix.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(292, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Prix";
            // 
            // lstAffichage
            // 
            this.lstAffichage.FormattingEnabled = true;
            this.lstAffichage.ItemHeight = 16;
            this.lstAffichage.Location = new System.Drawing.Point(509, 82);
            this.lstAffichage.Name = "lstAffichage";
            this.lstAffichage.Size = new System.Drawing.Size(541, 260);
            this.lstAffichage.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 49);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(855, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 49);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(632, 436);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 49);
            this.button3.TabIndex = 16;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(855, 436);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 49);
            this.button4.TabIndex = 17;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(554, 514);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(198, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Montant total de la commande";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(774, 511);
            this.label11.MinimumSize = new System.Drawing.Size(200, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 20);
            this.label11.TabIndex = 10;
            // 
            // frmCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 537);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstAffichage);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboQuantité);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstObjet);
            this.Controls.Add(this.lstNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCommande";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCommande_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstNum;
        private System.Windows.Forms.ListBox lstObjet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCoûtAprèsRabais;
        private System.Windows.Forms.Label lblRabais;
        private System.Windows.Forms.Label lblCoûtAprèsFrais;
        private System.Windows.Forms.Label lblFraisEmb;
        private System.Windows.Forms.Label lblCoûtArt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboQuantité;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstAffichage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

