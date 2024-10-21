namespace Atelier_1_Exercice_1
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
            this.txtOp1 = new System.Windows.Forms.TextBox();
            this.txtOp2 = new System.Windows.Forms.TextBox();
            this.grpOp = new System.Windows.Forms.GroupBox();
            this.l = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExpression = new System.Windows.Forms.TextBox();
            this.txtResultat = new System.Windows.Forms.TextBox();
            this.cmdInitialiser = new System.Windows.Forms.Button();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.rbtnAdd = new System.Windows.Forms.RadioButton();
            this.rbtnSub = new System.Windows.Forms.RadioButton();
            this.rbtnMul = new System.Windows.Forms.RadioButton();
            this.rbtnDiv = new System.Windows.Forms.RadioButton();
            this.rbtnMod = new System.Windows.Forms.RadioButton();
            this.btnCalcul = new System.Windows.Forms.Button();
            this.grpOp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(17, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opérande 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(17, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opérande 2";
            // 
            // txtOp1
            // 
            this.txtOp1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOp1.Location = new System.Drawing.Point(21, 103);
            this.txtOp1.Name = "txtOp1";
            this.txtOp1.Size = new System.Drawing.Size(100, 22);
            this.txtOp1.TabIndex = 2;
            // 
            // txtOp2
            // 
            this.txtOp2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOp2.Location = new System.Drawing.Point(21, 183);
            this.txtOp2.Name = "txtOp2";
            this.txtOp2.Size = new System.Drawing.Size(100, 22);
            this.txtOp2.TabIndex = 3;
            // 
            // grpOp
            // 
            this.grpOp.BackColor = System.Drawing.SystemColors.Control;
            this.grpOp.Controls.Add(this.rbtnMod);
            this.grpOp.Controls.Add(this.rbtnDiv);
            this.grpOp.Controls.Add(this.rbtnMul);
            this.grpOp.Controls.Add(this.rbtnSub);
            this.grpOp.Controls.Add(this.rbtnAdd);
            this.grpOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpOp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grpOp.Location = new System.Drawing.Point(224, 21);
            this.grpOp.Name = "grpOp";
            this.grpOp.Size = new System.Drawing.Size(200, 248);
            this.grpOp.TabIndex = 4;
            this.grpOp.TabStop = false;
            this.grpOp.Text = "Opérateur";
            this.grpOp.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(21, 300);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(0, 16);
            this.l.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(27, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Expression ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(37, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Résultat";
            // 
            // txtExpression
            // 
            this.txtExpression.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExpression.Location = new System.Drawing.Point(136, 279);
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.Size = new System.Drawing.Size(235, 22);
            this.txtExpression.TabIndex = 8;
            // 
            // txtResultat
            // 
            this.txtResultat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultat.Location = new System.Drawing.Point(136, 319);
            this.txtResultat.Name = "txtResultat";
            this.txtResultat.Size = new System.Drawing.Size(235, 22);
            this.txtResultat.TabIndex = 9;
            // 
            // cmdInitialiser
            // 
            this.cmdInitialiser.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmdInitialiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmdInitialiser.Location = new System.Drawing.Point(12, 378);
            this.cmdInitialiser.Name = "cmdInitialiser";
            this.cmdInitialiser.Size = new System.Drawing.Size(123, 36);
            this.cmdInitialiser.TabIndex = 10;
            this.cmdInitialiser.Text = "Initialiser";
            this.cmdInitialiser.UseVisualStyleBackColor = false;
            this.cmdInitialiser.Click += new System.EventHandler(this.cmdInitialiser_Click);
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmdQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmdQuitter.Location = new System.Drawing.Point(141, 379);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(123, 36);
            this.cmdQuitter.TabIndex = 11;
            this.cmdQuitter.Text = "Quitter";
            this.cmdQuitter.UseVisualStyleBackColor = false;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // rbtnAdd
            // 
            this.rbtnAdd.AutoSize = true;
            this.rbtnAdd.Location = new System.Drawing.Point(19, 43);
            this.rbtnAdd.Name = "rbtnAdd";
            this.rbtnAdd.Size = new System.Drawing.Size(45, 29);
            this.rbtnAdd.TabIndex = 5;
            this.rbtnAdd.TabStop = true;
            this.rbtnAdd.Text = "+";
            this.rbtnAdd.UseVisualStyleBackColor = true;
            // 
            // rbtnSub
            // 
            this.rbtnSub.AutoSize = true;
            this.rbtnSub.Location = new System.Drawing.Point(19, 83);
            this.rbtnSub.Name = "rbtnSub";
            this.rbtnSub.Size = new System.Drawing.Size(40, 29);
            this.rbtnSub.TabIndex = 6;
            this.rbtnSub.TabStop = true;
            this.rbtnSub.Text = "-";
            this.rbtnSub.UseVisualStyleBackColor = true;
            // 
            // rbtnMul
            // 
            this.rbtnMul.AutoSize = true;
            this.rbtnMul.Location = new System.Drawing.Point(19, 119);
            this.rbtnMul.Name = "rbtnMul";
            this.rbtnMul.Size = new System.Drawing.Size(41, 29);
            this.rbtnMul.TabIndex = 7;
            this.rbtnMul.TabStop = true;
            this.rbtnMul.Text = "*";
            this.rbtnMul.UseVisualStyleBackColor = true;
            // 
            // rbtnDiv
            // 
            this.rbtnDiv.AutoSize = true;
            this.rbtnDiv.Location = new System.Drawing.Point(19, 155);
            this.rbtnDiv.Name = "rbtnDiv";
            this.rbtnDiv.Size = new System.Drawing.Size(39, 29);
            this.rbtnDiv.TabIndex = 8;
            this.rbtnDiv.TabStop = true;
            this.rbtnDiv.Text = "/";
            this.rbtnDiv.UseVisualStyleBackColor = true;
            // 
            // rbtnMod
            // 
            this.rbtnMod.AutoSize = true;
            this.rbtnMod.Location = new System.Drawing.Point(19, 191);
            this.rbtnMod.Name = "rbtnMod";
            this.rbtnMod.Size = new System.Drawing.Size(51, 29);
            this.rbtnMod.TabIndex = 9;
            this.rbtnMod.TabStop = true;
            this.rbtnMod.Text = "%";
            this.rbtnMod.UseVisualStyleBackColor = true;
            // 
            // btnCalcul
            // 
            this.btnCalcul.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCalcul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCalcul.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcul.Location = new System.Drawing.Point(270, 379);
            this.btnCalcul.Name = "btnCalcul";
            this.btnCalcul.Size = new System.Drawing.Size(116, 36);
            this.btnCalcul.TabIndex = 12;
            this.btnCalcul.Text = "Calculer";
            this.btnCalcul.UseVisualStyleBackColor = false;
            this.btnCalcul.Click += new System.EventHandler(this.btnCalcul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 450);
            this.Controls.Add(this.btnCalcul);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.cmdInitialiser);
            this.Controls.Add(this.txtResultat);
            this.Controls.Add(this.txtExpression);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.l);
            this.Controls.Add(this.grpOp);
            this.Controls.Add(this.txtOp2);
            this.Controls.Add(this.txtOp1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpOp.ResumeLayout(false);
            this.grpOp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOp1;
        private System.Windows.Forms.TextBox txtOp2;
        private System.Windows.Forms.GroupBox grpOp;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExpression;
        private System.Windows.Forms.TextBox txtResultat;
        private System.Windows.Forms.Button cmdInitialiser;
        private System.Windows.Forms.Button cmdQuitter;
        private System.Windows.Forms.RadioButton rbtnMul;
        private System.Windows.Forms.RadioButton rbtnSub;
        private System.Windows.Forms.RadioButton rbtnAdd;
        private System.Windows.Forms.RadioButton rbtnDiv;
        private System.Windows.Forms.RadioButton rbtnMod;
        private System.Windows.Forms.Button btnCalcul;
    }
}

