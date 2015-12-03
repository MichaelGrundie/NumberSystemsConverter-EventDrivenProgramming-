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
    public partial class frmMethod : Form 
    {
        private readonly frmNSC _frmNSC;//references the main form.
        public frmMethod(frmNSC frmNsc)
        {
            _frmNSC = frmNsc;
            InitializeComponent();
            this.ControlBox = false;//Disable the control box


            switch (_frmNSC.checkRef)// Finds out which conversion is being applied.
            {
                case "BtD":
                    rtbBtD.Visible = true;  //this switch compares checkRef to find
                    break;                  //out which conversion is being applied
                                            //it uses this information to show the 
                case "DtB":                 //appropriate method rich text box.
                    rtbDtB.Visible = true;
                    break;
                case "DtH":
                    rtbDtH.Visible = true;
                    break;
                case "HtD":
                    rtbHtD.Visible = true;
                    break;
                case "HtB":
                    rtbHtB.Visible = true;
                    break;
                case "BtH":
                    rtbBtH.Visible = true;
                    break;

            }
        }

        private void frmMethod_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmNSC frm = new frmNSC();
            _frmNSC.btnMethod.Enabled = true;//re-enables the method button
            this.Close();//closes the method form
        }
    }
}
