namespace CheckCredit
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
            this.txtprice = new System.Windows.Forms.TextBox();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblapproved = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(238, 194);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(100, 20);
            this.txtprice.TabIndex = 0;
            // 
            // btnTransaction
            // 
            this.btnTransaction.Location = new System.Drawing.Point(355, 194);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(75, 20);
            this.btnTransaction.TabIndex = 1;
            this.btnTransaction.Text = "Transaction";
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Purchase Price";
            // 
            // lblapproved
            // 
            this.lblapproved.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblapproved.Location = new System.Drawing.Point(452, 193);
            this.lblapproved.Name = "lblapproved";
            this.lblapproved.Size = new System.Drawing.Size(100, 20);
            this.lblapproved.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblapproved);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.txtprice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblapproved;
    }
}

