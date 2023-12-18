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
        int dirt;
        int cobbleStone;
        int iron;
        int gold;
        int diamond;
        int emerald;
        int netherite;
        int chainmailSArmorTrim;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (money >= 128 && dirt != 2)
            {
                money -= 128;
                dirtChance -= 1;
                dirt++;
            }
            lblMoney2.Text = "Money: " + money;

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
            Form1 slots = new Form1();
            this.Hide();
            slots.StartPosition = FormStartPosition.CenterScreen;
            slots.ShowDialog();
            this.Close();

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
            lblMoney2.Text = "Money: " + Class1.money;
        }

        private void Form3_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (money >= 256 && cobbleStone != 4)
            {
                money -= 256;
                cobbleStoneChance -= 2;
                cobbleStone++;
            }
            lblMoney2.Text = "Money: " + money;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (money >= 512 && iron != 16)
            {
                money -= 512;
                ironChance -= 4;
                ironChance++;
            }
            lblMoney2.Text = "Money: " + money;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (money >= 1024 && gold != 64)
            {
                money -= 1024;
                goldChance -= 8;
                gold++;
            }
            lblMoney2.Text = "Money: " + money;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (money >= 2048 && diamond != 128)
            {
                money -= 2048;
                diamondChance -= 16;
                diamond++;
            }
            lblMoney2.Text = "Money: " + money;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (money >= 4096 && emerald != 256)
            {
                money -= 4096;
                emeraldChance -= 32;
                emerald++;
            }
            lblMoney2.Text = "Money: " + money;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (money >= 8192 && netherite != 512)
            {
                money -= 8192;
                netheriteChance -= 64;
                netherite++;
            }
            lblMoney2.Text = "Money: " + money;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (money >= 16384 && chainmailSArmorTrim != 1024)
            {
                money -= 16384;
                chainmailSArmorTrimChance -= 128;
                chainmailSArmorTrim++;
            }
            lblMoney2.Text = "Money: " + money;
        }
    }
}
