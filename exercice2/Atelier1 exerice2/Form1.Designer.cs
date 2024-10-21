using System;
using System.Runtime.Serialization;

namespace Atelier1_exerice2
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPen = new System.Windows.Forms.TextBox();
            this.grpSitFam = new System.Windows.Forms.GroupBox();
            this.optDiv = new System.Windows.Forms.RadioButton();
            this.optMar = new System.Windows.Forms.RadioButton();
            this.optCel = new System.Windows.Forms.RadioButton();
            this.grpEnf = new System.Windows.Forms.GroupBox();
            this.nbrenf = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdValider = new System.Windows.Forms.Button();
            this.cmdInitialiser = new System.Windows.Forms.Button();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.datn = new System.Windows.Forms.DateTimePicker();
            this.cmbSexe = new System.Windows.Forms.ComboBox();
            this.grpSitFam.SuspendLayout();
            this.grpEnf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbrenf)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Votre Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Votre  Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date de naissance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sexe";
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNom.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtNom.Location = new System.Drawing.Point(167, 37);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(216, 26);
            this.txtNom.TabIndex = 4;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // txtPen
            // 
            this.txtPen.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtPen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPen.Location = new System.Drawing.Point(167, 69);
            this.txtPen.Name = "txtPen";
            this.txtPen.Size = new System.Drawing.Size(216, 26);
            this.txtPen.TabIndex = 5;
            this.txtPen.TextChanged += new System.EventHandler(this.txtPen_TextChanged);
            // 
            // grpSitFam
            // 
            this.grpSitFam.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grpSitFam.Controls.Add(this.optDiv);
            this.grpSitFam.Controls.Add(this.optMar);
            this.grpSitFam.Controls.Add(this.optCel);
            this.grpSitFam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpSitFam.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpSitFam.Location = new System.Drawing.Point(167, 198);
            this.grpSitFam.Name = "grpSitFam";
            this.grpSitFam.Size = new System.Drawing.Size(200, 100);
            this.grpSitFam.TabIndex = 8;
            this.grpSitFam.TabStop = false;
            this.grpSitFam.Text = "Situation Familiale";
            this.grpSitFam.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // optDiv
            // 
            this.optDiv.AutoSize = true;
            this.optDiv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.optDiv.Location = new System.Drawing.Point(29, 73);
            this.optDiv.Name = "optDiv";
            this.optDiv.Size = new System.Drawing.Size(109, 24);
            this.optDiv.TabIndex = 2;
            this.optDiv.TabStop = true;
            this.optDiv.Text = "Divorsé(e)";
            this.optDiv.UseVisualStyleBackColor = true;
            this.optDiv.CheckedChanged += new System.EventHandler(this.optDiv_CheckedChanged);
            // 
            // optMar
            // 
            this.optMar.AutoSize = true;
            this.optMar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.optMar.Location = new System.Drawing.Point(29, 47);
            this.optMar.Name = "optMar";
            this.optMar.Size = new System.Drawing.Size(93, 24);
            this.optMar.TabIndex = 1;
            this.optMar.TabStop = true;
            this.optMar.Text = "Marié(e)";
            this.optMar.UseVisualStyleBackColor = true;
            this.optMar.CheckedChanged += new System.EventHandler(this.optMar_CheckedChanged);
            // 
            // optCel
            // 
            this.optCel.AutoSize = true;
            this.optCel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.optCel.Location = new System.Drawing.Point(29, 21);
            this.optCel.Name = "optCel";
            this.optCel.Size = new System.Drawing.Size(110, 24);
            this.optCel.TabIndex = 0;
            this.optCel.TabStop = true;
            this.optCel.Text = "Célibataire";
            this.optCel.UseVisualStyleBackColor = true;
            this.optCel.CheckedChanged += new System.EventHandler(this.optCel_CheckedChanged);
            // 
            // grpEnf
            // 
            this.grpEnf.Controls.Add(this.nbrenf);
            this.grpEnf.Controls.Add(this.label5);
            this.grpEnf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpEnf.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grpEnf.Location = new System.Drawing.Point(28, 322);
            this.grpEnf.Name = "grpEnf";
            this.grpEnf.Size = new System.Drawing.Size(355, 74);
            this.grpEnf.TabIndex = 9;
            this.grpEnf.TabStop = false;
            this.grpEnf.Text = "Enfants";
            // 
            // nbrenf
            // 
            this.nbrenf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nbrenf.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nbrenf.Location = new System.Drawing.Point(165, 29);
            this.nbrenf.Name = "nbrenf";
            this.nbrenf.Size = new System.Drawing.Size(156, 26);
            this.nbrenf.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(17, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre D\'enfants";
            // 
            // cmdValider
            // 
            this.cmdValider.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmdValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdValider.Location = new System.Drawing.Point(448, 128);
            this.cmdValider.Name = "cmdValider";
            this.cmdValider.Size = new System.Drawing.Size(95, 29);
            this.cmdValider.TabIndex = 10;
            this.cmdValider.Text = "Valider";
            this.cmdValider.UseVisualStyleBackColor = false;
            this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
            // 
            // cmdInitialiser
            // 
            this.cmdInitialiser.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmdInitialiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdInitialiser.Location = new System.Drawing.Point(448, 163);
            this.cmdInitialiser.Name = "cmdInitialiser";
            this.cmdInitialiser.Size = new System.Drawing.Size(95, 29);
            this.cmdInitialiser.TabIndex = 11;
            this.cmdInitialiser.Text = "Initialiser";
            this.cmdInitialiser.UseVisualStyleBackColor = false;
            this.cmdInitialiser.Click += new System.EventHandler(this.cmdInitialiser_Click);
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmdQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdQuitter.Location = new System.Drawing.Point(448, 198);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(95, 29);
            this.cmdQuitter.TabIndex = 12;
            this.cmdQuitter.Text = "Quitter";
            this.cmdQuitter.UseVisualStyleBackColor = false;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // datn
            // 
            this.datn.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.datn.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.datn.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText;
            this.datn.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.datn.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.datn.Location = new System.Drawing.Point(196, 107);
            this.datn.Name = "datn";
            this.datn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datn.Size = new System.Drawing.Size(216, 22);
            this.datn.TabIndex = 13;
            this.datn.ValueChanged += new System.EventHandler(this.datn_ValueChanged);
            // 
            // cmbSexe
            // 
            this.cmbSexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbSexe.FormattingEnabled = true;
            this.cmbSexe.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.cmbSexe.Location = new System.Drawing.Point(167, 138);
            this.cmbSexe.Name = "cmbSexe";
            this.cmbSexe.Size = new System.Drawing.Size(216, 28);
            this.cmbSexe.TabIndex = 14;
            this.cmbSexe.SelectedIndexChanged += new System.EventHandler(this.cmbSexe_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 420);
            this.Controls.Add(this.cmbSexe);
            this.Controls.Add(this.datn);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.cmdInitialiser);
            this.Controls.Add(this.cmdValider);
            this.Controls.Add(this.grpEnf);
            this.Controls.Add(this.grpSitFam);
            this.Controls.Add(this.txtPen);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Informations Personnelles";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpSitFam.ResumeLayout(false);
            this.grpSitFam.PerformLayout();
            this.grpEnf.ResumeLayout(false);
            this.grpEnf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbrenf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cmbSexe_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void datn_ValueChanged(object sender, EventArgs e)
        {
         
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
         
        }

        private void txtPen_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
           
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPen;
        private System.Windows.Forms.GroupBox grpSitFam;
        private System.Windows.Forms.RadioButton optDiv;
        private System.Windows.Forms.RadioButton optMar;
        private System.Windows.Forms.RadioButton optCel;
        private System.Windows.Forms.GroupBox grpEnf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdValider;
        private System.Windows.Forms.Button cmdInitialiser;
        private System.Windows.Forms.Button cmdQuitter;
        private System.Windows.Forms.NumericUpDown nbrenf;
        private System.Windows.Forms.DateTimePicker datn;
        private System.Windows.Forms.ComboBox cmbSexe;
    }

   
   
}