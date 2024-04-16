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
            if (countryPicker.SelectedIndex == -1)
            {
                resultLabel.Text = "Please select your country.";
                return;
            }

            string selectedCountry = countryPicker.SelectedItem.ToString();
            DateTime birthdate = birthdatePicker.Date;
            DateTime now = DateTime.Now;
            int legalDrinkingAge = GetLegalDrinkingAge(selectedCountry);
            DateTime legalAgeDate = birthdate.AddYears(legalDrinkingAge);

            int yearsUntilLegal = legalAgeDate.Year - now.Year;
            if (now > legalAgeDate)
            {
                resultLabel.Text = "You are already old enough to buy alcohol!";
            }
            else if (yearsUntilLegal == 0)
            {
                resultLabel.Text = "You will be old enough to buy alcohol this year!";
            }
            else
            {
                resultLabel.Text = $"Years until you can legally buy alcohol in {selectedCountry}: {yearsUntilLegal}";
            }
        }

        private int GetLegalDrinkingAge(string country)
        {
            switch (country)
            {
                case "United States": return 21;
                case "Canada": return 19;  // Note: This is variable by province, most are 19
                case "United Kingdom": return 18;
                case "Germany": return 16; // Beer and wine, 18 for spirits
                case "Japan": return 20;
                default: return 18;
            }
        }
    }

}
