/*
 * Created by SharpDevelop.
 * User: alex.meyer
 * Date: 7/3/2013
 * Time: 2:24 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Security;

namespace EncryptIt
{
	/// <summary>
	/// Description of EnterPassword.
	/// </summary>
	public partial class EnterPassword : Form
	{
		SecureString pwd = new SecureString();
		public EnterPassword()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.CenterToScreen();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		//Cancel Button
		void Button2Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Dispose();
		}
		
		void Button1Click(object sender, System.EventArgs e)
		{
			checkForm();
		}
		
		void EnterPassword_KeyDown(object sender, KeyEventArgs e){
			if(e.KeyCode == Keys.Enter){
				checkForm();
			}
		}
			
		void checkForm(){
			if(textBox1.Text.Equals(textBox2.Text)){
				if(textBox1.Text.Equals("")){
				   	MessageBox.Show("Your password cannot be blank, please try again");
				   	textBox1.Focus();
				   }
				else{
					foreach (char c in textBox1.Text){
						pwd.AppendChar(c);
						}
					this.DialogResult = DialogResult.OK;
					this.Dispose();
					}
			}
			else{
				MessageBox.Show("Passwords do not match, please try again");
				textBox1.Text = "";
				textBox2.Text = "";
				textBox1.Focus();
				}
		}
		
		public SecureString getPassword(){
			return pwd;
		}
	}
}
