﻿using System;
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
        int money = Class1.money;
        int dirtChance = Class2.dirtChance;
        int cobbleStoneChance = Class2.cobbleStoneChance;
        int ironChance = Class2.ironChance;
        int goldChance = Class2.goldChance;
        int diamondChance = Class2.diamondChance;
        int emeraldChance = Class2.emeraldChance;
        int netheriteChance = Class2.netheriteChance;
        int chainmailSArmorTrimChance = Class2.ChainMailSArmorTrimChance;
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

            MessageBox.Show("" + money);
        }

        private void Form3_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (money >= 256)
            {
                money -= 256;
                cobbleStoneChance += 1;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (money >= 512)
            {
                money -= 512;
                ironChance += 1;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (money >= 1024)
            {
                money -= 1024;
                goldChance += 1;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (money >= 2048)
            {
                money -= 2048;
                diamondChance += 1;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (money >= 4096)
            {
                money -= 4096;
                emeraldChance += 1;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (money >= 8192)
            {
                money -= 8192;
                netheriteChance += 1;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (money >= 16384)
            {
                money -= 16384;
                chainmailSArmorTrimChance += 1;
            }

        }
    }
}
