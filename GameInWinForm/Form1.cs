using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace GameInWinForm
{
    public partial class Form1 : Form
    {
     
        private SqlConnection sqlConnection = null;
        public Form1()
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);

            if (sqlConnection.State == ConnectionState.Open)
                MessageBox.Show("Everything ok");
        }

        
    }
}
