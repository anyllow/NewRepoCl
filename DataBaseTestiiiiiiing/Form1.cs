using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseTestiiiiiiing
{
    
    public partial class Form1 : Form
    {
        private SqlConnection nrthwndConnection = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(textBox1.Text, nrthwndConnection);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];
            
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            nrthwndConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthwndDB"].ConnectionString);
            nrthwndConnection.Open();
        }
    }
}
