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
            dataView.DataSource = data
               .Select((d) => new
               {
                   QuoteDate = d.QuoteDate,
                   CustomerName = d.CustomerName,
                   Width = d.Desk.Width,
                   Depth = d.Desk.Depth,
                   Drawers = d.Desk.NumberOfDrawers,
                   Material = d.Desk.DeskMaterial,
                   DeliveryType = d.DeliveryType,
                   Price = d.QuoteAmount,
               })
               .ToList();
        }
    }
}
