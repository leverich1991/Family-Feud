using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FamilyFeudPrism
{
    public partial class High_Scores : Form, IComparer<string[]> //sorting by string, 5 would be greater than 400000000000
    {
        public StreamReader str = new StreamReader("records.txt");
        public List<string[]> scorelist = new List<string[]>();
        public High_Scores()
        {
            InitializeComponent();
            while (!str.EndOfStream)
            {
                string unedited = str.ReadLine();
                string[] data = unedited.Split(' ');
                scorelist.Add(data);
            }
                scorelist.Sort(0, scorelist.Count, this);
                scorelist.Reverse();
                labelScore1.Text = "$" + scorelist[0][0];
                labelFM1.Text = scorelist[0][1];
                labelDate1.Text = scorelist[0][2];
                labelGameNumber1.Text = scorelist[0][3];
                labelScore2.Text = "$" + scorelist[1][0];
                labelFM2.Text = scorelist[1][1];
                labelDate2.Text = scorelist[1][2];
                labelGameNumber2.Text = scorelist[1][3];
                labelScore3.Text = "$" + scorelist[2][0];
                labelFM3.Text = scorelist[2][1];
                labelDate3.Text = scorelist[2][2];
                labelGameNumber3.Text = scorelist[2][3];
                labelScore4.Text = "$" + scorelist[3][0];
                labelFM4.Text = scorelist[3][1];
                labelDate4.Text = scorelist[3][2];
                labelGameNumber4.Text = scorelist[3][3];
                labelScore5.Text = "$" + scorelist[4][0];
                labelFM5.Text = scorelist[4][1];
                labelDate5.Text = scorelist[4][2];
                labelGameNumber5.Text = scorelist[4][3];
        }

        public int Compare(string[] x, string[] y)
        {
            return ((Convert.ToInt32(x[0])).CompareTo(Convert.ToInt32(y[0])));
        }
    }
}
