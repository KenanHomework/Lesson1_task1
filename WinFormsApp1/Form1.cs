using WinFormsApp1.Properties;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pbx_loc.Image = Resources.baku;
            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        public bool timeChanger = false;

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (timeChanger)
            {
                pbx_loc.Image = Resources.baku;
                timeChanger = false;
            }
            else
            {
                pbx_loc.Image = Resources.london;
                timeChanger = true;
            }



        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            string zone;
            if (timeChanger)
                zone = "Azerbaijan Standard Time";
            else
                zone = "E. Europe Standard Time";

            var timeUtc = DateTime.UtcNow;
            var easternZone = TimeZoneInfo.FindSystemTimeZoneById(zone);
            var today = TimeZoneInfo.ConvertTimeFromUtc(timeUtc, easternZone);
            Text = today.ToLongTimeString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}