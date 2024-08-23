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
    public partial class frmMain : Form
    {
        bool started = false;

        public frmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            FormClosed += (a, b) => { CurrencyStorageAccess.SaveData(); };
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            frmChange childForm = new frmChange();
            childForm.Show();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CurrencyStorageAccess.LoadData();
            UpdateButtonsAvailability();
            CurrencyStorageAccess.UpdateEvent += UpdateButtonsAvailability;
        }

        private void UpdateButtonsAvailability()
        {
            int availableCurrencies = CurrencyStorageAccess.GetAvailableCurrenciesCount();
            changeButton.Enabled = started && availableCurrencies > 0;
            adminButton.Enabled = started;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            started = true;
            UpdateButtonsAvailability();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void adminButton_Click_1(object sender, EventArgs e)
        {
            frmAdmin form = new frmAdmin();
            form.Show();
        }
    }
}
