using System;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Windows.Forms;

namespace Atelier1_exerice2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeControls(); // Moved initialization logic to a separate method
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void InitializeControls()
        {
           
        }

        private void InitializeComboBox()
        {
            cmbSexe.Items.Add("Homme");
            cmbSexe.Items.Add("Femme");
        }

        private void cmdValider_Click(object sender, EventArgs e)
        {
            TimeSpan age = DateTime.Now - datn.Value;
            if (string.IsNullOrEmpty(txtNom.Text) || string.IsNullOrEmpty(txtPen.Text))
            {
                MessageBox.Show("Erreur, veuillez entrer un nom et un prénom.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (optCel.Checked)
                {
                    MessageBox.Show("Vous êtes :" + txtNom.Text + " " + txtPen.Text + "\n" + "\n" + "sexe :" + cmbSexe.Text + "\n" + "\n" + "Vous avez : " + ((age.Days) / 356).ToString() + " ans " + "\n Vous êtes : Celebataire ");
                }
                else if (optMar.Checked)
                {
                    MessageBox.Show("Vous êtes :" + txtNom.Text + " " + txtPen.Text + "\n" + "\n" + "sexe :" + cmbSexe.Text + "\n" + "\n" + "Vous avez : " + ((age.Days) / 356).ToString() + " ans " + "\n  Vous avez  :  " + nbrenf.Value + " enfant(s)" + "\n Vous êtes : Marié(e) ");
                }
                else if (optDiv.Checked)
                {
                    MessageBox.Show("Vous êtes :" + txtNom.Text + " " + txtPen.Text + "\n" + "\n" + "sexe :" + cmbSexe.Text + "\n" + "\n" + "\n Vous avez : " + ((age.Days) / 356).ToString() + " ans " + "\n  Vous avez  :  " + nbrenf.Value + " enfant(s)" + "\n Vous êtes : Divorsé(e) ");

                }
            }
            }
            

        private void cmdInitialiser_Click(object sender, EventArgs e)
        {
            txtNom.Clear();
            txtPen.Clear();
            datn.Value = DateTime.Now;
            optCel.Checked = false;
            optMar.Checked = false;
            optDiv.Checked = false;
            nbrenf.Value = 0;
            cmbSexe.SelectedIndex = -1;
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grpSitFam_CheckedChanged(object sender, EventArgs e)
        {
            grpEnf.Visible = !optCel.Checked; // Show/hide the group based on marital status
        }

        private void optMar_CheckedChanged(object sender, EventArgs e)
        {
            grpEnf.Visible = true;
        }

        private void optCel_CheckedChanged(object sender, EventArgs e)
        {
            grpEnf.Visible = false;
        }

        private void optDiv_CheckedChanged(object sender, EventArgs e)
        {
            grpEnf.Visible = true;
        }
    }
}
