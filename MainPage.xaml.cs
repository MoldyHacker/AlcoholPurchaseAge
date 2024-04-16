namespace AlcoholPurchaseAge
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCheckClicked(object sender, EventArgs e)
        {
            if (int.TryParse(ageEntry.Text, out int age))
            {
                if (age <= 21)
                {
                    int yearsLeft = 21 - age;
                    resultLabel.Text = $"Years until you can legally buy alcohol: {yearsLeft}";
                }
                else
                {
                    resultLabel.Text = "You are already old enough to buy alcohol!";
                }
            }
            else
            {
                resultLabel.Text = "Please enter a valid age.";
            }
        }
    }

}
