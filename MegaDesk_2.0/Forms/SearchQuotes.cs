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
            InitializeComponent();
            data = ManageQuotes.GetQuotes();
            

            MaterialComboBox.DataSource = Enum.GetValues(typeof(DeskMaterials));
            MaterialComboBox.SelectedIndex = -1;
        }

        private void MaterialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MaterialComboBox.SelectedIndex < 0)
                SearchQuotes_DisplayData();
            else
                SearchQuotes_DisplayData((DeskMaterials)Enum.Parse(typeof(DeskMaterials), MaterialComboBox.Text));
        }

        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            EbenalForm_FormClosed(sender, e);
        }

        private void SearchQuotes_DisplayData()
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
        private void SearchQuotes_DisplayData(DeskMaterials material)
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
                .Where(d => d.Material == material)
                .ToList();
        }
    }
}
