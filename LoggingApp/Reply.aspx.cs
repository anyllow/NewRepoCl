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
	public class Reply : System.Web.UI.Page
	{
		protected System.Web.UI.HtmlControls.HtmlForm Form1;
		protected System.Web.UI.WebControls.Label lblname;
		protected System.Web.UI.WebControls.Label lblemail;
		protected System.Web.UI.WebControls.Label lbltitle;
		protected System.Web.UI.WebControls.Label lblComment;
		protected System.Web.UI.WebControls.Label lblStatus;
		protected System.Web.UI.WebControls.Label lblDate;
		
		protected System.Web.UI.WebControls.Button Button2;
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator3;
		protected System.Web.UI.WebControls.TextBox txtcomment;
		protected System.Web.UI.WebControls.RequiredFieldValidator Requiredfieldvalidator4;
		protected System.Web.UI.WebControls.TextBox txtsubject;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator2;
		protected System.Web.UI.WebControls.TextBox txtemail;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator1;
		protected System.Web.UI.WebControls.TextBox txtname;
		private int articleid = 1;
		private int myindent =0;
		protected System.Web.UI.WebControls.TextBox txtProfile;
		protected System.Web.UI.HtmlControls.HtmlInputRadioButton MsgType_4;
		protected System.Web.UI.HtmlControls.HtmlInputRadioButton MsgType_1;
		protected System.Web.UI.HtmlControls.HtmlInputRadioButton MsgType_2;
		protected System.Web.UI.HtmlControls.HtmlInputRadioButton MsgType_3;
		protected System.Web.UI.HtmlControls.HtmlInputRadioButton MsgType_5;
		private int commentid  =1;
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			LoadComment();
			if (Request.QueryString["Test"] != null)  
			{
				if (String.Compare(Request.QueryString["Test"].ToLower(),"true")== 0)  
				{
					int mParentId =commentid;
					int mArticleId =articleid;
					string mTitle = "Test Reply";
					string mUserName = "quartz";
					string mUserEmail = "quartz@msn.com";
					string mDescription = "Test Reply Description";
					int mIndent=myindent;

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
			

			if (Request.QueryString["id"] != null)  
				articleid = Convert.ToInt32(Request.QueryString["id"]); 
 
			if (Request.QueryString["CId"] != null)  
				commentid = Convert.ToInt32(Request.QueryString["CId"]); 
 
			SqlConnection myC =new SqlConnection();
			myC.ConnectionString=ConfigurationSettings.AppSettings["ConnectionString"];//"workstation id=RAJ;packet size=4096;integrated security=SSPI;data source=RAJ;persist security info=False;initial catalog=iLakshmi";
			string myQuery ="";

			    myQuery = "SELECT * FROM " + ConfigurationSettings.AppSettings["CommentTable"] + " WHERE ID=" + commentid + " and ArticleID=" + articleid ; 
			
			myC.Open();
			SqlCommand myCommand = new SqlCommand(myQuery,myC);
			
			SqlDataReader myReader = myCommand.ExecuteReader();
			if(myReader.HasRows)
			{
				while(myReader.Read())
				{
					
					lblname.Text =  myReader["Username"].ToString(); 
					lblemail.Text =  myReader["UserEmail"].ToString(); 
					lbltitle.Text =  myReader["Title"].ToString(); 
					txtsubject.Text = "Re: " + lbltitle.Text ;
					lblComment.Text =  myReader["Description"].ToString();
					lblDate.Text =  myReader["DateAdded"].ToString() + " Indent:" + myReader["Indent"].ToString();
					myindent = Convert.ToInt32(myReader["Indent"].ToString()) + 1;
				
				}
			}
			myReader.Close(); 
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
			this.MsgType_2.ServerChange += new System.EventHandler(this.MsgType_2_ServerChange);
			this.MsgType_3.ServerChange += new System.EventHandler(this.MsgType_3_ServerChange);
			this.MsgType_5.ServerChange += new System.EventHandler(this.MsgType_5_ServerChange);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			int mParentId =commentid;
			int mArticleId =articleid;
			
			string mTitle = "Test";
			string mUserName = "quartz";
			string mUserEmail = "quartz@msn.com";
			string mDescription = "Test Description";
			int mIndent=myindent;
			string mProfile ="";
			try
			{
				mTitle = txtsubject.Text;
				mUserName = txtname.Text;
				mUserEmail = txtemail.Text;
				mDescription = txtcomment.Text;
				mProfile = txtProfile.Text;

				int mCommentType = 1;

				if (MsgType_2.Checked) 
					mCommentType = 2;
				if (MsgType_3.Checked) 
					mCommentType = 3;
				if (MsgType_4.Checked) 
					mCommentType = 4;
				if (MsgType_5.Checked) 
					mCommentType = 5;

				if(IsValid)
				{
					SqlConnection myC =new SqlConnection();
					myC.ConnectionString=ConfigurationSettings.AppSettings["ConnectionString"];
					string sqlQuery="INSERT into " + ConfigurationSettings.AppSettings["CommentTable"] + "(ParentId,ArticleId,Title,UserName,UserEmail,Description,Indent,CommentType) VALUES ('" +mParentId + "','" + mArticleId +  "','" + mTitle +  "','" + mUserName +  "','" + mUserEmail +  "','" + mDescription + "','" + mIndent + "','" + mCommentType + "')"; 
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

		private void MsgType_2_ServerChange(object sender, System.EventArgs e)
		{
		
		}

		private void MsgType_3_ServerChange(object sender, System.EventArgs e)
		{
		
		}
	}
}
