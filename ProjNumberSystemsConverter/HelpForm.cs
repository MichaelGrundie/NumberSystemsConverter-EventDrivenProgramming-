using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjNumberSystemsConverter
{
    public partial class HelpForm : Form
    {
        private readonly frmNSC _frmNSC;//Refernces the main form.

        public HelpForm(frmNSC frmNsc)
        {
            _frmNSC = frmNsc;
            InitializeComponent();
            this.ControlBox = false;//disables the control box
        }

        private void btnCloseHelp_Click(object sender, EventArgs e)//close button
        {
            frmNSC frm = new frmNSC();
            _frmNSC.btnHelp.Enabled = true;//re-enables the help button
            this.Close();//closes help form
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {

        }
    }
}
