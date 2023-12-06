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
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Play_Click(object sender, EventArgs e)
        {

            for (int i = 0; i <= 3; i++)
            {
                PictureBox pictureBox = (PictureBox)Controls.Find("pb" + i, true)[0];
                Odds();
                if (dirt == 4)
                {
                    pictureBox.Image = Properties.Resources.dirt;
                }
                else if (cobbleStone == 16)
                {
                    pictureBox.Image = Properties.Resources.cobblestone;
                }
                else if (iron == 64)
                {
                    pictureBox.Image = Properties.Resources.iron;
                }
                else if (gold == 128)
                {
                    pictureBox.Image = Properties.Resources.gold;
                }
                else if (diamond == 512)
                {
                    pictureBox.Image = Properties.Resources.diamond;
                }
                else if (emerald == 1024)
                {
                    pictureBox.Image = Properties.Resources.emerald;
                }
                else if (netherite == 2048)
                {
                    pictureBox.Image = Properties.Resources.netherite;
                }
                else if (chainmailSArmorTrim == 10000000)
                {
                    pictureBox.Image = Properties.Resources.silentarmortrim;
                }
                else
                {

                    pictureBox.Image = Properties.Resources.x;
                }
            }

        }
        private void Odds()
        {

            dirt = random.Next(0, 4);
            cobbleStone = random.Next(0, 16);
            iron = random.Next(0, 64);
            gold = random.Next(0, 128);
            diamond = random.Next(0, 512);
            emerald = random.Next(0, 1024);
            netherite = random.Next(0, 2048);
            chainmailSArmorTrim = random.Next(0, 10000000);
        }
        private void imageChanger()
        {



        }
    }
}