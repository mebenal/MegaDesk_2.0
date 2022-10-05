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
    public partial class DisplayQuote : EbenalForm
    {
        public DisplayQuote(Form returnTo) : base(returnTo)
        {
            InitializeComponent();
        }

        private void DisplayQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            EbenalForm_FormClosed(sender, e);
        }
    }
}
