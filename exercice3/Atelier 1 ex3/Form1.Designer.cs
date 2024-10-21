namespace Atelier_1_ex3
{
    partial class Form1
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
            this.txt_eq1 = new System.Windows.Forms.TextBox();
            this.txt_eq2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_eq2 = new System.Windows.Forms.RadioButton();
            this.rdb_eq1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_np = new System.Windows.Forms.ComboBox();
            this.Btn_Ajout = new System.Windows.Forms.Button();
            this.Btn_Résultat = new System.Windows.Forms.Button();
            this.Btn_RAZ = new System.Windows.Forms.Button();
            this.List_eq1 = new System.Windows.Forms.ListBox();
            this.List_eq2 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(16, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Equipe 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(16, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Equipe 2";
            // 
            // txt_eq1
            // 
            this.txt_eq1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_eq1.Location = new System.Drawing.Point(116, 64);
            this.txt_eq1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_eq1.Name = "txt_eq1";
            this.txt_eq1.Size = new System.Drawing.Size(187, 26);
            this.txt_eq1.TabIndex = 2;
            // 
            // txt_eq2
            // 
            this.txt_eq2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_eq2.Location = new System.Drawing.Point(116, 99);
            this.txt_eq2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_eq2.Name = "txt_eq2";
            this.txt_eq2.Size = new System.Drawing.Size(187, 26);
            this.txt_eq2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_eq2);
            this.groupBox1.Controls.Add(this.rdb_eq1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox1.Location = new System.Drawing.Point(21, 168);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(250, 146);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Point marqué par :";
            // 
            // rdb_eq2
            // 
            this.rdb_eq2.AutoSize = true;
            this.rdb_eq2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdb_eq2.Location = new System.Drawing.Point(39, 82);
            this.rdb_eq2.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_eq2.Name = "rdb_eq2";
            this.rdb_eq2.Size = new System.Drawing.Size(95, 24);
            this.rdb_eq2.TabIndex = 1;
            this.rdb_eq2.TabStop = true;
            this.rdb_eq2.Text = "Equipe 2";
            this.rdb_eq2.UseVisualStyleBackColor = true;
            // 
            // rdb_eq1
            // 
            this.rdb_eq1.AutoSize = true;
            this.rdb_eq1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdb_eq1.Location = new System.Drawing.Point(39, 40);
            this.rdb_eq1.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_eq1.Name = "rdb_eq1";
            this.rdb_eq1.Size = new System.Drawing.Size(95, 24);
            this.rdb_eq1.TabIndex = 0;
            this.rdb_eq1.TabStop = true;
            this.rdb_eq1.Text = "Equipe 1";
            this.rdb_eq1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(16, 341);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type d\'operation ";
            // 
            // cmb_np
            // 
            this.cmb_np.FormattingEnabled = true;
            this.cmb_np.Location = new System.Drawing.Point(184, 341);
            this.cmb_np.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_np.Name = "cmb_np";
            this.cmb_np.Size = new System.Drawing.Size(324, 28);
            this.cmb_np.TabIndex = 6;
            this.cmb_np.SelectedIndexChanged += new System.EventHandler(this.cmb_np_SelectedIndexChanged);
            // 
            // Btn_Ajout
            // 
            this.Btn_Ajout.Location = new System.Drawing.Point(211, 415);
            this.Btn_Ajout.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Ajout.Name = "Btn_Ajout";
            this.Btn_Ajout.Size = new System.Drawing.Size(94, 40);
            this.Btn_Ajout.TabIndex = 7;
            this.Btn_Ajout.Text = "Ajouter";
            this.Btn_Ajout.UseVisualStyleBackColor = true;
            this.Btn_Ajout.Click += new System.EventHandler(this.Btn_Ajout_Click);
            // 
            // Btn_Résultat
            // 
            this.Btn_Résultat.Location = new System.Drawing.Point(329, 415);
            this.Btn_Résultat.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Résultat.Name = "Btn_Résultat";
            this.Btn_Résultat.Size = new System.Drawing.Size(94, 39);
            this.Btn_Résultat.TabIndex = 8;
            this.Btn_Résultat.Text = "Résultat";
            this.Btn_Résultat.UseVisualStyleBackColor = true;
            this.Btn_Résultat.Click += new System.EventHandler(this.Btn_Résultat_Click);
            // 
            // Btn_RAZ
            // 
            this.Btn_RAZ.Location = new System.Drawing.Point(455, 415);
            this.Btn_RAZ.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_RAZ.Name = "Btn_RAZ";
            this.Btn_RAZ.Size = new System.Drawing.Size(94, 39);
            this.Btn_RAZ.TabIndex = 9;
            this.Btn_RAZ.Text = "RAZ";
            this.Btn_RAZ.UseVisualStyleBackColor = true;
            this.Btn_RAZ.Click += new System.EventHandler(this.Btn_RAZ_Click);
            // 
            // List_eq1
            // 
            this.List_eq1.FormattingEnabled = true;
            this.List_eq1.ItemHeight = 20;
            this.List_eq1.Location = new System.Drawing.Point(359, 50);
            this.List_eq1.Name = "List_eq1";
            this.List_eq1.Size = new System.Drawing.Size(210, 244);
            this.List_eq1.TabIndex = 10;
            // 
            // List_eq2
            // 
            this.List_eq2.FormattingEnabled = true;
            this.List_eq2.ItemHeight = 20;
            this.List_eq2.Location = new System.Drawing.Point(625, 50);
            this.List_eq2.Name = "List_eq2";
            this.List_eq2.Size = new System.Drawing.Size(187, 244);
            this.List_eq2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(375, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "EQUIPE 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(657, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "EQUIPE 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 477);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.List_eq2);
            this.Controls.Add(this.List_eq1);
            this.Controls.Add(this.Btn_RAZ);
            this.Controls.Add(this.Btn_Résultat);
            this.Controls.Add(this.Btn_Ajout);
            this.Controls.Add(this.cmb_np);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_eq2);
            this.Controls.Add(this.txt_eq1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Gestion d\'un match de rugby";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_eq1;
        private System.Windows.Forms.TextBox txt_eq2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_eq2;
        private System.Windows.Forms.RadioButton rdb_eq1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_np;
        private System.Windows.Forms.Button Btn_Ajout;
        private System.Windows.Forms.Button Btn_Résultat;
        private System.Windows.Forms.Button Btn_RAZ;
        private System.Windows.Forms.ListBox List_eq1;
        private System.Windows.Forms.ListBox List_eq2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

