using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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
        int money;
        int dirtChance;
        int cobbleStoneChance;
        int ironChance;
        int goldChance;
        int diamondChance;
        int emeraldChance;
        int netheriteChance;
        int chainmailSArmorTrimChance;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (money >= 128)
            {
                money -= 128;
                dirtChance += 1;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
Class2.dirtChance = dirtChance;
            Class2.cobbleStoneChance = cobbleStoneChance;
            Class2.ironChance = ironChance;
            Class2.goldChance = goldChance;
            Class2.diamondChance = diamondChance;
            Class2.emeraldChance = emeraldChance;
            Class2.netheriteChance = netheriteChance;
            Class2.ChainMailSArmorTrimChance = chainmailSArmorTrimChance;
            

        }

        private void Form3_Load(object sender, EventArgs e)
        {

           money = Class1.money;
           dirtChance = Class2.dirtChance;
           cobbleStoneChance = Class2.cobbleStoneChance;
           ironChance = Class2.ironChance;
           goldChance = Class2.goldChance;
           diamondChance = Class2.diamondChance;
           emeraldChance = Class2.emeraldChance;
           netheriteChance = Class2.netheriteChance;
           chainmailSArmorTrimChance = Class2.ChainMailSArmorTrimChance;
        }

        private void Form3_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (money >= 256)
            {
                money -= 256;
                cobbleStoneChance += 2;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (money >= 512)
            {
                money -= 512;
                ironChance += 4;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (money >= 1024)
            {
                money -= 1024;
                goldChance += 8;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (money >= 2048)
            {
                money -= 2048;
                diamondChance += 16;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (money >= 4096)
            {
                money -= 4096;
                emeraldChance += 32;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (money >= 8192)
            {
                money -= 8192;
                netheriteChance += 64;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (money >= 16384)
            {
                money -= 16384;
                chainmailSArmorTrimChance += 128;
            }

        }
    }
}
