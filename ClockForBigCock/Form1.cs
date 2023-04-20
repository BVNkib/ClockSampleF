using System;
using System.Windows.Forms;

namespace ClockForBigCock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
            var primaryMonitorArea = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea;
            Left = primaryMonitorArea.Right - Width - 10;
            Top = primaryMonitorArea.Bottom - Height - 10;
            Timer timer = new Timer();
        }
        Timer timer = new Timer();

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            timer.Tick += new EventHandler(Timer1_Tick);
            timer.Start();
        }

        unsafe void CoolerTimeOutput(int timeValue, ref string time,string Space) {
            if (timeValue < 10) time += "0" + timeValue;
            else time += timeValue;
            time += Space;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;

            string data = "";
            string time = "";

            CoolerTimeOutput(hour, ref time,":");
            CoolerTimeOutput(minute, ref time, ":");
            CoolerTimeOutput(second, ref time,"");

            CoolerTimeOutput(day,ref data,".");
            CoolerTimeOutput(month, ref data,".");
            CoolerTimeOutput(year, ref data,"");
            label1.Text = time;
            label3.Text = data;
        }
        private void Exit_picture_box_click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
