﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace bilgisayar_TakipSistemi
{
    public partial class uye_Olma : Form
    {
        OleDbConnection kullanici_dataBase = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Kullanicilar.accdb");
        OleDbDataAdapter kullanici_adapter;
        DataSet veri_Set;
        OleDbCommand kullanici_command;
        OleDbDataReader kullanici_reader;
        public uye_Olma()
        {
            InitializeComponent();
        }

        private void uye_Olma_Load(object sender, EventArgs e)
        {

        }

        private void perplexButton1_Click(object sender, EventArgs e)
        {
            kullanici_command = new OleDbCommand();
            kullanici_dataBase.Open();
            kullanici_command.Connection = kullanici_dataBase;
            kullanici_command.CommandText = "Insert into kimlik (TeCe, Ad, Soyad, Dogum_Tarihi, ID, Sifre) values (" + "'" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Value + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            kullanici_command.ExecuteNonQuery();

            kullanici_dataBase.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            MessageBox.Show("Üye Olma Başarılı. Giriş Ekranına Yönlendiriliyorsunuz.");
            
            giris giris = new giris();
            giris.Show();
            this.Hide();

        }
    }
}
