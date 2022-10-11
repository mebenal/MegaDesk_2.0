using MegaDesk_2_0.Classes;
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
    public partial class SearchQuotes : EbenalForm
    {
        List<DeskQuote> data;

        public SearchQuotes(Form returnTo) : base(returnTo)
        {
            data = ManageQuotes.GetQuotes();
            InitializeComponent();

            MaterialComboBox.DataSource = Enum.GetValues(typeof(DeskMaterials));
        
            SearchQuotes_DisplayData();
        }

        private void MaterialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchQuotes_DisplayData();
        }

        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            EbenalForm_FormClosed(sender, e);
        }

        private void SearchQuotes_DisplayData()
        {
            dataView.Rows.Clear();
            dataView.Columns.Clear();
            foreach (string header in ManageQuotes.QuoteHeaders)
            {
                dataView.Columns.Add(header, header);
            }
            foreach (DeskQuote quote in data)
            {
                if(quote.Desk.DeskMaterial.ToString() == MaterialComboBox.Text)
                dataView.Rows.Add(quote.Stringify());
            }
        }
    }
}
