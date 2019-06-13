namespace InsequenceJuniorProgrammingTest
{
    partial class ShipmentEntryForm
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
            this.shipmentLabel = new System.Windows.Forms.Label();
            this.siteLabel = new System.Windows.Forms.Label();
            this.containerLabel = new System.Windows.Forms.Label();
            this.requiredLabel = new System.Windows.Forms.Label();
            this.shipmentTextBox = new System.Windows.Forms.TextBox();
            this.siteTextBox = new System.Windows.Forms.TextBox();
            this.numericCheckBox = new System.Windows.Forms.CheckBox();
            this.postShipmentButton = new System.Windows.Forms.Button();
            this.containerTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // shipmentLabel
            // 
            this.shipmentLabel.AutoSize = true;
            this.shipmentLabel.Location = new System.Drawing.Point(26, 24);
            this.shipmentLabel.Name = "shipmentLabel";
            this.shipmentLabel.Size = new System.Drawing.Size(72, 13);
            this.shipmentLabel.TabIndex = 5;
            this.shipmentLabel.Text = "*Shipment ID:";
            // 
            // siteLabel
            // 
            this.siteLabel.AutoSize = true;
            this.siteLabel.Location = new System.Drawing.Point(26, 63);
            this.siteLabel.Name = "siteLabel";
            this.siteLabel.Size = new System.Drawing.Size(59, 13);
            this.siteLabel.TabIndex = 1;
            this.siteLabel.Text = "Site Name:";
            // 
            // containerLabel
            // 
            this.containerLabel.AutoSize = true;
            this.containerLabel.Location = new System.Drawing.Point(205, 24);
            this.containerLabel.Name = "containerLabel";
            this.containerLabel.Size = new System.Drawing.Size(78, 13);
            this.containerLabel.TabIndex = 2;
            this.containerLabel.Text = "*Container IDs:";
            // 
            // requiredLabel
            // 
            this.requiredLabel.AutoSize = true;
            this.requiredLabel.Location = new System.Drawing.Point(12, 294);
            this.requiredLabel.Name = "requiredLabel";
            this.requiredLabel.Size = new System.Drawing.Size(87, 13);
            this.requiredLabel.TabIndex = 3;
            this.requiredLabel.Text = "* Required Fields";
            // 
            // shipmentTextBox
            // 
            this.shipmentTextBox.Location = new System.Drawing.Point(29, 40);
            this.shipmentTextBox.Name = "shipmentTextBox";
            this.shipmentTextBox.Size = new System.Drawing.Size(100, 20);
            this.shipmentTextBox.TabIndex = 0;
            // 
            // siteTextBox
            // 
            this.siteTextBox.Location = new System.Drawing.Point(29, 79);
            this.siteTextBox.Name = "siteTextBox";
            this.siteTextBox.Size = new System.Drawing.Size(100, 20);
            this.siteTextBox.TabIndex = 1;
            // 
            // numericCheckBox
            // 
            this.numericCheckBox.AutoSize = true;
            this.numericCheckBox.Location = new System.Drawing.Point(208, 284);
            this.numericCheckBox.Name = "numericCheckBox";
            this.numericCheckBox.Size = new System.Drawing.Size(89, 17);
            this.numericCheckBox.TabIndex = 4;
            this.numericCheckBox.Text = "Numeric Only";
            this.numericCheckBox.UseVisualStyleBackColor = true;
            // 
            // postShipmentButton
            // 
            this.postShipmentButton.Location = new System.Drawing.Point(29, 166);
            this.postShipmentButton.Name = "postShipmentButton";
            this.postShipmentButton.Size = new System.Drawing.Size(110, 46);
            this.postShipmentButton.TabIndex = 3;
            this.postShipmentButton.Text = "Post Shipment";
            this.postShipmentButton.UseVisualStyleBackColor = true;
            this.postShipmentButton.Click += new System.EventHandler(this.postShipmentButton_Click);
            // 
            // containerTextBox
            // 
            this.containerTextBox.AcceptsReturn = true;
            this.containerTextBox.Location = new System.Drawing.Point(208, 40);
            this.containerTextBox.Multiline = true;
            this.containerTextBox.Name = "containerTextBox";
            this.containerTextBox.Size = new System.Drawing.Size(154, 238);
            this.containerTextBox.TabIndex = 2;
            this.containerTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // ShipmentEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(411, 327);
            this.Controls.Add(this.containerTextBox);
            this.Controls.Add(this.postShipmentButton);
            this.Controls.Add(this.numericCheckBox);
            this.Controls.Add(this.siteTextBox);
            this.Controls.Add(this.shipmentTextBox);
            this.Controls.Add(this.requiredLabel);
            this.Controls.Add(this.containerLabel);
            this.Controls.Add(this.siteLabel);
            this.Controls.Add(this.shipmentLabel);
            this.Name = "ShipmentEntryForm";
            this.Text = "Shipment Entry";
            this.Load += new System.EventHandler(this.ShipmentEntryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shipmentLabel;
        private System.Windows.Forms.Label siteLabel;
        private System.Windows.Forms.Label containerLabel;
        private System.Windows.Forms.Label requiredLabel;
        private System.Windows.Forms.TextBox shipmentTextBox;
        private System.Windows.Forms.TextBox siteTextBox;
        private System.Windows.Forms.CheckBox numericCheckBox;
        private System.Windows.Forms.Button postShipmentButton;
        private System.Windows.Forms.TextBox containerTextBox;
    }
}