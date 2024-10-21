using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Atelier_1_ex3
{
    public partial class Form1 : Form
    {
        int total_eq1 = 0, total_eq2 = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Ajout_Click(object sender, EventArgs e)
        {
            if (cmb_np.SelectedItem == null || (!rdb_eq1.Checked && !rdb_eq2.Checked))
            {
                MessageBox.Show("Veuillez sélectionner une équipe et un nombre de points.");
                return;
            }

            string Operation = cmb_np.SelectedItem.ToString();

            if (rdb_eq1.Checked)
            {
                List_eq1.Items.Add( Operation);
               
            }
            else if (rdb_eq2.Checked)
            {
                List_eq2.Items.Add( Operation);

            }
        }

        private void cmb_np_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            cmb_np.Items.Add("Transformation : 2 points");
            cmb_np.Items.Add("Pénalité : 3 points");
            cmb_np.Items.Add("Drop : 3 points");
            cmb_np.Items.Add("Essai : 5 points");
        }

        private void Btn_RAZ_Click(object sender, EventArgs e)
        {
            txt_eq1.Clear();
            txt_eq2.Clear();
            rdb_eq1.Checked = false;
            rdb_eq2.Checked = false;
            List_eq1.Items.Clear();
            List_eq2.Items.Clear();
            cmb_np.SelectedItem = null;
        }

        private void Btn_Résultat_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < List_eq1.Items.Count; i++)
            {
                string item = List_eq1.Items[i].ToString();
                if (item == "Transformation : 2 points")
                {
                    total_eq1 += 2;
                }
                else if (item == "Pénalité : 3 points" || item == "Drop : 3 points")
                {
                    total_eq1 += 3;
                }
                else if (item == "Essai : 5 points")
                {
                    total_eq1 += 5;
                }
            }

            for (int i = 0; i < List_eq2.Items.Count; i++)
            {
                string item = List_eq2.Items[i].ToString();
                if (item == "Transformation : 2 points")
                {
                    total_eq2 += 2;
                }
                else if (item == "Pénalité : 3 points" || item == "Drop : 3 points")
                {
                    total_eq2 += 3;
                }
                else if (item == "Essai : 5 points")
                {
                    total_eq2 += 5;
                }
            }
            MessageBox.Show(txt_eq1.Text + " : " + total_eq1 + " points\n" + txt_eq2.Text + " : " + total_eq2 + " points");
        }
    }
}
