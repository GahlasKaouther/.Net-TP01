using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelier_1_Exercice_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOp1.Text == "" || txtOp2.Text == "")
                    MessageBox.Show("Attention zone de texte vide");
                else
                {
                    Double op1 = Convert.ToDouble(txtOp1.Text);
                    Double op2 = Convert.ToDouble(txtOp2.Text);
                    Double res = op1 + op2;
                    txtResultat.Text = res.ToString();
                    txtExpression.Text = txtOp1.Text + "+" + txtOp2.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Sub_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOp1.Text == "" || txtOp2.Text == "")
                    MessageBox.Show("Attention zone de texte vide");
                else
                {
                    Double op1 = Convert.ToDouble(txtOp1.Text);
                    Double op2 = Convert.ToDouble(txtOp2.Text);
                    Double res = op1 - op2;
                    txtResultat.Text = res.ToString();
                    txtExpression.Text = txtOp1.Text + "-" + txtOp2.Text;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Mul_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtOp1.Text))
                    MessageBox.Show("Attention zone de texte vide");
                else
                {
                    Double op1 = Convert.ToDouble(txtOp1.Text);
                    Double op2 = Convert.ToDouble(txtOp2.Text);
                    Double res = op1 * op2;
                    txtResultat.Text = res.ToString();
                    txtExpression.Text = txtOp1.Text + "*" + txtOp2.Text;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Div_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOp1.Text == "" || txtOp2.Text == "")
                    MessageBox.Show("Attention zone de texte vide");
                else
                {
                    Double op1 = Convert.ToDouble(txtOp1.Text);
                    Double op2 = Convert.ToDouble(txtOp2.Text);

                    if (op2 == 0)
                    {
                        MessageBox.Show("Erreur : Division par zéro !");
                    }
                    else
                    {
                        Double res = op1 / op2;
                        txtResultat.Text = res.ToString();
                        txtExpression.Text = txtOp1.Text + "/" + txtOp2.Text;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Mod_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOp1.Text == "" || txtOp2.Text == "")
                    MessageBox.Show("Attention zone de texte vide");
                else
                {
                    Double op1 = Convert.ToDouble(txtOp1.Text);
                    Double op2 = Convert.ToDouble(txtOp2.Text);

                    if (op2 == 0)
                    {
                        MessageBox.Show("Erreur : Reste de division par zéro !");
                    }
                    else
                    {
                        Double res = op1 % op2;
                        txtResultat.Text = res.ToString();
                        txtExpression.Text = txtOp1.Text + "%" + txtOp2.Text;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmdInitialiser_Click(object sender, EventArgs e)
        {
            txtOp1.Clear();
            txtOp2.Clear();
            txtExpression.Clear();
            txtResultat.Clear();
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcul_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtOp1.Text) || string.IsNullOrWhiteSpace(txtOp2.Text))
                {
                    MessageBox.Show("Veuillez entrer des valeurs dans les deux opérandes.", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double op1 = Convert.ToDouble(txtOp1.Text);
                double op2 = Convert.ToDouble(txtOp2.Text);
                double result = 0;
                string selectedOperator = "";

                if (rbtnAdd.Checked)
                {
                    selectedOperator = "+";
                    result = op1 + op2;
                }
                else if (rbtnSub.Checked)
                {
                    selectedOperator = "-";
                    result = op1 - op2;
                }
                else if (rbtnMul.Checked)
                {
                    selectedOperator = "*";
                    result = op1 * op2;
                }
                else if (rbtnDiv.Checked)
                {
                    selectedOperator = "/";
                    if (op2 == 0)
                    {
                        MessageBox.Show("Erreur : Division par zéro !");
                        return;
                    }
                    result = op1 / op2;
                }
                else if (rbtnMod.Checked)
                {
                    selectedOperator = "%";
                    if (op2 == 0)
                    {
                        MessageBox.Show("Erreur : Reste de division par zéro !");
                        return;
                    }
                    result = op1 % op2;
                }

                txtResultat.Text = result.ToString();
                txtExpression.Text = txtOp1.Text + " " + selectedOperator + " " + txtOp2.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}