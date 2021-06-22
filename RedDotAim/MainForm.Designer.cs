/*
 * Created by SharpDevelop.
 * User: SerVer
 * Date: 13.10.2020
 * Time: 18:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RedDotAim
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
		    this.SuspendLayout();
		    // 
		    // MainForm
		    // 
		    this.BackColor = System.Drawing.Color.Red;
		    this.ClientSize = new System.Drawing.Size(100, 100);
		    this.ControlBox = false;
		    this.Cursor = System.Windows.Forms.Cursors.Default;
		    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		    this.MaximizeBox = false;
		    this.MinimizeBox = false;
		    this.Name = "MainForm";
		    this.ShowIcon = false;
		    this.ShowInTaskbar = false;
		    this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		    this.Text = "RedDotAim";
		    this.TopMost = true;
		    this.Load += new System.EventHandler(this.MainFormLoad);
		    this.ResumeLayout(false);

		}
	}
}
