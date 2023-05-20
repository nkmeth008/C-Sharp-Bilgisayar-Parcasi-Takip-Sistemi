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
    public partial class kullanici_Admin : Form
    {
        OleDbConnection kullanici_dataBase = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Kullanicilar.accdb");
        OleDbDataAdapter kullanici_adapter;
        DataSet veri_Set;
        OleDbCommand kullanici_command;
        OleDbDataReader kullanici_reader;
        public kullanici_Admin()
        {
            InitializeComponent();
        }
        void kullanici_Listele()
        {
            kullanici_adapter = new OleDbDataAdapter("Select * from kimlik", kullanici_dataBase);
            veri_Set = new DataSet();
            kullanici_dataBase.Open();
            kullanici_adapter.Fill(veri_Set, "kimlik");
            dataGridView1.DataSource = veri_Set.Tables["kimlik"];
            kullanici_dataBase.Close();
        }
        private void kullanici_Admin_Load(object sender, EventArgs e)
        {
            kullanici_Listele();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }

        private void perplexButton1_Click(object sender, EventArgs e)
        {
            kullanici_command = new OleDbCommand();
            kullanici_dataBase.Open();
            kullanici_command.Connection = kullanici_dataBase;
            kullanici_command.CommandText = "Insert into kimlik (TeCe, Ad, Soyad, Dogum_Tarihi, ID, Sifre) values (" + "'" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Value + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            kullanici_command.ExecuteNonQuery();

            kullanici_dataBase.Close();
            kullanici_Listele();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            
        }

        private void perplexButton2_Click(object sender, EventArgs e)
        {
            kullanici_command = new OleDbCommand();
            kullanici_dataBase.Open();
            kullanici_command.Connection = kullanici_dataBase;
            kullanici_command.CommandText = "Update kimlik Set TeCe='" + textBox1.Text + "',Ad='" + textBox2.Text + "',Soyad='" + textBox3.Text + "',Dogum_Tarihi='" + dateTimePicker1.Value + "',ID='" + textBox4.Text + "',Sifre='" + textBox5.Text + "' where TeCe='" + textBox1.Text + "'";
            kullanici_command.ExecuteNonQuery();

            kullanici_dataBase.Close();
            kullanici_Listele();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void perplexButton3_Click(object sender, EventArgs e)
        {
            kullanici_command = new OleDbCommand();
            kullanici_dataBase.Open();
            kullanici_command.Connection = kullanici_dataBase;
            kullanici_command.CommandText = "Delete from kimlik where TeCe='" + textBox1.Text + "'";
            kullanici_command.ExecuteNonQuery();

            kullanici_dataBase.Close();
            kullanici_Listele();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void perplexLabel1_Click(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            
        }

        private void perplexButton4_Click(object sender, EventArgs e)
        {
            parca_Admin parca_Admin = new parca_Admin();
            parca_Admin.Show();
            this.Close();
        }
    }
}
