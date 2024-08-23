using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aleksei_Spiridonov_OOP_Final_Project
{

    enum AdminFormModes
    {
        VIEW,
        ADD,
        EDIT
    }

    public partial class frmAdmin : Form
    {
        AdminFormModes currentMode = AdminFormModes.VIEW;

        string currencyNameBeingEdited = "";
        string lastNameShowedBeforeAdding = "";

        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            updateElementsAvailability();
            // Needed to syncronize different windows that can affect the database (for example if admin changes it this form immediately recalculates)
            CurrencyStorageAccess.UpdateEvent += OnDatabaseUpdated;
            FormClosed += (sender, e) => { CurrencyStorageAccess.UpdateEvent -= OnDatabaseUpdated; };
            FormClosed += (a, b) => { CurrencyStorageAccess.SaveData(); };
        }


        public void OnDatabaseUpdated()
        {
            if (currentMode == AdminFormModes.VIEW)
            {
                validateCurrentCurrencyViewMode();
                updateElementsAvailability();
            }
            else if (currentMode == AdminFormModes.ADD)
            {
                updateElementsAvailability();
            }
            else if (currentMode == AdminFormModes.EDIT)
            {
                if (CurrencyStorageAccess.GetCurrencyByName(currencyNameBeingEdited) == null)
                {
                    // cannot get
                    currentMode = AdminFormModes.VIEW;
                    currencyNameBeingEdited = "";
                    validateCurrentCurrencyViewMode();
                }
                updateElementsAvailability();
            }
        }

        private void validateCurrentCurrencyViewMode()
        {
            int? index = CurrencyStorageAccess.GetCurrencyIndexByName(nameInputFIeld.Text);
            if (index != null)
            {
                Currency currency = CurrencyStorageAccess.GetCurrency(index.Value);
                valueInputField.Text = currency.value.ToString();
                countryInputField.Text = currency.country;
                positionLabel.Text = "Currency page: " + (1 + index.Value).ToString();
            }
            else
            {
                nameInputFIeld.Text = "";
                valueInputField.Text = "";
                countryInputField.Text = "";
                positionLabel.Text = "";
            }
        }

        private bool CanSaveCurrencyAddMode()
        {
            if (currentMode == AdminFormModes.ADD)
            {
                if (nameInputFIeld.Text == "")
                {
                    return false;
                }
                double value;
                if (!double.TryParse(valueInputField.Text, out value))
                {
                    return false;
                }
                if (countryInputField.Text == "")
                {
                    return false;
                }
                int? foundIndexSameName = CurrencyStorageAccess.GetCurrencyIndexByName(nameInputFIeld.Text);
                return foundIndexSameName == null;
            }
            return false;
        }

        private bool CanSaveCurrencyEditMode()
        {
            if (currentMode == AdminFormModes.EDIT)
            {
                if (nameInputFIeld.Text == "")
                {
                    return false;
                }
                double value;
                if (!double.TryParse(valueInputField.Text, out value))
                {
                    return false;
                }
                if (countryInputField.Text == "")
                {
                    return false;
                }
                int? foundOld = CurrencyStorageAccess.GetCurrencyIndexByName(currencyNameBeingEdited);
                return foundOld != null;
            }
            return false;
        }

        private void updateElementsAvailability()
        {
            if (currentMode == AdminFormModes.VIEW)
            {
                validateCurrentCurrencyViewMode();
                int currenciesNumber = CurrencyStorageAccess.GetAvailableCurrenciesCount();

                Currency? firstCurrency = null;
                Currency? lastCurrency = null;

                if (currenciesNumber > 0)
                {
                    firstCurrency = CurrencyStorageAccess.GetCurrency(0);
                    lastCurrency = CurrencyStorageAccess.GetCurrency(currenciesNumber - 1);
                }

                addButton.Enabled = true;
                saveButton.Enabled = false;
                cancelButton.Enabled = false;
                nameInputFIeld.Enabled = false;
                valueInputField.Enabled = false;
                countryInputField.Enabled = false;
                if (nameInputFIeld.Text == "")
                {
                    // nothing is selected
                    deleteButton.Enabled = false;
                    editButton.Enabled = false;
                    firstButton.Enabled = CurrencyStorageAccess.GetAvailableCurrenciesCount() > 0;
                    previousButton.Enabled = false;
                    nextButton.Enabled = false;
                    lastButton.Enabled = CurrencyStorageAccess.GetAvailableCurrenciesCount() > 1;
                }
                else
                {
                    // In this case we have one valid existing currency selected, so there are first and last defined
                    deleteButton.Enabled = true;
                    editButton.Enabled = true;
                    bool selectedFirst = nameInputFIeld.Text == firstCurrency.name;
                    bool selectedLast = nameInputFIeld.Text == lastCurrency.name;
                    firstButton.Enabled = !selectedFirst;
                    previousButton.Enabled = !selectedFirst;
                    nextButton.Enabled = !selectedLast;
                    lastButton.Enabled = !selectedLast;
                }
            }
            else if (currentMode == AdminFormModes.ADD)
            {
                addButton.Enabled = false;
                saveButton.Enabled = CanSaveCurrencyAddMode();
                cancelButton.Enabled = true;
                nameInputFIeld.Enabled = true;
                valueInputField.Enabled = true;
                countryInputField.Enabled = true;
                deleteButton.Enabled = false;
                editButton.Enabled = false;
                firstButton.Enabled = false;
                previousButton.Enabled = false;
                nextButton.Enabled = false;
                lastButton.Enabled = false;
            }
            else if (currentMode == AdminFormModes.EDIT)
            {
                addButton.Enabled = false;
                saveButton.Enabled = CanSaveCurrencyEditMode();
                cancelButton.Enabled = true;
                nameInputFIeld.Enabled = true;
                valueInputField.Enabled = true;
                countryInputField.Enabled = true;
                deleteButton.Enabled = false;
                editButton.Enabled = false;
                firstButton.Enabled = false;
                previousButton.Enabled = false;
                nextButton.Enabled = false;
                lastButton.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            updateElementsAvailability();
        }

        private void setView(Currency? currency)
        {
            if (currency != null)
            {
                nameInputFIeld.Text = currency.name;
                countryInputField.Text = currency.country;
                valueInputField.Text = currency.value.ToString();
            }
            else
            {
                nameInputFIeld.Text = "";
                countryInputField.Text = "";
                valueInputField.Text = "";
            }
        }


        private void firstButton_Click(object sender, EventArgs e)
        {
            if (currentMode == AdminFormModes.VIEW && CurrencyStorageAccess.GetAvailableCurrenciesCount() > 0)
            {
                setView(CurrencyStorageAccess.GetCurrency(0));
            }
            updateElementsAvailability();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (CurrencyStorageAccess.GetAvailableCurrenciesCount() < 2)
            {
                return;
            }
            if (currentMode != AdminFormModes.VIEW)
            {
                return;
            }
            validateCurrentCurrencyViewMode();
            if (nameInputFIeld.Text == "")
            {
                return;
            }
            int? index = CurrencyStorageAccess.GetCurrencyIndexByName(nameInputFIeld.Text);
            if (index == null)
            {
                return;
            }
            if (index.Value == 0)
            {
                return;
            }
            setView(CurrencyStorageAccess.GetCurrency(index.Value - 1));
            updateElementsAvailability();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (CurrencyStorageAccess.GetAvailableCurrenciesCount() < 2)
            {
                return;
            }
            if (currentMode != AdminFormModes.VIEW)
            {
                return;
            }
            validateCurrentCurrencyViewMode();
            if (nameInputFIeld.Text == "")
            {
                return;
            }
            int? index = CurrencyStorageAccess.GetCurrencyIndexByName(nameInputFIeld.Text);
            if (index == null)
            {
                return;
            }
            if (index.Value == CurrencyStorageAccess.GetAvailableCurrenciesCount() - 1)
            {
                return;
            }
            setView(CurrencyStorageAccess.GetCurrency(index.Value + 1));
            updateElementsAvailability();
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            if (currentMode == AdminFormModes.VIEW && CurrencyStorageAccess.GetAvailableCurrenciesCount() > 0)
            {
                setView(CurrencyStorageAccess.GetCurrency(CurrencyStorageAccess.GetAvailableCurrenciesCount() - 1));
            }
            updateElementsAvailability();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (currentMode == AdminFormModes.VIEW)
            {
                currentMode = AdminFormModes.ADD;
                lastNameShowedBeforeAdding = nameInputFIeld.Text;
                nameInputFIeld.Text = "";
                valueInputField.Text = "";
                countryInputField.Text = "";
                nameInputFIeld.Enabled = true;
                valueInputField.Enabled = true;
                countryInputField.Enabled = true;
            }
            updateElementsAvailability();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (currentMode != AdminFormModes.VIEW)
            {
                return;
            }
            validateCurrentCurrencyViewMode();
            if (nameInputFIeld.Text != "")
            {
                int? index = CurrencyStorageAccess.GetCurrencyIndexByName(nameInputFIeld.Text);
                if (index != null)
                {
                    CurrencyStorageAccess.RemoveCurrency(index.Value);
                    if (index.Value > 0)
                    {
                        setView(CurrencyStorageAccess.GetCurrency(index.Value - 1));
                    }
                    else if (CurrencyStorageAccess.GetAvailableCurrenciesCount() > 0)
                    {
                        setView(CurrencyStorageAccess.GetCurrency(0));
                    }
                    else
                    {
                        setView(null);
                    }
                }
            }
            updateElementsAvailability();
        }

        private void valueInputField_TextChanged(object sender, EventArgs e)
        {

            updateElementsAvailability();
        }

        private void countryInputField_TextChanged(object sender, EventArgs e)
        {

            updateElementsAvailability();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (currentMode == AdminFormModes.VIEW)
            {
                validateCurrentCurrencyViewMode();
                if (nameInputFIeld.Text != "")
                {
                    currentMode = AdminFormModes.EDIT;
                    nameInputFIeld.Enabled = true;
                    valueInputField.Enabled = true;
                    countryInputField.Enabled = true;
                    currencyNameBeingEdited = nameInputFIeld.Text;
                }
            }
            updateElementsAvailability();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (currentMode == AdminFormModes.ADD)
            {
                if (CanSaveCurrencyAddMode())
                {
                    CurrencyStorageAccess.AddCurrency(new Currency(
                        nameInputFIeld.Text,
                        countryInputField.Text,
                        double.Parse(valueInputField.Text)
                        ));
                    currentMode = AdminFormModes.VIEW;
                    updateElementsAvailability();
                    CurrencyStorageAccess.UpdateEvent();
                }
            }
            else if (currentMode == AdminFormModes.EDIT)
            {

                if (CanSaveCurrencyEditMode())
                {
                    Currency? instance = CurrencyStorageAccess.GetCurrencyByName(currencyNameBeingEdited);
                    if (instance != null)
                    {
                        instance.name = nameInputFIeld.Text;
                        instance.country = countryInputField.Text;
                        instance.value = double.Parse(valueInputField.Text);
                        currencyNameBeingEdited = "";
                        currentMode = AdminFormModes.VIEW;
                        updateElementsAvailability();
                        CurrencyStorageAccess.UpdateEvent();
                    }
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (currentMode == AdminFormModes.ADD)
            {
                currentMode = AdminFormModes.VIEW;
                nameInputFIeld.Text = lastNameShowedBeforeAdding;
                validateCurrentCurrencyViewMode();
                updateElementsAvailability();
            } else if (currentMode == AdminFormModes.EDIT)
            {
                currentMode = AdminFormModes.VIEW;
                nameInputFIeld.Text = currencyNameBeingEdited;
                validateCurrentCurrencyViewMode();
                updateElementsAvailability();
            }
        }
    }
}