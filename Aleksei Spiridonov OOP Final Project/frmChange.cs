namespace Aleksei_Spiridonov_OOP_Final_Project
{
    public partial class frmChange : Form
    {
        public frmChange()
        {
            InitializeComponent();
        }

        private void frmChange_Load(object sender, EventArgs e)
        {
            setUpCurrencySelectionBox();
            updateCurrencyInformation();
            updateResult(true);

            // Needed to syncronize different windows that can affect the database (for example if admin changes it this form immediately recalculates)
            CurrencyStorageAccess.UpdateEvent += OnDatabaseUpdated;
            FormClosed += (sender, e) => {
                CurrencyStorageAccess.UpdateEvent -= OnDatabaseUpdated;
                CurrencyStorageAccess.SaveData();
            };
        }


        public void OnDatabaseUpdated()
        {
            if (parseSelectedCurrency() == null)
            {
                setUpCurrencySelectionBox();
            }
            updateCurrencyInformation();
            updateResult(true);
        }

        private void setUpCurrencySelectionBox()
        {
            currencySelectionComboBox.Items.Clear();
            int availableCurrencies = CurrencyStorageAccess.GetAvailableCurrenciesCount();
            currencySelectionComboBox.Text = "Select a Currency...";
            for (int i = 0; i < availableCurrencies; i++)
            {
                currencySelectionComboBox.Items.Add(CurrencyStorageAccess.GetCurrency(i).name);
            }
        }

        private void updateCurrencyInformation()
        {
            Currency? currency = parseSelectedCurrency();
            if (currency != null)
            {
                labelToDollar.Text = $"1 US Dollar = {round(currency.value)} {currency.name} (s)";
                labelFromDollar.Text = $"1 {currency.name} = {round(1 / currency.value)} US Dollar (s)";
            }
            else
            {

                labelToDollar.Text = "";
                labelFromDollar.Text = "";
            }
        }

        private void updateResult(bool clearInCaseOfFailure)
        {

            Currency? selectedCurrency = parseSelectedCurrency();
            double? selectedAmount = parseAmount();
            if (selectedCurrency != null && selectedAmount != null)
            {
                string resultCurrencyName = toDollarButton.Checked ? "US Dollar (s)" : $"{selectedCurrency.name} (s)";
                string sourceCurrencyName = !toDollarButton.Checked ? "US Dollar (s)" : $"{selectedCurrency.name} (s)";
                double multiplier = toDollarButton.Checked ? 1 / selectedCurrency.value : selectedCurrency.value;
                double result = multiplier * selectedAmount.Value;
                exchengeResultLabel.Text = $"{round(selectedAmount.Value)} {sourceCurrencyName} = {round(result)} {resultCurrencyName}";
            }
            else if (clearInCaseOfFailure)
            {
                exchengeResultLabel.Text = "";
            }
        }

        private static string round(double val)
        {
            int roundingDigits = 4;
            return Math.Round(val, roundingDigits).ToString();
        }

        // Using the dinamical approach here to prevent situations when the global data changes from another place
        private Currency? parseSelectedCurrency()
        {
            for (int i = 0; i < CurrencyStorageAccess.GetAvailableCurrenciesCount(); i++)
            {
                Currency currency = CurrencyStorageAccess.GetCurrency(i);
                if (currency.name == currencySelectionComboBox.Text)
                {
                    return currency;
                }
            }
            return null;
        }

        private double? parseAmount()
        {
            double result;
            bool sucess = double.TryParse(amountTextBox.Text, out result);
            if (!sucess)
            {
                return null;
            }
            else
            {
                return result;
            }
        }

        private void currencySelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateCurrencyInformation();
        }

        private void exchangeButton_Click(object sender, EventArgs e)
        {

            updateResult(false);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            amountTextBox.Text = "";
            setUpCurrencySelectionBox();
            updateCurrencyInformation();
            toDollarButton.Select();
            updateResult(true);
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
