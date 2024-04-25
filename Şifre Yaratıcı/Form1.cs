using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Şifre_Yaratıcı
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;

            if (swTema.Checked == true)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }
            else
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            }
        }

        private void btnolustur_Click(object sender, EventArgs e)
        {
            if(sifreuzunlugu.Value == 0)
            {
                MessageBox.Show("Lütfen şifre oluşturmak için karakter ve bir uzunluk giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(cbBuyuk.Checked == false && cbKucuk.Checked == false && cbOzel.Checked == false && cbSayi.Checked == false) 
            {
                MessageBox.Show("Lütfen seçeneklerden en az birini seçiniz." , "Uyarı" , MessageBoxButtons.OK , MessageBoxIcon.Warning);
                return;
            }

            string buyukharf = "QWERTYUIOPĞÜASDFGHJKLŞİZXCVBNMÖÇ";
            string kucukharf = "qwertyuıopğüasdfghjklşizxcvbnmöç";
            string ozelkarakter = "!'^+%&/()=?_>£#$½{[]}|";
            string sayi = "1234567890";
            string sifre = " ";
            if(cbBuyuk.Checked == true) { sifre += buyukharf;}
            if(cbKucuk.Checked == true) { sifre += kucukharf;}
            if(cbOzel.Checked == true) { sifre += ozelkarakter;}
            if(cbSayi.Checked == true) { sifre += sayi;}

            Random rnd = new Random();
            txtsifre.Text = string.Empty;
            for( int i = 0; i <sifreuzunlugu.Value; i++ )
            {
                txtsifre.Text += sifre[rnd.Next(sifre.Length)];
            }
        }
    }
}
