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
            Odds();
            for (int i = 1; i <= 5; i++)
            {
               
                ((PictureBox)this.Controls["pb" + i.ToString()]).Image = (Image)Properties.Resources.ResourceManager.GetObject("dice" + d.ToString());
                if (i == 1) { d1 = d; }
                if (i == 2) { d2 = d; }
                if (i == 3) { d3 = d; }
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