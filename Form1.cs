using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        private List<string> kitaplar = new List<string>() { "Suç ve Ceza" };
        

        public Form1()
        {
            InitializeComponent();
            this.Text = "Kütüphane Uygulaması";

            ListeGuncelle();
            // Label
            label1.Text = "Yapmak istediğiniz işlem için butona basınız";
            label1.Location = new System.Drawing.Point(50, 20);
            label1.Size = new System.Drawing.Size(300, 20);
            // TextBox1 - Kitap İsmi
            textBox1.Text = "Kitap İsmi";
            textBox1.Location = new System.Drawing.Point(50, 50);
            textBox1.Size = new System.Drawing.Size(200, 25);
            // TextBox2 - Kişi İsmi
            textBox2.Text = "İsim";
            textBox2.Location = new System.Drawing.Point(260, 50);
            textBox2.Size = new System.Drawing.Size(150, 25);
            // Button1 - Almak
            button1.Text = "Almak";
            button1.Location = new System.Drawing.Point(50, 90);
            button1.Size = new System.Drawing.Size(80, 30);
            // Button2 - Vermek
            button2.Text = "Vermek";
            button2.Location = new System.Drawing.Point(140, 90);
            button2.Size = new System.Drawing.Size(80, 30);
            // Button3 - Kayıt Ettirmek
            button3.Text = "Kayıt Ettirmek";
            button3.Location = new System.Drawing.Point(230, 90);
            button3.Size = new System.Drawing.Size(120, 30);
            // ListBox - Kitap Listesi
            lstKitaplar.Location = new System.Drawing.Point(50, 140);
            lstKitaplar.Size = new System.Drawing.Size(360, 200);
            
        }

        // ListeBox güncelleme fonksiyonu
        private void ListeGuncelle()
        {
            lstKitaplar.Items.Clear();
            foreach (string kitap in kitaplar)
            {
                lstKitaplar.Items.Add(kitap);
            }
        }

        //Kitap Alma Fonksiyonu
        private void button1_Click(object sender, EventArgs e)
        {
            string AlınanKitap=textBox1.Text;
            string İsim=textBox2.Text;
            for (int i = 0; i <kitaplar.Count;i++)
            {
                if (kitaplar[i]==AlınanKitap)
                {
                    kitaplar[i]=AlınanKitap+" Alan: "+İsim;
                    ListeGuncelle();
                    MessageBox.Show("İşleminiz Başarılı Bir Şekilde Tamamalanmıştır");
                    return;
                }
                else
                {
                    MessageBox.Show("Bulunamadı");
                }
            }
        }

        //Kitap Vermek Fonksiyonu
        private void button2_Click(object sender, EventArgs e)
        {
            string Verilen=textBox1.Text;
            string İsim = textBox2.Text;
            for (int i = 0;i<kitaplar.Count;i++)
            {
                if(kitaplar[i].Contains(Verilen))
                {
                    kitaplar[i] = Verilen;
                    ListeGuncelle();
                    MessageBox.Show("İşleminiz Başarılı Bir Şekilde Tamamlanmıştır");
                    return;
                }
            }
        }

        //Kitap Kayıt Ettirme
        private void button3_Click(object sender, EventArgs e)
        {
            string yenikitap=textBox1.Text;
            if(!string.IsNullOrEmpty(yenikitap))
            {
                kitaplar.Add(yenikitap);
                ListeGuncelle();
                MessageBox.Show(yenikitap + " Başarılı bir şekilde kaydedilmiştir");
            }

        }
    }


}
