using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace FinalProjectCS2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int dirtChance = 5;
        int cobbleStoneChance = 17;
        int ironChance = 65;
        int goldChance = 129;
        int diamondChance = 257;
        int emeraldChance = 513;
        int netheriteChance = 1029;
        int chainmailSArmorTrimChance = 10000001;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dirtChance += 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
