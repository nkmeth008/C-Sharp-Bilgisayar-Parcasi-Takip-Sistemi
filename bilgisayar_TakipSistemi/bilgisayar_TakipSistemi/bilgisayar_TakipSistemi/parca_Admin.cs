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
    public partial class parca_Admin : Form
    {
        OleDbConnection parca_dataBase = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Kullanicilar.accdb");
        OleDbDataAdapter parca_adapter;
        DataSet parca_Set;
        OleDbCommand parca_command;
        OleDbDataReader parca_reader;
        public parca_Admin()
        {
            InitializeComponent();
        }
        void parca_Listele()
        {
            parca_adapter = new OleDbDataAdapter("Select * from parcalar", parca_dataBase);
            parca_Set = new DataSet();
            parca_dataBase.Open();
            parca_adapter.Fill(parca_Set, "parcalar");
            dataGridView1.DataSource = parca_Set.Tables["parcalar"];
            parca_dataBase.Close();
        }

        private void parca_Admin_Load(object sender, EventArgs e)
        {
            parca_Listele();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            parca_command = new OleDbCommand();
            parca_dataBase.Open();
            parca_command.Connection = parca_dataBase;
            parca_command.CommandText = "Insert into parcalar (Urun_ID, Marka, Model, GDDR_OnBellek, Garanti_Suresi, Fiyat) values  (" + "'" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + Convert.ToInt32(textBox6.Text) + "')";
            parca_command.ExecuteNonQuery();

            parca_dataBase.Close();
            parca_Listele();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            parca_command = new OleDbCommand();
            parca_dataBase.Open();
            parca_command.Connection = parca_dataBase;
            parca_command.CommandText = "Delete from parcalar where Urun_ID='" + textBox1.Text + "'";
            parca_command.ExecuteNonQuery();

            parca_dataBase.Close();
            parca_Listele();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void update_Click(object sender, EventArgs e)
        {
            parca_command = new OleDbCommand();
            parca_dataBase.Open();
            parca_command.Connection = parca_dataBase;
            parca_command.CommandText = "Update parcalar Set Urun_ID='" + textBox1.Text + "',Marka='" + textBox2.Text + "',Model='" + textBox3.Text + "',GDDR_OnBellek='" + textBox4.Text + "',Garanti_Suresi='" + textBox5.Text + "',Fiyat='" + Convert.ToInt32(textBox6.Text) + "' where Urun_ID='" + textBox1.Text + "'";
            parca_command.ExecuteNonQuery();

            parca_dataBase.Close();
            parca_Listele();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void update_Cell(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void perplexButton4_Click(object sender, EventArgs e)
        {
            kullanici_Admin kullanici_Admin = new kullanici_Admin();
            kullanici_Admin.Show();
            this.Close();
        }
    }
}
