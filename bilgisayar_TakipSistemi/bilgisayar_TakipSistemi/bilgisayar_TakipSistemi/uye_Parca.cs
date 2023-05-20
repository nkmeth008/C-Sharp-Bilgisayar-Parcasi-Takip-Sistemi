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
    public partial class uye_Parca : Form
    {
        OleDbConnection parca_dataBase = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Kullanicilar.accdb");
        OleDbDataAdapter parca_adapter;
        DataSet parca_Set;
        OleDbCommand parca_command;
        OleDbDataReader parca_reader;
        public uye_Parca()
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
        private void uye_Parca_Load(object sender, EventArgs e)
        {
            parca_Listele();
        }

        private void perplexTheme1_Click(object sender, EventArgs e)
        {

        }

        private void perplexControlBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
