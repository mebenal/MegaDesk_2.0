using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Ebenal.Forms
{
    public partial class EbenalForm : Form
    {
        protected Form _returnTo;

        public EbenalForm(Form returnTo)
        {
            _returnTo = returnTo;
        }
        public EbenalForm() {}

        protected void EbenalForm_FormClosed(object sender, EventArgs e)
        {
            _returnTo.Show();
        }
    }
}
