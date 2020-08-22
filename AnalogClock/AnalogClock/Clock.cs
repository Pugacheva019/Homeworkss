using System;
using System.Drawing;
using System.Windows.Forms;

namespace AnalogClock
{
    /// <summary>
    /// Clock's form
    /// </summary>
    public partial class Clock : Form
    {
        private Timer Timer = new Timer();
        private Timer timerTest = new Timer();

        /// <summary>
        /// Clock's initialization
        /// </summary>
        public Clock()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clock's Hands
        /// </summary>
        private const int SecondHand = 90;
        private const int MinuteHand = 50;
        private const int HourHand = 25;

        /// <summary>
        /// Clock's Face's center
        /// </summary>
        int CenterX = 75, CenterY = 75;

        private Bitmap Back;

        private Graphics FaceClock;

        /// <summary>
        /// Clock's loading
        /// </summary>
        private void ClockLoad(object sender, EventArgs e)
        {
            Back = new Bitmap(150,150);
            Timer.Interval = 100;
            timerTest.Tick += new EventHandler(TestClock);
            timerTest.Start();
            Timer.Tick += new EventHandler(this.Timer_Tick);
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            FaceClock = Graphics.FromImage(Back);
            int seconds = DateTime.Now.Second;
            int minutes = DateTime.Now.Minute;
            int Hours = DateTime.Now.Hour;
            int[] hand = new int[2];
            FaceClock.Clear(Color.White);
            hand = Corder(seconds, SecondHand);
            FaceClock.DrawLine(new Pen(Color.Yellow, 1f), new Point(CenterX, CenterY), new Point(hand[0], hand[1]));
            hand = Corder(minutes, MinuteHand);
            FaceClock.DrawLine(new Pen(Color.LightGray, 2f), new Point(CenterX, CenterY), new Point(hand[0], hand[1]));
            hand = HourCorner(Hours % 12, minutes, HourHand);
            FaceClock.DrawLine(new Pen(Color.Black, 2f), new Point(CenterX, CenterY), new Point(hand[0], hand[1]));
            pictureBox1.Image = Back;
        }

        /// <summary>
        /// Hand's corders
        /// </summary>
        private int[] Corder(int Move, int Hourlen)
        {
            int[] Corder = new int[2];
            Move *= 6;

            if (Move >= 0 && Move <= 180)
            {
                Corder[0] = CenterX + (int)(Hourlen * Math.Sin(Math.PI * Move / 180));
                Corder[1] = CenterY - (int)(Hourlen * Math.Cos(Math.PI * Move / 180));
            }
            else
            {
                Corder[0] = CenterX - (int)(Hourlen * -Math.Sin(Math.PI * Move / 180));
                Corder[1] = CenterY - (int)(Hourlen * Math.Cos(Math.PI * Move / 180));
            }
            return Corder;
        }

        private int[] HourCorner(int HourMove, int MinuteMove, int hlen)
        {
            int[] Corner = new int[2];
            int Move = (int)((HourMove * 30) + (MinuteMove * 0.5));

            if (Move >= 0 && Move <= 180)
            {
                Corner[0] = CenterX + (int)(hlen * Math.Sin(Math.PI * Move / 180));
                Corner[1] = CenterY - (int)(hlen * Math.Cos(Math.PI * Move / 180));
            }
            else
            {
                Corner[0] = CenterX - (int)(hlen * -Math.Sin(Math.PI * Move / 180));
                Corner[1] = CenterY - (int)(hlen * Math.Cos(Math.PI * Move / 180));
            }
            return Corner;
        }

        private void TestClock(object sender, EventArgs e)
        {
            int Hours = DateTime.Now.Hour;
            int Minutes = DateTime.Now.Minute;
            int Seconds = DateTime.Now.Second;
            string TimeText = "";
            if (Hours < 10)
            {
                TimeText = "0" + Hours + ":";
            }
            else
            {
                TimeText =  Hours + ":";
            }
            if (Minutes < 10)
            {
                TimeText += "0" + Minutes + ":";
            }
            else
            {
                TimeText += Minutes + ":";
            }
            if (Seconds < 10)
            {
                TimeText += "0" + Seconds;
            }
            else
            {
                TimeText += Seconds;
            }
            time.Text = TimeText;
        }
    }
}