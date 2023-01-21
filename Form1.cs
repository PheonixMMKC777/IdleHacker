using System.Reflection.Metadata;

namespace IdleHacker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PreGameSetup();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NPC1_Click(object sender, EventArgs e)
        {

        }

        private void BuyNPCBTN_Click(object sender, EventArgs e)
        {
            //can u afford???

            
            // first is freee
            if (PRG.PlayerCash < PRG.NextSalePrice) {return; }

            //buy proccess
            if (this.NPCPurchaseListbox.SelectedItem == "Artist")
            {
                PRG.DerrickOwned = true;
                PRG.DerrickWorth = 10;
                PRG.TotalHires++;
                this.NPCPurchaseListbox.Items.Remove("Artist");
                this.NPC1.Visible = true;
                this.NPC1Label.Visible = true;
                PRG.DerrickTimer.Start();
            }

            if (this.NPCPurchaseListbox.SelectedItem == "Thug")
            {
                PRG.DeAndreOwned = true;
                PRG.TotalHires++;
                PRG.DeAndreWorth = 14;
                this.NPCPurchaseListbox.Items.Remove("Thug");
                this.NPC2.Visible = true;
                this.NPC2Label.Visible = true;
                PRG.DeAndreTimer.Start();
            }

            if (this.NPCPurchaseListbox.SelectedItem == "Brat")
            {
                PRG.SamOwned = true;
                PRG.TotalHires++;
                PRG.SamWorth = 21;
                this.NPCPurchaseListbox.Items.Remove("Brat");
                this.NPC3.Visible = true;
                this.NPC3Label.Visible = true;
                PRG.SamTimer.Start();
            }

            if (this.NPCPurchaseListbox.SelectedItem == "Lifter")
            {
                PRG.MichealOwned = true;
                PRG.TotalHires++;
                PRG.MichealWorth = 9;
                this.NPCPurchaseListbox.Items.Remove("Lifter");
                this.NPC7.Visible = true;
                this.NPC7Label.Visible = true;
                PRG.MichealTimer.Start();
            }

            if (this.NPCPurchaseListbox.SelectedItem == "Farmer")
            {
                PRG.MillerOwned = true;
                PRG.TotalHires++;
                PRG.MillerWorth = 25;
                this.NPCPurchaseListbox.Items.Remove("Farmer");
                this.NPC4.Visible = true;
                this.NPC4Label.Visible = true;
                PRG.MillerTimer.Start();
            }

            if (this.NPCPurchaseListbox.SelectedItem == "Linux User")
            {
                PRG.ZackOwned = true;
                PRG.TotalHires++;
                PRG.ZackWorth = 22;
                this.NPCPurchaseListbox.Items.Remove("Linux User");
                this.NPC5.Visible = true;
                this.NPC5Label.Visible = true;
                PRG.ZackTimer.Start();
            }

            if (this.NPCPurchaseListbox.SelectedItem == "E-Girl")
            {
                PRG.RoseOwned = true;
                PRG.TotalHires++;
                PRG.RoseWorth = 18;
                this.NPCPurchaseListbox.Items.Remove("E-Girl");
                this.NPC6.Visible = true;
                this.NPC6Label.Visible = true;
                PRG.RoseTimer.Start();
            }

            if (this.NPCPurchaseListbox.SelectedItem == "Army")
            {
                PRG.SargeOwned = true;
                PRG.TotalHires++;
                PRG.SargeWorth = 28;
                this.NPCPurchaseListbox.Items.Remove("Army");
                this.NPC8.Visible = true;
                this.NPC8Label.Visible = true;
                PRG.SargeTimer.Start();
            }



            if (this.NPCPurchaseListbox.Items.Count == 0)
            {
                this.BuyNPCBTN.Enabled = false;
                this.PriceForHireLabel.Text = "$: SOLD OUT!";
            }


            if (PRG.TotalHires == 1) {
                PRG.PlayerCash = PRG.PlayerCash - PRG.NextSalePrice;
                PRG.NextSalePrice = 50;
                this.PriceForHireLabel.Text = "$: " + PRG.NextSalePrice;
            }

            if (PRG.TotalHires == 2)
            {
                PRG.PlayerCash = PRG.PlayerCash - PRG.NextSalePrice;
                PRG.NextSalePrice = 300;
                this.PriceForHireLabel.Text = "$: " + PRG.NextSalePrice;
            }

            if (PRG.TotalHires == 3)
            {
                PRG.PlayerCash = PRG.PlayerCash - PRG.NextSalePrice;
                PRG.NextSalePrice = 1000;
                this.PriceForHireLabel.Text = "$: " + PRG.NextSalePrice;
            }

            if (PRG.TotalHires == 4)
            {

                PRG.PlayerCash = PRG.PlayerCash - PRG.NextSalePrice;

                PRG.NextSalePrice = 3000;
                this.PriceForHireLabel.Text = "$: " + PRG.NextSalePrice;
            }

            if (PRG.TotalHires == 5)
            {

                PRG.PlayerCash = PRG.PlayerCash - PRG.NextSalePrice;
                PRG.NextSalePrice = 9000;
                this.PriceForHireLabel.Text = "$: " + PRG.NextSalePrice;
            }

            if (PRG.TotalHires == 6)
            {

                PRG.PlayerCash = PRG.PlayerCash - PRG.NextSalePrice;
                PRG.NextSalePrice = 27000;
                this.PriceForHireLabel.Text = "$: " + PRG.NextSalePrice;
            }

            if (PRG.TotalHires == 7)
            {

                PRG.PlayerCash = PRG.PlayerCash - PRG.NextSalePrice;
                PRG.NextSalePrice = 50000;
                this.PriceForHireLabel.Text = "$: " + PRG.NextSalePrice;
            }

            if (PRG.TotalHires == 8)
            {

                PRG.PlayerCash = PRG.PlayerCash - PRG.NextSalePrice;
                PRG.NextSalePrice = 2147483647;
                
            }
            this.CashCounterLabel.Refresh();
        }


        private void PreGameSetup()
        {

            this.CashCounterLabel.Text = ("Cash: " + PRG.PlayerCash);

            PRG.EventTimer.Interval = 7000;
            PRG.EventTimer.Tick += EventTrigger;
            PRG.EventTimer.Start();

            PRG.DerrickTimer.Interval = 5000; //17
            PRG.DerrickTimer.Tick += DerrickSold;

            PRG.DeAndreTimer.Interval = 11000; //23
            PRG.DeAndreTimer.Tick += DeAndreSold;

            PRG.SamTimer.Interval = 17000; //29
            PRG.SamTimer.Tick += SamSold;

            PRG.MichealTimer.Interval = 6000; //18
            PRG.MichealTimer.Tick += MichealSold;

            /////
            /////

            PRG.MillerTimer.Interval = 13000; //25
            PRG.MillerTimer.Tick += MillerSold;

            PRG.ZackTimer.Interval = 15000; //27
            PRG.ZackTimer.Tick += ZackSold;

            PRG.RoseTimer.Interval = 12000; //24
            PRG.RoseTimer.Tick += RoseSold;

            PRG.SargeTimer.Interval = 18000; //30
            PRG.SargeTimer.Tick += SargeSold;


            PRG.BopTimer.Interval = 380;
            PRG.BopTimer.Tick += DoTheBop;
            PRG.BopTimer.Start();
        }

        void DoTheBop(object sender, EventArgs e)
        {

            if (PRG.DerrickOwned == true)
            {
                if (PRG.Bopping == false)
                {
                    this.NPC1.Image = global::IdleHacker.Properties.Resources.Artist_Bop;
                }
                if (PRG.Bopping == true)
                {
                    this.NPC1.Image = global::IdleHacker.Properties.Resources.Artist;
                }
            }

            if (PRG.DeAndreOwned == true)
            {
                if (PRG.Bopping == false)
                {
                    this.NPC2.Image = global::IdleHacker.Properties.Resources.Black_Bop;
                }
                if (PRG.Bopping == true)
                {
                    this.NPC2.Image = global::IdleHacker.Properties.Resources.Black;
                }
            }

            if (PRG.SamOwned == true)
            {
                if (PRG.Bopping == false)
                {
                    this.NPC3.Image = global::IdleHacker.Properties.Resources.Scat_Bop;
                }
                if (PRG.Bopping == true)
                {
                    this.NPC3.Image = global::IdleHacker.Properties.Resources.Scat;
                }
            }

            if (PRG.MichealOwned == true)
            {
                if (PRG.Bopping == false)
                {
                    this.NPC7.Image = global::IdleHacker.Properties.Resources.Jogger_Bop;
                }
                if (PRG.Bopping == true)
                {
                    this.NPC7.Image = global::IdleHacker.Properties.Resources.Jogger;
                }
            }

            if (PRG.MillerOwned == true)
            {
                if (PRG.Bopping == false)
                {
                    this.NPC4.Image = global::IdleHacker.Properties.Resources.Farmer_Bop;
                }
                if (PRG.Bopping == true)
                {
                    this.NPC4.Image = global::IdleHacker.Properties.Resources.Farmer;
                }
            }

            if (PRG.ZackOwned == true)
            {
                if (PRG.Bopping == false)
                {
                    this.NPC5.Image = global::IdleHacker.Properties.Resources.Linux_Bop;
                }
                if (PRG.Bopping == true)
                {
                    this.NPC5.Image = global::IdleHacker.Properties.Resources.Linux;
                }
            }

            if (PRG.RoseOwned == true)
            {
                if (PRG.Bopping == false)
                {
                    this.NPC6.Image = global::IdleHacker.Properties.Resources.Kitten_Bop;
                }
                if (PRG.Bopping == true)
                {
                    this.NPC6.Image = global::IdleHacker.Properties.Resources.Kitten;
                }
            }


            if (PRG.SargeOwned == true)
            {
                if (PRG.Bopping == false)
                {
                    this.NPC8.Image = global::IdleHacker.Properties.Resources.Sarge_Bop;
                }
                if (PRG.Bopping == true)
                {
                    this.NPC8.Image = global::IdleHacker.Properties.Resources.Sarge;
                }
            }

            PRG.Bopping = !PRG.Bopping;
        }

        void DerrickSold(object sender, EventArgs e)
        {
            
            PRG.DerrickSales++;
            if (PRG.DerrickSales == 80 || PRG.DerrickSales == 160 || PRG.DerrickSales == 240 || PRG.DerrickSales == 320)
            {
                PRG.DerrickMultiply++;
            }
            GainCash();
        }

        void DeAndreSold(object sender, EventArgs e)
        {
            
            PRG.DeAndreSales++;
            if (PRG.DeAndreSales == 80 || PRG.DeAndreSales == 160 || PRG.DeAndreSales == 240 || PRG.DeAndreSales == 320)
            {
                PRG.DeAndreMultiply++;
            }
            GainCash();
        }

        void SamSold(object sender, EventArgs e)
        {

            PRG.SamSales++;
            if (PRG.SamSales == 80 || PRG.SamSales == 160 || PRG.SamSales == 240 || PRG.SamSales == 320)
            {
                PRG.SamMultiply++;
            }
            GainCash();
        }

        void MichealSold(object sender, EventArgs e)
        {

            PRG.MichealSales++;
            if (PRG.MichealSales == 80 || PRG.MichealSales == 160 || PRG.MichealSales == 240 || PRG.MichealSales == 320)
            {
                PRG.MichealMultiply++;
            }
            GainCash();
        }


        void MillerSold(object sender, EventArgs e)
        {

            PRG.MillerSales++;
            if (PRG.MillerSales == 80 || PRG.MillerSales == 160 || PRG.MillerSales == 240 || PRG.MillerSales == 320)
            {
                PRG.MillerMultiply++;
            }
            GainCash();
        }

        void ZackSold(object sender, EventArgs e)
        {

            PRG.ZackSales++;
            if (PRG.ZackSales == 80 || PRG.ZackSales == 160 || PRG.ZackSales == 240 || PRG.ZackSales == 320)
            {
                PRG.ZackMultiply++;
            }
            GainCash();
        }

        void RoseSold(object sender, EventArgs e)
        {

            PRG.RoseSales++;
            if (PRG.RoseSales == 80 || PRG.RoseSales == 160 || PRG.RoseSales == 240 || PRG.RoseSales == 320)
            {
                PRG.RoseMultiply++;
            }
            GainCash();
        }

        void SargeSold(object sender, EventArgs e)
        {
            PRG.SargeSales++;
            if (PRG.SargeSales == 80 || PRG.SargeSales == 160 || PRG.SargeSales == 240 || PRG.SargeSales == 320)
            {
                PRG.SargeMultiply++;
            }
            GainCash();
        }

        void EventTrigger(object sender, EventArgs e)
        {
            this.Text = "Event Triggered";
            int SelEvent = PRG.rand.Next(0, PRG.EventTotal);
            
            if (SelEvent == 1)
            {
               this.EventBox.Image = global::IdleHacker.Properties.Resources.ev_bitcoin;
              
            }

            if (SelEvent == 2)
            {
                this.EventBox.Image = global::IdleHacker.Properties.Resources.ev_crapcoin;

            }

        }



        void PlayerWantsMoney (object sender, EventArgs e) 
        {

                PRG.PlayerCash = PRG.PlayerCash + PRG.PlayerWorth;
            //make some idefntifier
            PRG.P1Presses++;
            PRG.P2Presses++;
                
                if (PRG.P1Presses >= 2)
                {
                    if (PRG.P1Bopping == false)
                    {
                        this.ExecA.Image = global::IdleHacker.Properties.Resources.ExecA_Bop;
                
                   
                    }
                    if (PRG.P1Bopping == true)
                    {
                        this.ExecA.Image = global::IdleHacker.Properties.Resources.ExecA;
                  
                    }

                    PRG.P1Presses = 0;
                    PRG.P1Bopping = !PRG.P1Bopping;

                    
                }

                if (PRG.P2Presses >= 2)
                {
                    if (PRG.P2Bopping == true)
                    {
                        this.Exec2.Image = global::IdleHacker.Properties.Resources.ExecB_Bop;
                        this.Exec2.Invalidate();
                    }
                    if (PRG.P2Bopping == false)
                    {
                        this.Exec2.Image = global::IdleHacker.Properties.Resources.ExecB;
                        this.Exec2.Invalidate();
                    }

                    PRG.P2Presses = 0;
                    PRG.P2Bopping = !PRG.P2Bopping;
                }


                if (PRG.TotalClicks == 100)
                {
                PRG.PlayerWorth = PRG.PlayerWorth + 6;
                }

                if (PRG.TotalClicks == 250)
                {
                    PRG.PlayerWorth = PRG.PlayerWorth + 12;
                }

            this.CashCounterLabel.Text = "Cash: $" + PRG.PlayerCash;
            this.CashCounterLabel.Invalidate();

        } // this is player hitting button to self gen cash

        void GainCash()
        {
            PRG.PlayerCash = PRG.PlayerCash + 
                (PRG.DerrickWorth * PRG.DerrickMultiply) +
                (PRG.DeAndreWorth * PRG.DeAndreMultiply) +
                (PRG.SamWorth * PRG.SamMultiply) +
                (PRG.MichealWorth * PRG.MichealMultiply) +
                (PRG.MillerWorth * PRG.MillerMultiply) +
                (PRG.ZackWorth * PRG.ZackMultiply) +
                (PRG.RoseWorth * PRG.RoseMultiply) +
                (PRG.SargeWorth * PRG.SargeMultiply) ;
            // yikes

            this.CashCounterLabel.Text = ("Cash: $" + PRG.PlayerCash);
            this.CashCounterLabel.Invalidate();
            

        }

        

    }


    public static class PRG
    {
        public static int PlayerCash = 0;
        public static int PlayerWorth = 2;
        public static int TotalHires = 0;
        public static int NextSalePrice = 0;
        public static int EventTotal = 2;

        public static System.Windows.Forms.Timer EmotionTimer = new System.Windows.Forms.Timer();
        public static System.Windows.Forms.Timer BopTimer = new System.Windows.Forms.Timer();
        public static bool Bopping = false;
        public static bool P1Bopping = false;
        public static bool P2Bopping = false;
        public static int P1Presses = 0;
        public static int P2Presses = 0;
        public static int TotalClicks = 0;

        public static Random rand = new Random();

        public static bool DerrickOwned = false;
        public static bool DeAndreOwned = false;
        public static bool SamOwned = false;
        public static bool MichealOwned = false;
        public static bool MillerOwned = false;
        public static bool RoseOwned = false;
        public static bool ZackOwned = false;
        public static bool SargeOwned = false;


        public static int DerrickWorth = 0;
        public static int DeAndreWorth = 0;
        public static int SamWorth = 0;
        public static int MichealWorth = 0;
        public static int MillerWorth = 0;
        public static int ZackWorth = 0;
        public static int RoseWorth = 0;
        public static int SargeWorth = 0;

        public static int DerrickMultiply = 1;
        public static int DeAndreMultiply = 1;
        public static int SamMultiply = 1;
        public static int MichealMultiply = 1;
        public static int MillerMultiply = 1;
        public static int ZackMultiply = 1;
        public static int RoseMultiply = 1;
        public static int SargeMultiply = 1;


        public static int DerrickSales = 0;
        public static int DeAndreSales = 0;
        public static int SamSales = 0;
        public static int MichealSales = 0;
        public static int MillerSales = 0;
        public static int ZackSales = 0;
        public static int RoseSales = 0;
        public static int SargeSales = 0;


        public static System.Windows.Forms.Timer EventTimer = new System.Windows.Forms.Timer();
        public static System.Windows.Forms.Timer DerrickTimer = new System.Windows.Forms.Timer();
        public static System.Windows.Forms.Timer DeAndreTimer = new System.Windows.Forms.Timer();
        public static System.Windows.Forms.Timer SamTimer = new System.Windows.Forms.Timer();
        public static System.Windows.Forms.Timer MichealTimer = new System.Windows.Forms.Timer();
        public static System.Windows.Forms.Timer MillerTimer = new System.Windows.Forms.Timer();
        public static System.Windows.Forms.Timer ZackTimer = new System.Windows.Forms.Timer();
        public static System.Windows.Forms.Timer RoseTimer = new System.Windows.Forms.Timer();
        public static System.Windows.Forms.Timer SargeTimer = new System.Windows.Forms.Timer();
    }
}