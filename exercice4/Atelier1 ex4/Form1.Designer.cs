namespace Atelier1_ex4
{
    partial class Btn_Reset
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cmb_Sexe = new System.Windows.Forms.GroupBox();
            this.Opt_Fem = new System.Windows.Forms.RadioButton();
            this.Opt_Mas = new System.Windows.Forms.RadioButton();
            this.Btn_Ajout = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Chk_Prod = new System.Windows.Forms.CheckBox();
            this.Chk_Transport = new System.Windows.Forms.CheckBox();
            this.Cmb_Fonction = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Cmb_Situation = new System.Windows.Forms.ComboBox();
            this.Txt_Sal = new System.Windows.Forms.TextBox();
            this.Txt_NP = new System.Windows.Forms.TextBox();
            this.Txt_Mat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Lst_Mat = new System.Windows.Forms.ListBox();
            this.Lst_Emp = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Lst_Sal = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Btn_Quit = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Lbl_Nb_Emp = new System.Windows.Forms.TextBox();
            this.Lbl_Total_Sal = new System.Windows.Forms.TextBox();
            this.Lbl_Moyenne_Sal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Cmb_Sexe.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cmb_Sexe);
            this.groupBox1.Controls.Add(this.Btn_Ajout);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.Cmb_Fonction);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Cmb_Situation);
            this.groupBox1.Controls.Add(this.Txt_Sal);
            this.groupBox1.Controls.Add(this.Txt_NP);
            this.groupBox1.Controls.Add(this.Txt_Mat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(41, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saisie des données d\'un employé";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Cmb_Sexe
            // 
            this.Cmb_Sexe.Controls.Add(this.Opt_Fem);
            this.Cmb_Sexe.Controls.Add(this.Opt_Mas);
            this.Cmb_Sexe.Location = new System.Drawing.Point(399, 25);
            this.Cmb_Sexe.Name = "Cmb_Sexe";
            this.Cmb_Sexe.Size = new System.Drawing.Size(200, 100);
            this.Cmb_Sexe.TabIndex = 13;
            this.Cmb_Sexe.TabStop = false;
            this.Cmb_Sexe.Text = "Sexe";
            // 
            // Opt_Fem
            // 
            this.Opt_Fem.AutoSize = true;
            this.Opt_Fem.Location = new System.Drawing.Point(30, 60);
            this.Opt_Fem.Name = "Opt_Fem";
            this.Opt_Fem.Size = new System.Drawing.Size(86, 24);
            this.Opt_Fem.TabIndex = 1;
            this.Opt_Fem.TabStop = true;
            this.Opt_Fem.Text = "Femme";
            this.Opt_Fem.UseVisualStyleBackColor = true;
            // 
            // Opt_Mas
            // 
            this.Opt_Mas.AutoSize = true;
            this.Opt_Mas.Location = new System.Drawing.Point(27, 30);
            this.Opt_Mas.Name = "Opt_Mas";
            this.Opt_Mas.Size = new System.Drawing.Size(89, 24);
            this.Opt_Mas.TabIndex = 0;
            this.Opt_Mas.TabStop = true;
            this.Opt_Mas.Text = "Homme";
            this.Opt_Mas.UseVisualStyleBackColor = true;
            this.Opt_Mas.CheckedChanged += new System.EventHandler(this.Opt_Mas_CheckedChanged);
            // 
            // Btn_Ajout
            // 
            this.Btn_Ajout.Location = new System.Drawing.Point(658, 137);
            this.Btn_Ajout.Name = "Btn_Ajout";
            this.Btn_Ajout.Size = new System.Drawing.Size(142, 40);
            this.Btn_Ajout.TabIndex = 12;
            this.Btn_Ajout.Text = "Ajouter employe";
            this.Btn_Ajout.UseVisualStyleBackColor = true;
            this.Btn_Ajout.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Chk_Prod);
            this.groupBox3.Controls.Add(this.Chk_Transport);
            this.groupBox3.Location = new System.Drawing.Point(641, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 115);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Primes";
            // 
            // Chk_Prod
            // 
            this.Chk_Prod.AutoSize = true;
            this.Chk_Prod.Location = new System.Drawing.Point(17, 68);
            this.Chk_Prod.Name = "Chk_Prod";
            this.Chk_Prod.Size = new System.Drawing.Size(111, 24);
            this.Chk_Prod.TabIndex = 1;
            this.Chk_Prod.Text = "Production";
            this.Chk_Prod.UseVisualStyleBackColor = true;
            // 
            // Chk_Transport
            // 
            this.Chk_Transport.AutoSize = true;
            this.Chk_Transport.Location = new System.Drawing.Point(17, 38);
            this.Chk_Transport.Name = "Chk_Transport";
            this.Chk_Transport.Size = new System.Drawing.Size(103, 24);
            this.Chk_Transport.TabIndex = 0;
            this.Chk_Transport.Text = "Transport";
            this.Chk_Transport.UseVisualStyleBackColor = true;
            this.Chk_Transport.CheckedChanged += new System.EventHandler(this.Chk_Transport_CheckedChanged);
            // 
            // Cmb_Fonction
            // 
            this.Cmb_Fonction.FormattingEnabled = true;
            this.Cmb_Fonction.Location = new System.Drawing.Point(407, 135);
            this.Cmb_Fonction.Name = "Cmb_Fonction";
            this.Cmb_Fonction.Size = new System.Drawing.Size(162, 28);
            this.Cmb_Fonction.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fonction";
            // 
            // Cmb_Situation
            // 
            this.Cmb_Situation.FormattingEnabled = true;
            this.Cmb_Situation.Location = new System.Drawing.Point(172, 135);
            this.Cmb_Situation.Name = "Cmb_Situation";
            this.Cmb_Situation.Size = new System.Drawing.Size(150, 28);
            this.Cmb_Situation.TabIndex = 7;
            this.Cmb_Situation.SelectedIndexChanged += new System.EventHandler(this.Cmb_Situation_SelectedIndexChanged);
            // 
            // Txt_Sal
            // 
            this.Txt_Sal.Location = new System.Drawing.Point(152, 105);
            this.Txt_Sal.Name = "Txt_Sal";
            this.Txt_Sal.Size = new System.Drawing.Size(158, 26);
            this.Txt_Sal.TabIndex = 6;
            // 
            // Txt_NP
            // 
            this.Txt_NP.Location = new System.Drawing.Point(151, 71);
            this.Txt_NP.Name = "Txt_NP";
            this.Txt_NP.Size = new System.Drawing.Size(159, 26);
            this.Txt_NP.TabIndex = 5;
            // 
            // Txt_Mat
            // 
            this.Txt_Mat.Location = new System.Drawing.Point(151, 37);
            this.Txt_Mat.Name = "Txt_Mat";
            this.Txt_Mat.Size = new System.Drawing.Size(159, 26);
            this.Txt_Mat.TabIndex = 4;
            this.Txt_Mat.TextChanged += new System.EventHandler(this.Txt_Mat_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Situation Familiale";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salaire de base";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom et prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricule";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Matricule";
            // 
            // Lst_Mat
            // 
            this.Lst_Mat.FormattingEnabled = true;
            this.Lst_Mat.ItemHeight = 20;
            this.Lst_Mat.Location = new System.Drawing.Point(41, 251);
            this.Lst_Mat.Name = "Lst_Mat";
            this.Lst_Mat.Size = new System.Drawing.Size(145, 144);
            this.Lst_Mat.TabIndex = 2;
            // 
            // Lst_Emp
            // 
            this.Lst_Emp.FormattingEnabled = true;
            this.Lst_Emp.ItemHeight = 20;
            this.Lst_Emp.Location = new System.Drawing.Point(213, 262);
            this.Lst_Emp.Name = "Lst_Emp";
            this.Lst_Emp.Size = new System.Drawing.Size(383, 124);
            this.Lst_Emp.TabIndex = 3;
            this.Lst_Emp.SelectedIndexChanged += new System.EventHandler(this.Lst_Emp_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Nom -";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Prenom -";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(335, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Situation Familiale -";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(496, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Fonction";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(780, 228);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Salaire";
            // 
            // Lst_Sal
            // 
            this.Lst_Sal.FormattingEnabled = true;
            this.Lst_Sal.ItemHeight = 20;
            this.Lst_Sal.Location = new System.Drawing.Point(682, 262);
            this.Lst_Sal.Name = "Lst_Sal";
            this.Lst_Sal.Size = new System.Drawing.Size(206, 124);
            this.Lst_Sal.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 405);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Nombre total : ";
            // 
            // Btn_Quit
            // 
            this.Btn_Quit.Location = new System.Drawing.Point(65, 433);
            this.Btn_Quit.Name = "Btn_Quit";
            this.Btn_Quit.Size = new System.Drawing.Size(174, 31);
            this.Btn_Quit.TabIndex = 11;
            this.Btn_Quit.Text = "Quitter";
            this.Btn_Quit.UseVisualStyleBackColor = true;
            this.Btn_Quit.Click += new System.EventHandler(this.Btn_Quit_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(496, 405);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "Total Salaire Net :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(466, 433);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(174, 20);
            this.label14.TabIndex = 13;
            this.label14.Text = "Moyenne Salaire Net :";
            // 
            // Lbl_Nb_Emp
            // 
            this.Lbl_Nb_Emp.Location = new System.Drawing.Point(145, 402);
            this.Lbl_Nb_Emp.Name = "Lbl_Nb_Emp";
            this.Lbl_Nb_Emp.Size = new System.Drawing.Size(196, 26);
            this.Lbl_Nb_Emp.TabIndex = 14;
            // 
            // Lbl_Total_Sal
            // 
            this.Lbl_Total_Sal.Location = new System.Drawing.Point(646, 402);
            this.Lbl_Total_Sal.Name = "Lbl_Total_Sal";
            this.Lbl_Total_Sal.Size = new System.Drawing.Size(242, 26);
            this.Lbl_Total_Sal.TabIndex = 15;
            // 
            // Lbl_Moyenne_Sal
            // 
            this.Lbl_Moyenne_Sal.Location = new System.Drawing.Point(646, 435);
            this.Lbl_Moyenne_Sal.Name = "Lbl_Moyenne_Sal";
            this.Lbl_Moyenne_Sal.Size = new System.Drawing.Size(242, 26);
            this.Lbl_Moyenne_Sal.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 17;
            this.button1.Text = "RAZ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Btn_Reset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 476);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lbl_Moyenne_Sal);
            this.Controls.Add(this.Lbl_Total_Sal);
            this.Controls.Add(this.Lbl_Nb_Emp);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Btn_Quit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Lst_Sal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Lst_Emp);
            this.Controls.Add(this.Lst_Mat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Btn_Reset";
            this.Text = "Gestion des employés d\'une entreprise";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Cmb_Sexe.ResumeLayout(false);
            this.Cmb_Sexe.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Ajout;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox Chk_Prod;
        private System.Windows.Forms.CheckBox Chk_Transport;
        private System.Windows.Forms.RadioButton Opt_Fem;
        private System.Windows.Forms.RadioButton Opt_Mas;
        private System.Windows.Forms.ComboBox Cmb_Fonction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Cmb_Situation;
        private System.Windows.Forms.TextBox Txt_Sal;
        private System.Windows.Forms.TextBox Txt_NP;
        private System.Windows.Forms.TextBox Txt_Mat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox Lst_Mat;
        private System.Windows.Forms.ListBox Lst_Emp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox Lst_Sal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Btn_Quit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Lbl_Nb_Emp;
        private System.Windows.Forms.TextBox Lbl_Total_Sal;
        private System.Windows.Forms.TextBox Lbl_Moyenne_Sal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox Cmb_Sexe;
    }
}

