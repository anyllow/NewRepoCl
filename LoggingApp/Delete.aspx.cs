/* *************************************************
 * Author: Rajesh Lal(connectrajesh@hotmail.com)
 * Date: 12/14/06
 * Company Info: www.irajesh.com
 * See EULA.txt and Copyright.txt for additional information
 * **************************************************/
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Configuration; 

namespace JumpyForum
{
	/// <summary>
	/// Summary description for Delete.
	/// </summary>
	public class Delete : System.Web.UI.Page
	{
		private int articleid = 0;
		private int commentid  =0;

		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			if (Request.QueryString["id"] != null)  
				articleid = Convert.ToInt32(Request.QueryString["id"]); 
 
			if (Request.QueryString["CId"] != null)  
				commentid = Convert.ToInt32(Request.QueryString["CId"]); 
 
			
			try
			{


				clsDataAccess myclass = new clsDataAccess();
				myclass.openConnection();
				Boolean myReturn = myclass.DeleteForumData(articleid,commentid);
				myclass.closeConnection();
				Response.Redirect("Forum.aspx?id=" + articleid );

			}
			catch(Exception)
			{
				Response.Write("<h2> Unexpected error ! Try slamming your head into your computer monitor :)</h2>"); 

			}


		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.Load += new System.EventHandler(this.Page_Load);
		}
		#endregion
	}
}
