using System.Windows.Forms;

namespace FinalProjectCS2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        Random random = new Random();

        int dirt;
        int cobbleStone;
        int iron;
        int gold;
        int diamond;
        int emerald;
        int netherite;
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
        int money = 0;
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Play_Click(object sender, EventArgs e)
        {
            pictureBoxes();
            slotChecker();
        }
        private void Odds()
        {

            dirt = random.Next(1, 5);
            cobbleStone = random.Next(1, 17);
            iron = random.Next(1, 65);
            gold = random.Next(1, 129);
            diamond = random.Next(1, 513);
            emerald = random.Next(1, 1025);
            netherite = random.Next(1, 2049);
            chainmailSArmorTrim = random.Next(1, 100000001);
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
            for (int i = 0; i <= 100; i++) {
                pictureBoxes();
                slotChecker();
            }
        }
        private void pictureBoxes()
        {
            PictureBox[] pictureBoxes = { pb1, pb2, pb3 };
            for (int i = 0; i < pictureBoxes.Length; i++)
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

            dirtCount = 0;
            cobbleStoneCount = 0;
            ironCount = 0;
            goldCount = 0;
            diamondCount = 0;
            emeraldCount = 0;
            netheriteCount = 0;
            chainmailSArmorTrimCount = 0;
            xCount = 0;
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


        }
    }
}