namespace HospitalAutomation.GUI
{
    partial class OgretimUyesi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtOgretimUye = new System.Windows.Forms.TextBox();
            this.lbOgretimUyesi = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOgretimUyesi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOgretimUye
            // 
            this.txtOgretimUye.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtOgretimUye.Location = new System.Drawing.Point(0, 0);
            this.txtOgretimUye.Name = "txtOgretimUye";
            this.txtOgretimUye.Size = new System.Drawing.Size(292, 20);
            this.txtOgretimUye.TabIndex = 0;
            this.txtOgretimUye.TextChanged += new System.EventHandler(this.txtOgretimUye_TextChanged);
            this.txtOgretimUye.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOgretimUye_KeyPress);
            // 
            // lbOgretimUyesi
            // 
            this.lbOgretimUyesi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbOgretimUyesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOgretimUyesi.FormattingEnabled = true;
            this.lbOgretimUyesi.ItemHeight = 16;
            this.lbOgretimUyesi.Location = new System.Drawing.Point(0, 53);
            this.lbOgretimUyesi.Name = "lbOgretimUyesi";
            this.lbOgretimUyesi.Size = new System.Drawing.Size(292, 164);
            this.lbOgretimUyesi.TabIndex = 1;
            this.lbOgretimUyesi.SelectedIndexChanged += new System.EventHandler(this.lbOgretimUyesi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seçilen Öğr. Üyesi :";
            // 
            // lblOgretimUyesi
            // 
            this.lblOgretimUyesi.AutoSize = true;
            this.lblOgretimUyesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOgretimUyesi.Location = new System.Drawing.Point(136, 25);
            this.lblOgretimUyesi.Name = "lblOgretimUyesi";
            this.lblOgretimUyesi.Size = new System.Drawing.Size(0, 17);
            this.lblOgretimUyesi.TabIndex = 3;
            // 
            // OgretimUyesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 217);
            this.Controls.Add(this.lblOgretimUyesi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbOgretimUyesi);
            this.Controls.Add(this.txtOgretimUye);
            this.Name = "OgretimUyesi";
            this.Text = "Öğretim Üyesi Seçiniz ";
            this.Load += new System.EventHandler(this.OgretimUyesi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOgretimUye;
        private System.Windows.Forms.ListBox lbOgretimUyesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOgretimUyesi;
    }
}