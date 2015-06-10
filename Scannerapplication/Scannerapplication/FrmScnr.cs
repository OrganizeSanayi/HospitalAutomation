using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WIATest;

namespace Scannerapplication
{
    public partial class FrmScnr : Form
    {
        public static int taramaBittimi = 0;
        Image image1;
        public static string sillinecekDosya;
        int sayac=0;

        public FrmScnr()
        {
            InitializeComponent();
        }
        //button click event
        private void btn_scan_Click(object sender, EventArgs e)
        {
            try
            {
                //get list of devices available
                List<string> devices = WIAScanner.GetDevices();

                foreach (string device in devices)
                {
                    lbDevices.Items.Add(device);
                }
                //check if device is not available
                if (lbDevices.Items.Count == 0)
                {
                    MessageBox.Show("WIA aracı bulunamadı");
                    this.Close();
                }
                else
                {
                    lbDevices.SelectedIndex = 0;
                }
                //tarayıcı trafından resimi alma
                List<Image> images = WIAScanner.Scan((string)lbDevices.SelectedItem);
                foreach (Image image in images)
                {
                    pic_scan.Image = image;
                    image1 = image;
                    pic_scan.Show();
                    pic_scan.SizeMode = PictureBoxSizeMode.StretchImage;
                    //resmi d deki dizine kaydetme
                   // image.Save(@"C:\Users\Halil\Desktop\Scannerapplication\Scannerapplication\TarananDosyalar" + DateTime.Now.ToString("yyyy-MM-dd HHmmss") + ".jpeg", ImageFormat.Jpeg);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            btnKaydet.Visible = true;
           // btnSil.Visible = true;
            //btnYenidenTara.Visible = true;
        }


        private void Home_SizeChanged(object sender, EventArgs e)
        {
            int pheight = this.Size.Height - 153;
            pic_scan.Size = new Size(pheight - 150, pheight);
        }

        private void pnl_capture_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            btnTaramayiBitir.Visible = true;
            string temp="D://" + DateTime.Now.ToString("yyyy-MM-dd HHmmss") + ".jpeg";
            image1.Save(temp, ImageFormat.Jpeg);
            sillinecekDosya = temp;
            sayac++;
            btnSil.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnKaydet.Visible = false;
            btnSil.Visible = false;
            btnTaramayiBitir.Visible = false;
            //btnYenidenTara.Visible = false;
        }

        private void FrmScnr_KeyPress(object sender, KeyEventArgs e)
        {
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            btnTaramayiBitir.Visible = true;
            File.Delete(sillinecekDosya);
            btnKaydet.Visible = false;
           // btnYenidenTara.Visible = false;
        }

        private void FrmScnr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt == true && e.KeyCode == Keys.A) // ALT + A Tuşuna basıldığında 
            {
                btn_scan.PerformClick(); //btnscana e kod yardımıyla tıklamış oluyoruz.
            }
            if (e.Alt == true && e.KeyCode == Keys.S) // ALT + S Tuşuna basıldığında
            {
                btnKaydet.PerformClick();
            }
            if (e.Alt == true && e.KeyCode == Keys.D) // ALT + D Tuşuna basıldığında
            {
                btnSil.PerformClick();
            }
            //if (e.Alt == true && e.KeyCode == Keys.F) // ALT + F Tuşuna basıldığında
            //{
            // //   btnYenidenTara.PerformClick();
            //}
        }

        private void btnTaramayiBitir_Click(object sender, EventArgs e)
        {
            taramaBittimi = 1;
            this.Hide();

        }

       

    }
}
