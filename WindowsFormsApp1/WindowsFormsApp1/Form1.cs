using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string 
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "othodDataSet4.Emission". При необходимости она может быть перемещена или удалена.
            this.emissionTableAdapter2.Fill(this.othodDataSet4.Emission);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "othodDataSet3.Emission". При необходимости она может быть перемещена или удалена.
            this.emissionTableAdapter1.Fill(this.othodDataSet3.Emission);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "othodDataSet2.Emission". При необходимости она может быть перемещена или удалена.
            this.emissionTableAdapter.Fill(this.othodDataSet2.Emission);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "othodDataSet1.Source". При необходимости она может быть перемещена или удалена.
            this.sourceTableAdapter.Fill(this.othodDataSet1.Source);

        }

        private void FillSource()
        {
            string SqlText = "SELECT * FROM [Source]";
            SqlDataAdapter da = new SqlDataAdapter(SqlText, ConnStr);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Source]");
            dataGridView1.DataSource = ds.Tables["[Source]"].DefaultView;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void расчетToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
