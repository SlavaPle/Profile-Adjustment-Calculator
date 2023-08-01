using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Profile_Adjustment_Calculator
{

    public partial class Form1 : Form
    {
        Profile P;
        CabinSide S;
        bool Absolute = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            P = new Profile();
            S = new CabinSide();
            EnterData_Changed(sender, e);
            NudMax.Minimum = NudStandard.Value;
            NudMin.Maximum = NudStandard.Value;
            NudMax.Maximum = NudStandard.Value + 30;
            NudMax.Minimum = NudStandard.Value - 30;
        }

        bool Do = true;
        private void EnterData_Changed(object sender, EventArgs e)
        {
            if (Do)
            {
                int St = Absolute ? 0 : Convert.ToInt32(NudStandard.Value);
                int Min = (Absolute ? -1 : 1) * Convert.ToInt32(NudMin.Value);
                int Max = Convert.ToInt32(NudMax.Value);
                int mid = 0;
                P.Adjustment = Max - Min;
                P.UpAdjustment = CbMiddle.Checked ? Convert.ToInt32(Math.Round(P.Adjustment / 2f + .1)) : Max - St;
                P.DownAdjustment = CbMiddle.Checked ? -Convert.ToInt32(Math.Round(P.Adjustment / 2f - .1)) : Min - St;
                mid = Min - St - P.DownAdjustment;
                if (CbMiddle.Checked) St += mid;
                S.Deviation = TbDeviation.Value;
                S.Precision = CbPrecision.Checked;
                S.ActualValue = Convert.ToInt32(NudActual.Value) + (CbMiddle.Checked ? mid : 0);
                S.Reverse = CbReverse.Checked;
                S.Count(P);
                pictureBox1.Image = S.Img;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Do = false;
            Absolute = !Absolute;
            if (Absolute)
            {
                button1.Text = "Absolute";
                NudStandard.Visible = false;
                label1.Visible = false;
                NudMax.Minimum = 0;
                NudMin.Minimum = 0;
                NudMax.Value = NudMax.Value - NudStandard.Value;
                NudMin.Value = NudStandard.Value - NudMin.Value;
                NudMax.Maximum = 30;
                NudMin.Maximum = 30;
            }
            else
            {
                button1.Text = "Relative";
                NudStandard.Visible = true;
                label1.Visible = true;
                NudMin.Minimum = 0;
                NudMax.Maximum = NudStandard.Value + 30;
                NudMin.Maximum = NudStandard.Value;
                NudMax.Value = NudMax.Value + NudStandard.Value;
                NudMin.Value = NudStandard.Value - NudMin.Value;
                NudMax.Minimum = NudStandard.Value;
            }
            Do = true;
            EnterData_Changed(sender, e);
        }
    }

    public class Profile
    {
        public int Adjustment { get; set; }
        public int UpAdjustment { get; set; }
        public int DownAdjustment { get; set; }
    }

    class CabinSide
    {
        public bool Reverse { get; set; }
        public int Deviation { get; set; }
        public bool Precision { get; set; }
        public bool Middle { get; set; }
        public bool Tilt { get; private set; }
        public int TiltValue { get; private set; }
        public int Value { get; private set; }
        public int ActualValue { get; set; }
        public Image Img { get; private set; }

        public void Count(Profile P)
        {
            int MainAdjustment = Math.Abs(Deviation > 0 ? P.UpAdjustment : P.DownAdjustment);
            Tilt = Math.Abs(Deviation) + (Precision ? 0 : 1) >= P.Adjustment ? true : false;
            TiltValue = Tilt ? Deviation + Math.Sign(Deviation) * ((Precision ? 0 : 2) - P.Adjustment) : 0;
            Value = (Math.Abs(Deviation) < MainAdjustment + (Precision ? 1 : 0)) || Deviation == 0
                ? 0 :
                Math.Abs(Deviation) < P.Adjustment + (Precision ? 1 : 0) ?
              Convert.ToInt32(Math.Round((Deviation - P.Adjustment) / 2f - Math.Sign(Deviation) * .1) + Math.Abs(P.DownAdjustment)) :
              Deviation < 0 ? (Precision ? 0 : 1) - P.UpAdjustment : Math.Abs(P.DownAdjustment) - (Precision ? 0 : 1);
            Draw(P.Adjustment, P.DownAdjustment);
        }

        void Draw(int Adj, int Min)
        {
            int k = 30;
            int W = 30 * k;
            int H = 50 * k;
            int zero = 150;
            Img = new Bitmap((W + zero) * 2, H + zero);
            W += zero;
            using (Graphics g = Graphics.FromImage(Img))
            {
                Pen p = new Pen(Color.Black, 50);
                g.DrawLine(p, W + 30, H, W + Deviation * k + 30, zero);
                Font f = new Font("Arial", 50); ;
                g.DrawString(((Reverse ? -1 : 1) * Deviation).ToString(), f, Brushes.Black, W + Deviation * k + 30, 40);
                //string FromMin = (ActualValue + Min+Value/2).ToString();
                //string ToMax = (ActualValue + Adj + Min-Value/2).ToString();
                g.DrawString((ActualValue + Value).ToString() /*+ " (" + FromMin + " - " + ToMax + ")"*/, f, Brushes.Black, W + 60, H);
                Point[] P = { new Point(0, zero),
                    new Point(0, H),
                    new Point(W + (Min + Value) * k, H),
                    new Point(W + (Min + Value + TiltValue) * k, zero) };
                g.FillPolygon(Brushes.LightSteelBlue, P);
                p = new Pen(Color.Gray, 12);
                g.DrawLine(p, W + 5, H, W + Deviation * k + 5, zero);
                g.DrawLine(p, W + 5, H, (W - Adj * k) + 5, H);
                g.DrawLine(p, W - Adj * k + 5, H, W + (Deviation - Adj) * k + 5, zero);
                g.DrawLine(p, W + (Deviation - Adj) * k + 5, zero, W + Deviation * k + 5, zero);
                g.DrawString(((Reverse ? -1 : 1) * TiltValue).ToString(), f, Brushes.Black, W + (Min + Value + TiltValue) * k - 50, 70);
                if (Tilt) g.DrawLine(new Pen(Color.Red, 5), W + (Min + Value) * k, H, W + (Min + Value + TiltValue) * k, zero);
            }

        }
    }
}
