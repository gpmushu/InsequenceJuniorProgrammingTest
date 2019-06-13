namespace InsequenceJuniorProgrammingTest
{
    partial class ShipmentPostedForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.shipmentLabel = new System.Windows.Forms.Label();
            this.siteLabel = new System.Windows.Forms.Label();
            this.containerTextBox = new System.Windows.Forms.TextBox();
            this.containerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shipmentLabel
            // 
            this.shipmentLabel.AutoSize = true;
            this.shipmentLabel.Location = new System.Drawing.Point(12, 9);
            this.shipmentLabel.Name = "shipmentLabel";
            this.shipmentLabel.Size = new System.Drawing.Size(68, 13);
            this.shipmentLabel.TabIndex = 0;
            this.shipmentLabel.Text = "ShipmentID: ";
            // 
            // siteLabel
            // 
            this.siteLabel.AutoSize = true;
            this.siteLabel.Location = new System.Drawing.Point(12, 22);
            this.siteLabel.Name = "siteLabel";
            this.siteLabel.Size = new System.Drawing.Size(59, 13);
            this.siteLabel.TabIndex = 1;
            this.siteLabel.Text = "Site Name:";
            // 
            // containerTextBox
            // 
            this.containerTextBox.Location = new System.Drawing.Point(15, 51);
            this.containerTextBox.Multiline = true;
            this.containerTextBox.Name = "containerTextBox";
            this.containerTextBox.ReadOnly = true;
            this.containerTextBox.Size = new System.Drawing.Size(100, 198);
            this.containerTextBox.TabIndex = 3;
            // 
            // containerLabel
            // 
            this.containerLabel.AutoSize = true;
            this.containerLabel.Location = new System.Drawing.Point(12, 35);
            this.containerLabel.Name = "containerLabel";
            this.containerLabel.Size = new System.Drawing.Size(71, 13);
            this.containerLabel.TabIndex = 4;
            this.containerLabel.Text = "ContainerIDs:";
            // 
            // ShipmentPostedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 261);
            this.Controls.Add(this.containerLabel);
            this.Controls.Add(this.containerTextBox);
            this.Controls.Add(this.siteLabel);
            this.Controls.Add(this.shipmentLabel);
            this.Name = "ShipmentPostedForm";
            this.Text = "Shipment Posted";
            this.Load += new System.EventHandler(this.shipmentPostedForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label shipmentLabel;
        private System.Windows.Forms.Label siteLabel;
        private System.Windows.Forms.TextBox containerTextBox;
        private System.Windows.Forms.Label containerLabel;
    }
}