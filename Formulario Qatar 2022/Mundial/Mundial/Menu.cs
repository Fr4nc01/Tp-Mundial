/*
 * Created by SharpDevelop.
 * User: Alumno
 * Date: 14/11/2022
 * Time: 10:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mundial
{
	/// <summary>
	/// Description of Menu.
	/// </summary>
	public partial class Menu : Form
	{
		
		MainForm ventana = new MainForm();
		
		public Menu()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			ventana.ControlSection.SelectedIndex = 1;
			ventana.ShowDialog();
		}
		
		void MenuLoad(object sender, EventArgs e)
		{
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			ventana.ControlSection.SelectedIndex = 0;
			ventana.ShowDialog();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			ventana.ControlSection.SelectedIndex = 2;
			ventana.ShowDialog();
		}
	}
}
