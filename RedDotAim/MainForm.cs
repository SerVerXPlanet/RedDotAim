using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace RedDotAim
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			const int SIZE = 7;
			
			var gp = new GraphicsPath();
			gp.AddEllipse(0, 0, SIZE, SIZE);
			var r = new Region(gp);
			this.Region = r;
		}
	}
}
