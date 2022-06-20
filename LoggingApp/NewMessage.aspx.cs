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
	/// Summary description for NewMessage.
	/// </summary>
	public class NewMessage : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator3;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator2;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator1;
		protected System.Web.UI.HtmlControls.HtmlForm Form1;
		private int commentid  =1;
		protected System.Web.UI.WebControls.Label lblStatus;
		protected System.Web.UI.WebControls.Button Button2;
		protected System.Web.UI.WebControls.RequiredFieldValidator Requiredfieldvalidator4;
		protected System.Web.UI.WebControls.TextBox txtname;
		protected System.Web.UI.WebControls.TextBox txtemail;
		protected System.Web.UI.WebControls.TextBox txtcomment;
		protected System.Web.UI.WebControls.TextBox txtsubject;
		protected System.Web.UI.WebControls.TextBox txtProfile;
		protected System.Web.UI.HtmlControls.HtmlInputRadioButton MsgType_4;
		protected System.Web.UI.HtmlControls.HtmlInputRadioButton MsgType_1;
		protected System.Web.UI.HtmlControls.HtmlInputRadioButton MsgType_2;
		protected System.Web.UI.HtmlControls.HtmlInputRadioButton MsgType_5;
		private int articleid = 1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			
			if (Request.QueryString["id"] != null)  
				articleid = Convert.ToInt32(Request.QueryString["id"]); 

			if (Request.QueryString["Test"] != null)  
			{
				if (String.Compare(Request.QueryString["Test"].ToLower(),"true")== 0)  
				{
					int mParentId =0;
					int mArticleId =articleid;
					string mTitle = "Test Message - This Forum Rocks";
					string mUserName = "quartz";
					string mUserEmail = "quartz@msn.com";
					string mDescription = "Original Message - Test Description";
					int mIndent=0;

					try
					{
						SqlConnection myC =new SqlConnection();
						myC.ConnectionString=ConfigurationSettings.AppSettings["ConnectionString"];
						string sqlQuery="INSERT into " + ConfigurationSettings.AppSettings["CommentTable"] + "(ParentId,ArticleId,Title,UserName,UserEmail,Description,Indent,UserProfile) VALUES ('" +mParentId + "','" + mArticleId +  "','" + mTitle +  "','" + mUserName +  "','" + mUserEmail +  "','" + mDescription + "','" + mIndent + "','" + "http://www.codeproject.com/script/profile/whos_who.asp?id=81898" + "')"; 
						myC.Open();
						SqlCommand myCommand=new SqlCommand();
						myCommand.CommandText=sqlQuery;
						myCommand.Connection=myC;
						int i=myCommand.ExecuteNonQuery();
						myC.Close();
						lblStatus.ForeColor = Color.Green ;
						lblStatus.Text ="Status: Success";
						Response.Redirect("Forum.aspx?id=" + articleid );

					}
					catch(Exception)
					{
				
						lblStatus.ForeColor = Color.Red;
						lblStatus.Text ="Status: Error";
					}	

				}
			}
 
		}
		private void LoadComment()
		{
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
			this.txtProfile.TextChanged += new System.EventHandler(this.txtProfile_TextChanged);
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.MsgType_5.ServerChange += new System.EventHandler(this.MsgType_5_ServerChange);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			int mParentId =0;
			int mArticleId =articleid;
			string mTitle = "Test";
			string mUserName = "quartz";
			string mUserEmail = "quartz@msn.com";
			string mDescription = "Test Description";
			int mIndent=0;
			try
			{
				mTitle = txtsubject.Text;
				mUserName = txtname.Text;
				mUserEmail = txtemail.Text;
				mDescription = txtcomment.Text;
				string mProfile = txtProfile.Text;
				int mCommentType = 1;

				if (MsgType_2.Checked) 
					mCommentType = 2;
				//if (MsgType_3.Checked) 
				//	mCommentType = 3;
				if (MsgType_4.Checked) 
					mCommentType = 4;
				if (MsgType_5.Checked) 
					mCommentType = 5;


				 


				if(IsValid)
				{
					SqlConnection myC =new SqlConnection();
					myC.ConnectionString=ConfigurationSettings.AppSettings["ConnectionString"];
					string sqlQuery="INSERT into " + ConfigurationSettings.AppSettings["CommentTable"] + "(ParentId,ArticleId,Title,UserName,UserEmail,Description,Indent,UserProfile,CommentType) VALUES ('" +mParentId + "','" + mArticleId +  "','" + mTitle +  "','" + mUserName +  "','" + mUserEmail +  "','" + mDescription + "','" + mIndent + "','" + mProfile + "','" + mCommentType + "')";  
					myC.Open();
					SqlCommand myCommand=new SqlCommand();
					myCommand.CommandText=sqlQuery;
					myCommand.Connection=myC;
					int i=myCommand.ExecuteNonQuery();
					myC.Close();
					lblStatus.ForeColor = Color.Green ;
					lblStatus.Text ="Status: Success";
					Response.Redirect("Forum.aspx?id=" + articleid );
				}
			}
			catch(Exception)
			{
				
				lblStatus.ForeColor = Color.Red;
				lblStatus.Text ="Status: Error";
			}	
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("Forum.aspx?id=" + articleid );
		}

		private void txtProfile_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void MsgType_5_ServerChange(object sender, System.EventArgs e)
		{
		
		}
	}
}
