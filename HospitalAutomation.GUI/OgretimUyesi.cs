using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HastaneArsiv;

namespace HospitalAutomation.GUI
{
    public partial class OgretimUyesi : Form
    {
        public OgretimUyesi()
        {
            InitializeComponent();
        }
        
        private void txtOgretimUye_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtOgretimUye.Text))
                {
                    lbOgretimUyesi.ClearSelected();
                    return;
                }

                bool fnd = false;
                for (int i = 0; i < lbOgretimUyesi.Items.Count; i++)
                {
                    if (lbOgretimUyesi.Items[i].ToString().ToLower().Contains(txtOgretimUye.Text.ToLower()))
                    {
                        lbOgretimUyesi.SelectedValue = i;
                        lbOgretimUyesi.SetSelected(i, true);
                        fnd = true;
                        return;
                    }
                    if (!fnd)
                        lbOgretimUyesi.ClearSelected();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            
        }

        private void txtOgretimUye_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (lbOgretimUyesi.SelectedItem != null)
                    {
                        ((MainForm)Application.OpenForms["MainForm"]).txtOgretimUyesi.Text = lbOgretimUyesi.SelectedItem.ToString();
                        this.Close();
                    }
                    else
                        this.Close();
                }
                if (e.KeyChar == (char)Keys.Escape)
                    this.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void lbOgretimUyesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lbOgretimUyesi.SelectedItem != null)
                lblOgretimUyesi.Text = lbOgretimUyesi.SelectedItem.ToString();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void OgretimUyesi_Load(object sender, EventArgs e)
        {

        }
    }
}
