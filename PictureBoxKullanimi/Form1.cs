using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBoxKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double vize1, vize2, final,ortalama;
            vize1 = Convert.ToDouble(txt1vize.Text);
            vize2 = Convert.ToDouble(txt2vize.Text);
            final = Convert.ToDouble(txtfinal.Text);

            ortalama = (vize1 * 0.2) + (vize2 * 0.2) + (final * 0.4);
            if (ortalama>45.0 && ortalama<100.0)
            {
                rchOrtalama.Text = $"Tebrik ederiz! {ortalama} ortalama ile dersi geçtiniz. Başarılarınızın devamını dileriz.";
                picDurum.Image = Image.FromFile(@"C:\Users\Lenovo\Desktop\Python\%100burs.jpg");
                picDurum.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (ortalama<45.0)
            {
                rchOrtalama.Text = $"Üzgünüz {ortalama} ortalama ile dersden geçmek için gereken puanı alamadınız.";
                picDurum.Image = Image.FromFile(@"C:\Users\Lenovo\Desktop\Python\Kaldı.jpg");
                picDurum.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
