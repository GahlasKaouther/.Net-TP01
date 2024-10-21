using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelier1_ex4
{
    public partial class Btn_Reset : Form
    {
        public Btn_Reset()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Vous pouvez laisser cet événement vide si vous n'avez rien à y ajouter.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lst_Mat.Items.Add(Txt_Mat.Text);


            string employeInfo = Txt_NP.Text + "    " + Cmb_Situation.SelectedItem + "    " + "      "+ Cmb_Fonction.SelectedItem;
            Lst_Emp.Items.Add(employeInfo);

            double salaireBase = double.Parse(Txt_Sal.Text);
            double prime_Transport = 30;
            double prime_Production = 0;

            switch (Cmb_Fonction.Text)
            {
                case "Administrative":
                    prime_Production = salaireBase * 0.05;
                    break;
                case "Commerciale":
                    prime_Production = salaireBase * 0.08;
                    break;
                case "Comptable":
                    prime_Production = salaireBase * 0.10;
                    break;
                case "Financière":
                    prime_Production = salaireBase * 0.15;
                    break;
            }

            double salaireNet = salaireBase + prime_Transport + prime_Production;

            Lst_Sal.Items.Add(salaireNet);

            double totalSalaires = Lst_Sal.Items.OfType<double>().Sum();
            Lbl_Total_Sal.Text = totalSalaires.ToString();

            int nombreEmployes = Lst_Sal.Items.Count;
            Lbl_Nb_Emp.Text = nombreEmployes.ToString();

            double salaireMoyen = totalSalaires / nombreEmployes;
            Lbl_Moyenne_Sal.Text = salaireMoyen.ToString();

        }

        private void Cmb_Situation_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cmb_Situation.Items.Add("Marié");
            Cmb_Situation.Items.Add("Célibataire");
            Cmb_Situation.Items.Add("Divorcé");

            Cmb_Fonction.Items.Add("Administrative");
            Cmb_Fonction.Items.Add("Commerciale");
            Cmb_Fonction.Items.Add("Comptable");
            Cmb_Fonction.Items.Add("Financière");

        }

        private void Btn_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Txt_Mat_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lst_Emp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Txt_NP.Clear();
            Txt_Sal.Clear();
            Lbl_Nb_Emp.Clear();
            Txt_Mat.Clear();
            Lbl_Total_Sal.Clear();
            Lbl_Moyenne_Sal.Clear();
            Cmb_Situation.SelectedIndex = -1;
            Cmb_Fonction.SelectedIndex = -1;
            Chk_Transport.Checked = false;
            Chk_Prod.Checked = false;
            Lst_Sal.Items.Clear();
            Lst_Mat.Items.Clear();
            Lst_Emp.Items.Clear();
            Opt_Mas.Checked = false;
            Opt_Fem.Checked = false;


        }

        private void Chk_Transport_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Opt_Mas_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
