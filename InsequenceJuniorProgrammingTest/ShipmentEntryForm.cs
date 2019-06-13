using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InsequenceJuniorProgrammingTest
{
    public partial class ShipmentEntryForm : Form
    {
        public string shipmentID;
        public string siteName;
        public string[] containerID;

        public ShipmentEntryForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void postShipmentButton_Click(object sender, EventArgs e)
        {
            string siteName = siteTextBox.Text;

            if (shipmentTextBox.Text == "")
            {
                MessageBox.Show("Please input a ShipmentID");
                Application.Restart();
            }

            else
            {
                string shipmentID = shipmentTextBox.Text;

                if (containerTextBox.Text == "")
                {
                    MessageBox.Show("Please input a ContainerID");
                    Application.Restart();
                }

                else if (numericCheckBox.Checked == true)
                {
                    int i;
                    foreach (string m in containerTextBox.Text.Split(Environment.NewLine.ToArray()))
                    {
                        if (!int.TryParse(m, out i))
                        {
                            MessageBox.Show("Please input only numbers");
                            Application.Restart();
                        }
                    }

                    string[] containerID = containerTextBox.Text.Split(Environment.NewLine.ToArray());
                    Form shipmentPostedForm = new ShipmentPostedForm(shipmentID, siteName, containerID);
                    shipmentPostedForm.Show();
                    
                }

                else
                {
                    string[] containerID = containerTextBox.Text.Split(Environment.NewLine.ToArray());
                    Form shipmentPostedForm = new ShipmentPostedForm(shipmentID, siteName, containerID);
                    shipmentPostedForm.Show();
                }
            }
        }

        private void ShipmentEntryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
