namespace AlcoholPurchaseAge
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            birthdatePicker.Date = DateTime.Now;
        }

        private void OnCheckClicked(object sender, EventArgs e)
        {
            DateTime birthdate = birthdatePicker.Date;
            DateTime dateOf21stBirthday = birthdate.AddYears(21);
            int yearsUntil21 = dateOf21stBirthday.Year - DateTime.Now.Year;

            if (DateTime.Now > dateOf21stBirthday)
            {
                resultLabel.Text = "You are already old enough to buy alcohol!";
            }
            else if (yearsUntil21 == 0)
            {
                resultLabel.Text = "You will turn 21 this year!";
            }
            else
            {
                resultLabel.Text = $"Years until you can legally buy alcohol: {yearsUntil21}";
            }
        }
    }

}
