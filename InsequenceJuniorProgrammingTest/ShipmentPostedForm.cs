using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsequenceJuniorProgrammingTest
{
    public partial class ShipmentPostedForm : Form
    {
        public ShipmentPostedForm(string shipmentLabelText, string siteLabelText, string[] containerLabelText)
        {
            InitializeComponent();
            this.shipmentLabel.Text += shipmentLabelText;
            this.siteLabel.Text += siteLabelText;
            foreach (string i in containerLabelText)
            {
                this.containerTextBox.Text += i;
                this.containerTextBox.Text += Environment.NewLine;
            }
        }

        private void shipmentPostedForm_Load(object sender, EventArgs e)
        {

        }
    }
}
