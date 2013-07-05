/*
 * Created by SharpDevelop.
 * User: alex.meyer
 * Date: 7/3/2013
 * Time: 2:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EncryptIt
{
	partial class MainForm
	{
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
			this.encrypt_tab = new System.Windows.Forms.TabPage();
			this.button3 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.decrypt_tab = new System.Windows.Forms.TabPage();
			this.button4 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.tabControl1.SuspendLayout();
			this.encrypt_tab.SuspendLayout();
			this.decrypt_tab.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.encrypt_tab);
			this.tabControl1.Controls.Add(this.decrypt_tab);
			this.tabControl1.Location = new System.Drawing.Point(1, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(285, 146);
			this.tabControl1.TabIndex = 0;
			// 
			// encrypt_tab
			// 
			this.encrypt_tab.BackColor = System.Drawing.Color.Transparent;
			this.encrypt_tab.Controls.Add(this.button3);
			this.encrypt_tab.Controls.Add(this.label1);
			this.encrypt_tab.Controls.Add(this.textBox1);
			this.encrypt_tab.Controls.Add(this.button2);
			this.encrypt_tab.Location = new System.Drawing.Point(4, 22);
			this.encrypt_tab.Name = "encrypt_tab";
			this.encrypt_tab.Padding = new System.Windows.Forms.Padding(3);
			this.encrypt_tab.Size = new System.Drawing.Size(277, 120);
			this.encrypt_tab.TabIndex = 0;
			this.encrypt_tab.Text = "Encrypt";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(15, 80);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(100, 30);
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
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(229, 20);
			this.textBox1.TabIndex = 2;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(135, 80);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 30);
			this.button2.TabIndex = 1;
			this.button2.Text = "Encrypt!";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// decrypt_tab
			// 
			this.decrypt_tab.BackColor = System.Drawing.Color.Transparent;
			this.decrypt_tab.Controls.Add(this.button4);
			this.decrypt_tab.Controls.Add(this.textBox2);
			this.decrypt_tab.Controls.Add(this.label2);
			this.decrypt_tab.Controls.Add(this.button1);
			this.decrypt_tab.Location = new System.Drawing.Point(4, 22);
			this.decrypt_tab.Name = "decrypt_tab";
			this.decrypt_tab.Padding = new System.Windows.Forms.Padding(3);
			this.decrypt_tab.Size = new System.Drawing.Size(277, 120);
			this.decrypt_tab.TabIndex = 1;
			this.decrypt_tab.Text = "Decrypt";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(15, 80);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(100, 30);
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
			this.textBox2.ReadOnly = true;
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
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(135, 80);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 30);
			this.button1.TabIndex = 0;
			this.button1.Text = "Decrypt!";
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
			this.ClientSize = new System.Drawing.Size(284, 144);
			this.Controls.Add(this.tabControl1);
			this.Name = "MainForm";
			this.Text = "EncryptIt";
			this.tabControl1.ResumeLayout(false);
			this.encrypt_tab.ResumeLayout(false);
			this.encrypt_tab.PerformLayout();
			this.decrypt_tab.ResumeLayout(false);
			this.decrypt_tab.PerformLayout();
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
		private System.Windows.Forms.TabPage decrypt_tab;
		private System.Windows.Forms.TabPage encrypt_tab;
		private System.Windows.Forms.TabControl tabControl1;
	}
}
