namespace Alarm
{

    public partial class Form1 : Form
    {
        private TimeSpan timerData = default;
        private TimeSpan alarmData = default;

        public Form1()
        {
            InitializeComponent();
        }

        public void TimeCycle()
        {
            MainClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        public void TimerCycle()
        {
            if (timerData <= TimeSpan.Zero)
            {
                return;
            }

            timerData = timerData.Subtract(TimeSpan.FromSeconds(1));

            TimerValue.Text = timerData.ToString(@"hh\:mm\:ss");

            Task.Run(() =>
            {
                if (timerData == TimeSpan.Zero)
                {
                    timerData = default;
                    Console.Beep(1320, 500);
                    Console.Beep(990, 250);
                    Console.Beep(1056, 250);
                    Console.Beep(1188, 250);
                    Console.Beep(1320, 125);
                    Console.Beep(1188, 125);
                    Console.Beep(1056, 250);
                    Console.Beep(990, 250);
                    Console.Beep(880, 500);
                    Console.Beep(880, 250);
                    Console.Beep(1056, 250);
                    Console.Beep(1320, 500);
                    Console.Beep(1188, 250);
                    Console.Beep(1056, 250);
                    Console.Beep(990, 750);
                    Console.Beep(1056, 250);
                    Console.Beep(1188, 500);
                    Console.Beep(1320, 500);
                    Console.Beep(1056, 500);
                    Console.Beep(880, 500);
                    Console.Beep(880, 500);
                    System.Threading.Thread.Sleep(250);
                    Console.Beep(1188, 500);
                    Console.Beep(1408, 250);
                    Console.Beep(1760, 500);
                    Console.Beep(1584, 250);
                    Console.Beep(1408, 250);
                    Console.Beep(1320, 750);
                    Console.Beep(1056, 250);
                    Console.Beep(1320, 500);
                    Console.Beep(1188, 250);
                    Console.Beep(1056, 250);
                    Console.Beep(990, 500);
                    Console.Beep(990, 250);
                    Console.Beep(1056, 250);
                    Console.Beep(1188, 500);
                    Console.Beep(1320, 500);
                    Console.Beep(1056, 500);
                    Console.Beep(880, 500);
                    Console.Beep(880, 500);
                }
            });
        }

        public void AlarmLogic()
        {
            if (alarmData <= TimeSpan.Zero)
            {
                return;
            }

            int comparisonResult = TimeSpan.Compare(alarmData, DateTime.Now.TimeOfDay);

            Task.Run(() =>
            {
                if (comparisonResult <= 0)
                {
                    alarmData = default;
                    Console.Beep(704, 750);
                    Console.Beep(792, 250);
                    Console.Beep(880, 500);
                    Console.Beep(792, 500);
                    Console.Beep(940, 500);
                    Console.Beep(880, 500);
                    Console.Beep(792, 250);
                    Console.Beep(660, 250);
                    Console.Beep(704, 500);
                    Console.Beep(1188, 500);
                    Console.Beep(1056, 500);
                    Console.Beep(940, 500);
                    Console.Beep(880, 500);
                    Console.Beep(792, 500);
                    Console.Beep(880, 250);
                    Console.Beep(704, 250);
                    Console.Beep(1056, 1000);
                    Console.Beep(704, 750);
                    Console.Beep(792, 250);
                    Console.Beep(880, 500);
                    Console.Beep(792, 500);
                    Console.Beep(940, 500);
                    Console.Beep(880, 500);
                    Console.Beep(792, 250);
                    Console.Beep(660, 250);
                    Console.Beep(704, 500);
                    Console.Beep(1188, 500);
                    Console.Beep(1056, 500);
                    Console.Beep(940, 500);
                    Console.Beep(880, 500);
                    Console.Beep(792, 500);
                    Console.Beep(880, 250);
                    Console.Beep(704, 250);
                    Console.Beep(1056, 1000);
                }
            });
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            while (true)
            {
                TimeCycle();
                TimerCycle();
                AlarmLogic();
                await Task.Delay(1000);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTimers_Click(object sender, EventArgs e)
        {
            using (Form2 inputForm = new Form2())
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    timerData = inputForm.selectedDate;

                    TimerValue.Text = timerData.ToString(@"hh\:mm\:ss");
                }
            }

        }

        private async void TimerValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAlarms_Click(object sender, EventArgs e)
        {
            using (Form2 inputForm = new Form2())
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    alarmData = inputForm.selectedDate;

                    NewAlarm.Text = alarmData.ToString(@"hh\:mm\:ss");
                }
            }
        }
    }
}
