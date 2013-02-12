/*
 * Created by SharpDevelop.
 * User: alex.meyer
 * Date: 2/7/2013
 * Time: 1:59 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Linq;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Collections;
 
namespace Encryption
{
	partial class MainForm
	{
		public string fileEncrypt;
		public string fileDecrypt;
		public string outputEncrypt;
		public string outputDecrypt;
		public string pwd;
		ArrayList initialFile = new ArrayList();
		ArrayList onepass = new ArrayList();
		ArrayList twopass = new ArrayList();
		const int keysize = 256;
		const string initVector = "x2if5h4kap1w48g3";
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.button3 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.button4 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(1, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(283, 263);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.Transparent;
			this.tabPage1.Controls.Add(this.button3);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.textBox1);
			this.tabPage1.Controls.Add(this.button2);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(275, 237);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Encrypt";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(15, 80);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(74, 22);
			this.button3.TabIndex = 4;
			this.button3.Text = "Chose File";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(15, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Filename:";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new System.Drawing.Point(15, 45);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(229, 20);
			this.textBox1.TabIndex = 2;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(65, 140);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(109, 64);
			this.button2.TabIndex = 1;
			this.button2.Text = "Encrypt";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.Transparent;
			this.tabPage2.Controls.Add(this.button4);
			this.tabPage2.Controls.Add(this.textBox2);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.button1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(275, 237);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Decrypt";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(15, 80);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(74, 22);
			this.button4.TabIndex = 6;
			this.button4.Text = "Chose File";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Location = new System.Drawing.Point(15, 45);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(229, 20);
			this.textBox2.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(15, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Filename:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(65, 140);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(109, 64);
			this.button1.TabIndex = 0;
			this.button1.Text = "Decrypt";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1FileOk);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.tabControl1);
			this.Name = "MainForm";
			this.Text = "EncryptIt";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		
		//Encrypt File Dialog
		void Button3Click(object sender, EventArgs e)
		{
			DialogResult fileChooser1 = openFileDialog1.ShowDialog();
			if(fileChooser1 == DialogResult.OK){
				fileEncrypt = openFileDialog1.FileName;
				textBox1.Text = fileEncrypt;
				encryptFilePath(fileEncrypt);
				}
		}
		
		public void encryptFilePath(string path){
			string[] breakup = path.Split('\\');
			int length = breakup.Length;
			string[] period = breakup[length-1].Split('.');
			string output = period[0]+"-encrypt.txt";
			string finalpath = "";
			for(int i = 0; i < breakup.Length - 1; i++){
				if(i == 0){
					finalpath = breakup[0];
				}
				else{
				finalpath = finalpath+"\\"+breakup[i];
				}
			}
			outputEncrypt = finalpath+"\\"+output;
		}
		
		
		public void decryptFilePath(string path){
			string[] breakup = path.Split('\\');
			int length = breakup.Length;
			string[] period = breakup[length-1].Split('-');
			string output = period[0]+"-decrypt.txt";
			string finalpath = "";
			for(int i = 0; i < breakup.Length - 1; i++){
				if(i == 0){
					finalpath = breakup[0];
				}
				else{
				finalpath = finalpath+"\\"+breakup[i];
				}
			}
			outputDecrypt = finalpath+"\\"+output;
		}
		
		void OpenFileDialog1FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			
		}
		
		//Decrypt File Dialog
		void Button4Click(object sender, EventArgs e)
		{
			DialogResult fileChooser2 = openFileDialog1.ShowDialog();
			if(fileChooser2 == DialogResult.OK){
				fileDecrypt = openFileDialog1.FileName;
				textBox2.Text = fileDecrypt;
				decryptFilePath(fileDecrypt);
				}
		}
		
		//Encrypt Button
		void Button2Click(object sender, EventArgs e)
		{
			Form1 password = new Form1();
			password.SetForm(this, "encrypt");
			password.Show();
		}
		
		//Decrypt Button
		void Button1Click(object sender, EventArgs e)
		{
			Form1 password = new Form1();
			password.SetForm(this, "decrypt");
			password.Show();
		}
		
		public void encryptFile(){
			String line;
			StreamWriter sw = new StreamWriter(outputEncrypt);
			string hash = getPasswordHash(pwd);
			try{
					StreamReader sr = new StreamReader(fileEncrypt);
					while((line = sr.ReadLine()) != null){
						initialFile.Add(line);
					}
					foreach (string pass1 in initialFile){
						onepass.Add(encrypt(pass1, hash));
					}
					initialFile.Clear();
					foreach (string pass2 in onepass){
						twopass.Add(encrypt(pass2, hash));
					}
					onepass.Clear();
					foreach (string pass3 in twopass){
						sw.WriteLine(encrypt(pass3, hash));
					}
					sw.Close();
					twopass.Clear();
					MessageBox.Show("Location of encrypted file:\n"+outputEncrypt);
			}
			catch(Exception f){
				MessageBox.Show(f.Message);
			}
		}
		
		public void decryptFile(){
			String line;
			StreamWriter sw = new StreamWriter(outputDecrypt);
			string hash = getPasswordHash(pwd);
			try{
					StreamReader sr = new StreamReader(fileDecrypt);
					while((line = sr.ReadLine()) != null){
						initialFile.Add(line);
					}
					foreach (string pass1 in initialFile){
						onepass.Add(decrypt(pass1, hash));
					}
					initialFile.Clear();
					foreach (string pass2 in onepass){
						twopass.Add(decrypt(pass2, hash));
					}
					onepass.Clear();
					foreach (string pass3 in twopass){
						sw.WriteLine(decrypt(pass3, hash));
					}
					sw.Close();
					twopass.Clear();
					MessageBox.Show("Location of decrypted file:\n"+outputDecrypt);
			}
			catch(Exception f){
				string error = f.ToString();
				sw.Close();
				MessageBox.Show("Nuh-uh-uh, didn't say the magic word!\nFile Key incorrect");
				File.Delete(outputDecrypt);
			}
		}
		
		public string  getPasswordHash(string pwd){
			MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
			byte[] src;
			byte[] hash;
			src = ASCIIEncoding.ASCII.GetBytes(pwd);
			hash = md5.ComputeHash(src);
			StringBuilder output = new StringBuilder(hash.Length);
			for(int i = 0; i < hash.Length; i++){
				output.Append(hash[i].ToString("X2"));
			}
			return output.ToString();
		}
		
		public string encrypt(string text, string pass){
			byte[] initVectorBytes = Encoding.UTF8.GetBytes(initVector);
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(text);
            PasswordDeriveBytes password = new PasswordDeriveBytes(pass, null);
            byte[] keyBytes = password.GetBytes(keysize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Padding = PaddingMode.ISO10126;
            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
            cryptoStream.FlushFinalBlock();
            memoryStream.Close();
            byte[] cipherTextBytes = memoryStream.ToArray();
            cryptoStream.Close();
            return Convert.ToBase64String(cipherTextBytes);
		}
		
		 public static string decrypt(string cipherText, string passPhrase){
            byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
            PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);
            byte[] keyBytes = password.GetBytes(keysize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Padding = PaddingMode.ISO10126;
            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
            MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
            CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];
            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
        }
		
	}
}
