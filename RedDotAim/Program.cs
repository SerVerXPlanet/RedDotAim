/*
 * Created by SharpDevelop.
 * User: SerVer
 * Date: 13.10.2020
 * Time: 18:24
 */
using System;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;


namespace RedDotAim
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
        const int WM_SYSCOMMAND = 0x0112;
        const int SC_CLOSE      = 0xF060;
        
        [DllImport("user32.dll")]
        static extern int FindWindow(
            string lpClassName, // class name 
            string lpWindowName // window name 
        );
        
        [DllImport("user32.dll")]
        static extern int SendMessage(
            int hWnd, // handle to destination window 
            uint Msg, // message 
            int wParam, // first message parameter 
            int lParam // second message parameter 
        );
        
        
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			
			bool isFirstInstance;
            
            using (Mutex mtx = new Mutex(true, "RedDotAim", out isFirstInstance))
            {
                if (isFirstInstance)
                {
                    Application.Run(new MainForm());
                }
                else
                {
                    // The application is already running
                    
                    // Determine the handle to the Application window.
                    int iHandle = FindWindow(null, "RedDotAim");
                    
                    // Post a message to Application to end its existence. 
                    SendMessage(iHandle, WM_SYSCOMMAND, SC_CLOSE, 0);
                }
            } // releases the Mutex
		}
		
		
	}
}
