/*
 * Created by SharpDevelop.
 * User: CC2_PC28
 * Date: 28/10/2026
 * Time: 07:34 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyectoPrueba
{
	/// <summary>
	/// Description of Login.
	/// </summary>
	public partial class Login : Form
	{
		public Login()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void RegresarToolStripMenuItemClick(object sender, EventArgs e)
		{
			MainForm f=new MainForm();
			f.Show();
			this.Close();
		}
	}
}
