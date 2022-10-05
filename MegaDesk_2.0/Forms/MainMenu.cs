using MegaDesk_Ebenal.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Ebenal
{
    public partial class MainMenu : EbenalForm
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void OpenForm(Form formToOpen)
        {
            formToOpen.Show(this);
            Hide();
        }

        private void AddNewQuote_Click(object sender, EventArgs e)
        {
            OpenForm(new AddQuote(this));
        }

        private void ViewQuotes_Click(object sender, EventArgs e)
        {
            OpenForm(new ViewAllQuotes(this));
        }

        private void SearchQuotes_Click(object sender, EventArgs e)
        {
            OpenForm(new SearchQuotes(this));
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
