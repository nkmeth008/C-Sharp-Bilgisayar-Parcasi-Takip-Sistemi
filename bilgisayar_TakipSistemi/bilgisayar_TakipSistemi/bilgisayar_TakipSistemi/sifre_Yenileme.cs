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

namespace bilgisayar_TakipSistemi
{
    public partial class sifre_Yenileme : Form
    {
        OleDbConnection kullanici_dataBase = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Kullanicilar.accdb");
        OleDbDataAdapter kullanici_adapter;
        DataSet veri_Set;
        OleDbCommand kullanici_command;
        OleDbDataReader kullanici_reader;
        public sifre_Yenileme()
        {
            InitializeComponent();
        }

        private void sifre_Yenileme_Load(object sender, EventArgs e)
        { 

        }

        private void perplexButton1_Click(object sender, EventArgs e)
        {
            kullanici_command = new OleDbCommand();
            kullanici_dataBase.Open();
            kullanici_command.Connection = kullanici_dataBase;
            kullanici_command.CommandText = "Update kimlik Set ID='" + textBox1.Text + "',Sifre='" + textBox2.Text + "' where ID='" + textBox1.Text + "'";
            kullanici_command.ExecuteNonQuery();

            kullanici_dataBase.Close();

            giris giris1 = new giris();
            giris1.Show();
            this.Hide();
        }
    }
}
