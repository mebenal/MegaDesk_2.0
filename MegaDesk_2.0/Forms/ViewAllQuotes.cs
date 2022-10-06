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
using Newtonsoft.Json;


namespace MegaDesk_Ebenal
{
    public partial class ViewAllQuotes : EbenalForm
    {
        List<DeskQuote> data;

        public ViewAllQuotes(Form returnTo) : base(returnTo)
        {
            data = ManageQuotes.GetQuotes();
            InitializeComponent();
            ViewAllQuotes_DisplayData();
        }

        private void ViewAllQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            EbenalForm_FormClosed(sender, e);
        }

        private void ViewAllQuotes_DisplayData()
        {
            for(int i = 0; i < ManageQuotes.QuoteHeaders.Length; i++)
            {
                dataView.Columns.Add(ManageQuotes.QuoteHeaders[i], ManageQuotes.QuoteHeaders[i]);
            }
            foreach(DeskQuote quote in data)
            {
                dataView.Rows.Add(quote.Stringify());
            }
        }
    }
}
