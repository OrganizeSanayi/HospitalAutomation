using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HastaneArsiv;
using HospitalAutomation.Services;
using HospitalAutomation.Util;

namespace HospitalAutomation.GUI
{
    public partial class Bolum : Form
    {
        public Bolum()
        {
            InitializeComponent();
        }

        private void txtBolum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var txt = (TextBox) sender;
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    lbBolum.ClearSelected();
                    return;
                }

                for (var i = 0; i < lbBolum.Items.Count; i++)
                {
                    if (!lbBolum.GetItemText(lbBolum.Items[i]).ToLower().Contains(txt.Text.ToLower())) continue;

                    lbBolum.SelectedValue = i;
                    lbBolum.SetSelected(i, true);
                    return;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void txtBolum_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (lbBolum.SelectedItem != null)
                    {
                        ((MainForm)Application.OpenForms["MainForm"]).txtBolum.Text = lbBolum.GetItemText(lbBolum.SelectedItem);
                        Close();
                    }
                    else
                        Close();
                }
                if (e.KeyChar == (char)Keys.Escape)
                    Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void Bolum_Load(object sender, EventArgs e)
        {
            Populater.Fill(lbBolum, DataFillingService.GatherSections);
        }

        private void lbBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lbBolum.SelectedItem != null)
                    lbBolum.Text = lbBolum.GetItemText(lbBolum.SelectedItem);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
