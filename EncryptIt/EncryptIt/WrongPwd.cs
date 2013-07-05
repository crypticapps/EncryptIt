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
using System.Resources;
using System.Media;
using System.IO;

namespace EncryptIt
{
	/// <summary>
	/// Description of WrongPwd.
	/// </summary>
	public partial class WrongPwd : Form
	{
		public WrongPwd()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			System.Reflection.Assembly assem = this.GetType().Assembly;
			ResourceManager rm = new System.Resources.ResourceManager("EncryptIt.Resources",assem);
			setPicture(rm);
			playSound(rm);
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void setPicture(ResourceManager r){
			
			this.pictureBox1.Image = (Image) r.GetObject("YouDidn'tSayTheMagicWord");
		}
		
		void playSound(ResourceManager r){
			byte[] sound = (byte[])r.GetObject("dn");
			MemoryStream stream = new MemoryStream(sound);
    		SoundPlayer player = new SoundPlayer(stream);
			player.Play();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			this.Dispose();
		}
		
	}
}
