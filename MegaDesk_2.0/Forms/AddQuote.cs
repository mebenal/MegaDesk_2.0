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
    public partial class AddQuote : EbenalForm
    {
        public AddQuote(Form returnTo) : base(returnTo)
        {
            InitializeComponent();


            // Stolen from: https://stackoverflow.com/questions/906899/binding-an-enum-to-a-winforms-combo-box-and-then-setting-it
            comboBox_Delivery.DataSource = Enum.GetValues(typeof(DeliveryType))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(
                        value.GetType().GetField(value.ToString()),
                        typeof(DescriptionAttribute)) as DescriptionAttribute
                    ).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();
            comboBox_Delivery.DisplayMember = "Description";
            comboBox_Delivery.ValueMember = "value";

            /* To access: 
             * Enum.TryParse<DeliveryType>(comboBox_SurfaceMaterial.SelectedValue.ToString(), out MyEnum proc);
             * int nValue = (int)proc;
            */

            comboBox_SurfaceMaterial.DataSource = Enum.GetValues(typeof(DeskMaterials));
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            EbenalForm_FormClosed(sender, e);
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            EbenalForm_FormClosed(sender, e);
            Close();
        }
    }
}
