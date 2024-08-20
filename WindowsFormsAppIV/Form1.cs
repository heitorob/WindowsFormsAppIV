using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppIV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnINSERIR_Click(object sender, EventArgs e)
        {
            cmbLISTA.Items.Add(txtTEXTO.Text);

            lblQTDE.Text = cmbLISTA.Items.Count.ToString();

            txtTEXTO.Clear();

            txtTEXTO.Focus();
        }

        private void btnORDENAR_Click(object sender, EventArgs e)
        {
            cmbLISTA.Sorted = true;
        }

        private void btnREMOVER_Click(object sender, EventArgs e)
        {
            if (cmbLISTA.SelectedIndex != -1)
            {
                cmbLISTA.Items.RemoveAt(cmbLISTA.SelectedIndex);

                lblQTDE.Text = cmbLISTA.Items.Count.ToString();

                cmbLISTA.ResetText();
            }
        }

        private void btnEXIBIR_Click(object sender, EventArgs e)
        {
            if (cmbLISTA.SelectedIndex != -1)
            {
                txtCONTEUDO.Text = cmbLISTA.SelectedItem.ToString();
                txtINDICE.Text = cmbLISTA.SelectedIndex.ToString();
            }
        }
    }
}
