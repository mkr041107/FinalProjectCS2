using System.Data.SqlTypes;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace FinalProjectCS2
{
    public partial class Form1 : Form
    {




        public Form1()
        {
            InitializeComponent();

        }

        Random random = new Random();

        int money = Class1.money;
        int dirt;
        int cobbleStone;
        int iron;
        int gold;
        int diamond;
        int emerald;
        int netherite;
        int dirtChance;
        int cobbleStoneChance;
        int ironChance;
        int goldChance;
        int diamondChance;
        int emeraldChance;
        int netheriteChance;
        int chainmailSArmorTrimChance;
        int chainmailSArmorTrim;
        int dirtCount = 0;
        int cobbleStoneCount = 0;
        int ironCount = 0;
        int goldCount = 0;
        int diamondCount = 0;
        int emeraldCount = 0;
        int netheriteCount = 0;
        int chainmailSArmorTrimCount = 0;
        int xCount = 0;

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Play_Click(object sender, EventArgs e)
        {
            pictureBoxes();
            slotChecker();
            lblMoney.Text = money.ToString();
        }
        private void Odds()
        {

            dirt = random.Next(1, dirtChance);
            cobbleStone = random.Next(1, cobbleStoneChance);
            iron = random.Next(1, ironChance);
            gold = random.Next(1, goldChance);
            diamond = random.Next(1, diamondChance);
            emerald = random.Next(1, emeraldChance);
            netherite = random.Next(1, netheriteChance);
            chainmailSArmorTrim = random.Next(1, chainmailSArmorTrimChance);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 winingSheet = new Form2();
            this.Hide();
            winingSheet.StartPosition = FormStartPosition.CenterScreen;
            winingSheet.ShowDialog();
            this.Close();
        }

        private void AutoPlay_Click(object sender, EventArgs e)
        {

        }
        private void pictureBoxes()
        {
            PictureBox[] pictureBoxes = { pb1, pb2, pb3 };
            for (int i = 0; i < 3; i++)
            {
                Odds();




                if (dirt == 4)
                {
                    pictureBoxes[i].Image = Properties.Resources.dirt;
                    dirtCount++;
                }
                else if (cobbleStone == 16)
                {
                    pictureBoxes[i].Image = Properties.Resources.cobblestone;
                    cobbleStoneCount++;
                }
                else if (iron == 64)
                {
                    pictureBoxes[i].Image = Properties.Resources.iron;
                    ironCount++;
                }
                else if (gold == 128)
                {
                    pictureBoxes[i].Image = Properties.Resources.gold;
                    goldCount++;
                }
                else if (diamond == 512)
                {
                    pictureBoxes[i].Image = Properties.Resources.diamond;
                    diamondCount++;
                }
                else if (emerald == 1024)
                {
                    pictureBoxes[i].Image = Properties.Resources.emerald;
                    emeraldCount++;
                }
                else if (netherite == 2048)
                {
                    pictureBoxes[i].Image = Properties.Resources.netherite;
                    netheriteCount++;
                }
                else if (chainmailSArmorTrim == 10000000)
                {
                    pictureBoxes[i].Image = Properties.Resources.silentarmortrim;
                    chainmailSArmorTrimCount++;
                }
                else
                {
                    pictureBoxes[i].Image = Properties.Resources.x;
                    xCount++;
                }
            }


        }
        private void slotChecker()
        {


            if (dirtCount == 3)
            {
                money += 4;
            }
            if (cobbleStoneCount == 3)
            {
                money += 16;
            }
            if (ironCount == 3)
            {
                money += 64;
            }
            if (goldCount == 3)
            {
                money += 128;
            }
            if (diamondCount == 3)
            {
                money += 256;
            }
            if (emeraldCount == 3)
            {
                money += 512;
            }
            if (netheriteCount == 3)
            {
                money += 1028;
            }
            if (chainmailSArmorTrimCount == 3)
            {
                MessageBox.Show("You Win!!!");
                this.Close();
            }
            if (xCount == 3)
            {
                money += -2;

            }
            dirtCount = 0;
            cobbleStoneCount = 0;
            ironCount = 0;
            goldCount = 0;
            diamondCount = 0;
            emeraldCount = 0;
            netheriteCount = 0;
            chainmailSArmorTrimCount = 0;
            xCount = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form3 Upgrades = new Form3();
            this.Hide();
            Upgrades.StartPosition = FormStartPosition.CenterScreen;
            Upgrades.ShowDialog();
            this.Close();

            money = Class1.money;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dirtChance = Class2.dirtChance;
            cobbleStoneChance = Class2.cobbleStoneChance;
            ironChance = Class2.ironChance;
            goldChance = Class2.goldChance;
            diamondChance = Class2.diamondChance;
            emeraldChance = Class2.emeraldChance;
            netheriteChance = Class2.netheriteChance;
            chainmailSArmorTrimChance = Class2.ChainMailSArmorTrimChance;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                money += 100000;

            }
        }
    }
}