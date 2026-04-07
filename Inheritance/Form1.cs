namespace Inheritance
{
    public partial class Form1 : Form
    {
        List<Drink> drinksList = new List<Drink>();
        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.drinksList.Clear();
            var rnd = new Random();
            for (var i = 0; i<10; i++) {
                switch (rnd.Next() % 3) 
                {
                    case 0: 
                        this.drinksList.Add(new Juice());
                        break;
                    case 1: 
                        this.drinksList.Add(new Soda());
                        break;
                    case 2: 
                        this.drinksList.Add(new Alcohol());
                        break;
                }
            }
            ShowInfo();
        }

        private void ShowInfo()
        {
            int juiceCount = 0;
            int sodaCount = 0;
            int alcoholCount = 0;

            foreach(var drink in this.drinksList) {
                if(drink is Juice) {
                    juiceCount++;
                } else if(drink is Soda) {
                    sodaCount++;
                } else if(drink is Alcohol) {
                    alcoholCount++;
                }
            }
            txtInfo.Text = "Сок\tСода\tАлко";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", juiceCount, sodaCount, alcoholCount);
        }
    }
}
