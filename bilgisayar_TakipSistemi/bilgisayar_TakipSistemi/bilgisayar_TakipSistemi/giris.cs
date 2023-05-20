using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;

namespace bilgisayar_TakipSistemi
{
    public partial class giris : Form
    {
        
        public giris()
        {
            
            InitializeComponent();
        }
       
        private void giris_Load(object sender, EventArgs e)
        {

        }

        private void perplexLabel1_Click(object sender, EventArgs e)
        {

        }

        private void giris_Click(object sender, EventArgs e)
        {
            OleDbConnection kullanici_dataBase = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Kullanicilar.accdb");
            kullanici_dataBase.Open();
            OleDbCommand kullanici_command = new OleDbCommand("select * from kimlik where ID=@ID and Sifre=@Sifre", kullanici_dataBase);
            kullanici_command.Parameters.Add("ID", textBox1.Text);
            kullanici_command.Parameters.Add("Sifre", textBox2.Text);
            OleDbDataReader kullanici_Read = kullanici_command.ExecuteReader();
            if (kullanici_Read.Read())
            {
                uye_Parca uye_Parca = new uye_Parca();
                uye_Parca.Show();
                this.Hide();
            }
            
            else if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                parca_Admin parca_Admin = new parca_Admin();
                parca_Admin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı");
            }
        }


        private void perplexControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sifre_Yenileme sifre_Yenileme1 = new sifre_Yenileme();
            sifre_Yenileme1.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            uye_Olma uye_Olma1 = new uye_Olma();    
            uye_Olma1.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Admin Girişi İçin ID = 'admin' Şifre 'admin' ");
        }
    }
}
