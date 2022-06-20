using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoggingApp
{
    public partial class Default : System.Web.UI.Page
    {
        private SqlConnection sqlConnection = null;
        protected async void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();
        }

        protected async void Button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> db = new Dictionary<string, string>();

            SqlCommand getTopics = new SqlCommand("SELECT [Name], [Author], [Id_post] FROM [Topics]", sqlConnection);

            SqlDataReader sqlReader = null;

            try
            {
                sqlReader = await getTopics.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    db.Add(Convert.ToString(sqlReader["Name"]), Convert.ToString(sqlReader["Author"]));
                }
            }
            catch { }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
            if ()
        } 
        
        
    }
}