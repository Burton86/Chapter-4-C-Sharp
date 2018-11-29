namespace Fahrenheit_to_Celsius
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
            this.txt8Am = new System.Windows.Forms.TextBox();
            this.txt5Pm = new System.Windows.Forms.TextBox();
            this.txt12Pm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFahrenheit = new System.Windows.Forms.Button();
            this.btnCelsius = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOutput8am = new System.Windows.Forms.Label();
            this.lbloutput12pm = new System.Windows.Forms.Label();
            this.lbloutput5pm = new System.Windows.Forms.Label();
            this.lblHotAndCold = new System.Windows.Forms.Label();
            this.lblHotAndCold2 = new System.Windows.Forms.Label();
            this.lblHotAndCold3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt8Am
            // 
            this.txt8Am.Location = new System.Drawing.Point(160, 82);
            this.txt8Am.Name = "txt8Am";
            this.txt8Am.Size = new System.Drawing.Size(100, 20);
            this.txt8Am.TabIndex = 0;
            // 
            // txt5Pm
            // 
            this.txt5Pm.Location = new System.Drawing.Point(160, 173);
            this.txt5Pm.Name = "txt5Pm";
            this.txt5Pm.Size = new System.Drawing.Size(100, 20);
            this.txt5Pm.TabIndex = 1;
            // 
            // txt12Pm
            // 
            this.txt12Pm.Location = new System.Drawing.Point(160, 126);
            this.txt12Pm.Name = "txt12Pm";
            this.txt12Pm.Size = new System.Drawing.Size(100, 20);
            this.txt12Pm.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "8:00 Am";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "12:00 Pm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "5:00 Pm";
            // 
            // btnFahrenheit
            // 
            this.btnFahrenheit.Location = new System.Drawing.Point(195, 296);
            this.btnFahrenheit.Name = "btnFahrenheit";
            this.btnFahrenheit.Size = new System.Drawing.Size(75, 23);
            this.btnFahrenheit.TabIndex = 6;
            this.btnFahrenheit.Text = "Fahrenheit";
            this.btnFahrenheit.UseVisualStyleBackColor = true;
            this.btnFahrenheit.Click += new System.EventHandler(this.btnFahrenheit_Click);
            // 
            // btnCelsius
            // 
            this.btnCelsius.Location = new System.Drawing.Point(422, 296);
            this.btnCelsius.Name = "btnCelsius";
            this.btnCelsius.Size = new System.Drawing.Size(75, 23);
            this.btnCelsius.TabIndex = 7;
            this.btnCelsius.Text = "Celsius";
            this.btnCelsius.UseVisualStyleBackColor = true;
            this.btnCelsius.Click += new System.EventHandler(this.btnCelsius_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Inputs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Outputs";
            // 
            // lblOutput8am
            // 
            this.lblOutput8am.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput8am.Location = new System.Drawing.Point(422, 81);
            this.lblOutput8am.Name = "lblOutput8am";
            this.lblOutput8am.Size = new System.Drawing.Size(100, 23);
            this.lblOutput8am.TabIndex = 10;
            // 
            // lbloutput12pm
            // 
            this.lbloutput12pm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbloutput12pm.Location = new System.Drawing.Point(422, 123);
            this.lbloutput12pm.Name = "lbloutput12pm";
            this.lbloutput12pm.Size = new System.Drawing.Size(100, 23);
            this.lbloutput12pm.TabIndex = 11;
            // 
            // lbloutput5pm
            // 
            this.lbloutput5pm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbloutput5pm.Location = new System.Drawing.Point(422, 170);
            this.lbloutput5pm.Name = "lbloutput5pm";
            this.lbloutput5pm.Size = new System.Drawing.Size(100, 23);
            this.lbloutput5pm.TabIndex = 12;
            // 
            // lblHotAndCold
            // 
            this.lblHotAndCold.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHotAndCold.Location = new System.Drawing.Point(576, 82);
            this.lblHotAndCold.Name = "lblHotAndCold";
            this.lblHotAndCold.Size = new System.Drawing.Size(100, 23);
            this.lblHotAndCold.TabIndex = 13;
            this.lblHotAndCold.Visible = false;
            // 
            // lblHotAndCold2
            // 
            this.lblHotAndCold2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHotAndCold2.Location = new System.Drawing.Point(576, 123);
            this.lblHotAndCold2.Name = "lblHotAndCold2";
            this.lblHotAndCold2.Size = new System.Drawing.Size(100, 23);
            this.lblHotAndCold2.TabIndex = 14;
            this.lblHotAndCold2.Visible = false;
            // 
            // lblHotAndCold3
            // 
            this.lblHotAndCold3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHotAndCold3.Location = new System.Drawing.Point(576, 170);
            this.lblHotAndCold3.Name = "lblHotAndCold3";
            this.lblHotAndCold3.Size = new System.Drawing.Size(100, 23);
            this.lblHotAndCold3.TabIndex = 15;
            this.lblHotAndCold3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHotAndCold3);
            this.Controls.Add(this.lblHotAndCold2);
            this.Controls.Add(this.lblHotAndCold);
            this.Controls.Add(this.lbloutput5pm);
            this.Controls.Add(this.lbloutput12pm);
            this.Controls.Add(this.lblOutput8am);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCelsius);
            this.Controls.Add(this.btnFahrenheit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt12Pm);
            this.Controls.Add(this.txt5Pm);
            this.Controls.Add(this.txt8Am);
            this.Name = "Form1";
            this.Text = "FahrenheitToCelsius";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt8Am;
        private System.Windows.Forms.TextBox txt5Pm;
        private System.Windows.Forms.TextBox txt12Pm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFahrenheit;
        private System.Windows.Forms.Button btnCelsius;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOutput8am;
        private System.Windows.Forms.Label lbloutput12pm;
        private System.Windows.Forms.Label lbloutput5pm;
        private System.Windows.Forms.Label lblHotAndCold;
        private System.Windows.Forms.Label lblHotAndCold2;
        private System.Windows.Forms.Label lblHotAndCold3;
    }
}

