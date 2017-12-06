namespace WebServicesFinal
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.lblTempature = new System.Windows.Forms.Label();
            this.lblPressure = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblSunSet = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblConditions = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.lblWind = new System.Windows.Forms.Label();
            this.btnGetInformation = new System.Windows.Forms.Button();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.lblSunRise = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Enter Zip Code or City: ";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(365, 24);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(186, 20);
            this.txtZipCode.TabIndex = 1;
            // 
            // lblTempature
            // 
            this.lblTempature.AutoSize = true;
            this.lblTempature.Location = new System.Drawing.Point(12, 168);
            this.lblTempature.Name = "lblTempature";
            this.lblTempature.Size = new System.Drawing.Size(64, 13);
            this.lblTempature.TabIndex = 5;
            this.lblTempature.Text = "Tempature: ";
            // 
            // lblPressure
            // 
            this.lblPressure.AutoSize = true;
            this.lblPressure.Location = new System.Drawing.Point(12, 194);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(54, 13);
            this.lblPressure.TabIndex = 6;
            this.lblPressure.Text = "Pressure: ";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(12, 88);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(54, 13);
            this.lblLocation.TabIndex = 7;
            this.lblLocation.Text = "Location: ";
            // 
            // lblSunSet
            // 
            this.lblSunSet.AutoSize = true;
            this.lblSunSet.Location = new System.Drawing.Point(12, 143);
            this.lblSunSet.Name = "lblSunSet";
            this.lblSunSet.Size = new System.Drawing.Size(51, 13);
            this.lblSunSet.TabIndex = 8;
            this.lblSunSet.Text = "Sun Set: ";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Location = new System.Drawing.Point(12, 220);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(53, 13);
            this.lblHumidity.TabIndex = 9;
            this.lblHumidity.Text = "Humidity: ";
            // 
            // lblConditions
            // 
            this.lblConditions.AutoSize = true;
            this.lblConditions.Location = new System.Drawing.Point(12, 248);
            this.lblConditions.Name = "lblConditions";
            this.lblConditions.Size = new System.Drawing.Size(62, 13);
            this.lblConditions.TabIndex = 10;
            this.lblConditions.Text = "Conditions: ";
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(12, 277);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(51, 13);
            this.lblLatitude.TabIndex = 11;
            this.lblLatitude.Text = "Latitude: ";
            // 
            // lblWind
            // 
            this.lblWind.AutoSize = true;
            this.lblWind.Location = new System.Drawing.Point(12, 334);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(72, 13);
            this.lblWind.TabIndex = 12;
            this.lblWind.Text = "Wind Speed: ";
            // 
            // btnGetInformation
            // 
            this.btnGetInformation.Location = new System.Drawing.Point(365, 59);
            this.btnGetInformation.Name = "btnGetInformation";
            this.btnGetInformation.Size = new System.Drawing.Size(186, 23);
            this.btnGetInformation.TabIndex = 13;
            this.btnGetInformation.Text = "Get Information";
            this.btnGetInformation.UseVisualStyleBackColor = true;
            this.btnGetInformation.Click += new System.EventHandler(this.btnGetInformation_Click);
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(12, 304);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(60, 13);
            this.lblLongitude.TabIndex = 14;
            this.lblLongitude.Text = "Longitude: ";
            // 
            // lblSunRise
            // 
            this.lblSunRise.AutoSize = true;
            this.lblSunRise.Location = new System.Drawing.Point(12, 113);
            this.lblSunRise.Name = "lblSunRise";
            this.lblSunRise.Size = new System.Drawing.Size(56, 13);
            this.lblSunRise.TabIndex = 15;
            this.lblSunRise.Text = "Sun Rise: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 356);
            this.Controls.Add(this.lblSunRise);
            this.Controls.Add(this.lblLongitude);
            this.Controls.Add(this.btnGetInformation);
            this.Controls.Add(this.lblWind);
            this.Controls.Add(this.lblLatitude);
            this.Controls.Add(this.lblConditions);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.lblSunSet);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblPressure);
            this.Controls.Add(this.lblTempature);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Label lblTempature;
        private System.Windows.Forms.Label lblPressure;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblSunSet;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label lblConditions;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label lblWind;
        private System.Windows.Forms.Button btnGetInformation;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Label lblSunRise;
    }
}

