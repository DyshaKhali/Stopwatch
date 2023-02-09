using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Stopwatch
{
    public partial class Form1 : Form
    {
        private Font FntTW = new Font("Arial", 84);
        int ValueStopwatch = 0;
        int Calc = 0;
        bool Flash = false;

        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void Start()
        {
            timer1.Enabled = true;
            StopBut.Text = "STOP";
            Invalidate();
        }

        void Stop()
        {
            if (timer1.Enabled)
            {
                StopBut.Text = "RESET";
            }
            else
            {
                ValueStopwatch = 0;
                StopBut.Text = "STOP";
            }

            timer1.Enabled = false;

            Invalidate();
        }

        //
        void Tick()
        {
            Flash = Flash ? false : true;

            if (Calc == 2) { ValueStopwatch++; }
            Calc = Calc >= 2 ? 0 : Calc += 1;

            if (ValueStopwatch == 60)
            {
                MessageBox.Show("One minute!");
            }

            Invalidate();
        }
        private void Start_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Tick();
        }

        private void StopBut_Click(object sender, EventArgs e)
        {
            Stop();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            string s = Flash ? "{0:00}   {1:00}" : "{0:00} : {1:00}";

            e.Graphics.DrawString(string.Format(s, ValueStopwatch / 60, ValueStopwatch % 60), FntTW, Brushes.WhiteSmoke, new PointF());
        }
    }
}
