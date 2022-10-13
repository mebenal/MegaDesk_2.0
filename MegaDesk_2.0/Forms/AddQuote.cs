using MegaDesk_2_0.Classes;
using MegaDesk_Ebenal.Forms;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Ebenal
{
    public partial class AddQuote : EbenalForm
    {
        public AddQuote(Form returnTo, bool read = false, DeskQuote deskQuote = null) : base(returnTo)
        {
            InitializeComponent();

            if (!read)
            {
                InitializeChangable();
            }
            else
            {
                InitializeReadonly(deskQuote);
            }
            
        }
        private void InitializeChangable()
        {
            // Stolen from: https://stackoverflow.com/questions/906899/binding-an-enum-to-a-winforms-combo-box-and-then-setting-it
            comboBox_DeliveryType.DataSource = Enum.GetValues(typeof(DeliveryType))
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
            comboBox_DeliveryType.DisplayMember = "Description";
            comboBox_DeliveryType.ValueMember = "value";

            /* To access: 
             * Enum.TryParse<DeliveryType>(comboBox_SurfaceMaterial.SelectedValue.ToString(), out MyEnum proc);
             * int nValue = (int)proc;
            */

            comboBox_SurfaceMaterial.DataSource = Enum.GetValues(typeof(DeskMaterials));
        }

        private void InitializeReadonly(DeskQuote deskQuote)
        {
            textBox_CustomerName.Text = deskQuote.CustomerName;
            numericUpDown_Depth.Value = deskQuote.Desk.Depth;
            numericUpDown_Width.Value = deskQuote.Desk.Width;
            numericUpDown_NumberOfDrawers.Value = deskQuote.Desk.NumberOfDrawers;
            comboBox_SurfaceMaterial.Text = deskQuote.Desk.DeskMaterial.ToString();
            comboBox_DeliveryType.Text = (Attribute.GetCustomAttribute(
                        deskQuote.DeliveryType.GetType().GetField(deskQuote.DeliveryType.ToString()),
                        typeof(DescriptionAttribute)) as DescriptionAttribute).Description;

            textBox_CustomerName.ReadOnly = true;
            textBox_CustomerName.Enabled = false;
            numericUpDown_Depth.ReadOnly = true;
            numericUpDown_Depth.Enabled = false;
            numericUpDown_Width.ReadOnly = true;
            numericUpDown_Width.Enabled = false;
            numericUpDown_NumberOfDrawers.ReadOnly = true;
            numericUpDown_NumberOfDrawers.Enabled = false;
            comboBox_SurfaceMaterial.Enabled = false;
            comboBox_DeliveryType.Enabled = false;

            button_GetQuote.Hide();
            Point cancelButtonLoc = button_Cancel.Location;
            cancelButtonLoc.X -= 100;
            button_Cancel.Location = cancelButtonLoc;
            button_Cancel.Text = "Main Menu";
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

        private void button_GetQuote_Click(object sender, EventArgs e)
        {
            Desk newDesk = new Desk(
                numericUpDown_Depth.Value,
                numericUpDown_Width.Value,
                (DeskMaterials)comboBox_SurfaceMaterial.SelectedItem,
                (int)numericUpDown_NumberOfDrawers.Value);

            Enum.TryParse<DeliveryType>(comboBox_DeliveryType.SelectedValue.ToString(), out DeliveryType deliveryType);
            DeskQuote deskQuote = new DeskQuote(
                textBox_CustomerName.Text,
                deliveryType,
                newDesk);

            ManageQuotes.AppendQuote(deskQuote);
            
            Form showQuote = new AddQuote(_returnTo, read: true, deskQuote: deskQuote);
            showQuote.Show(_returnTo);
            Close(closeOn : showQuote);
        }

        void Close(Form closeOn = null)
        {
            if (closeOn == null)
            {
                base.Close();
            } 
            else
            {
                Hide();
                closeOn.FormClosed += new System.Windows.Forms.FormClosedEventHandler(AddQuote_FormClosed);
            }
        }
    }
}
