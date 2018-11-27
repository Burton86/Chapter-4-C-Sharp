namespace Twitter
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
            this.lblCounter = new System.Windows.Forms.Label();
            this.txtTwitterMsg = new System.Windows.Forms.TextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.lblPostedMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCounter
            // 
            this.lblCounter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCounter.Location = new System.Drawing.Point(121, 152);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(100, 23);
            this.lblCounter.TabIndex = 0;
            // 
            // txtTwitterMsg
            // 
            this.txtTwitterMsg.Location = new System.Drawing.Point(80, 12);
            this.txtTwitterMsg.Multiline = true;
            this.txtTwitterMsg.Name = "txtTwitterMsg";
            this.txtTwitterMsg.Size = new System.Drawing.Size(185, 120);
            this.txtTwitterMsg.TabIndex = 1;
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPost.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPost.Location = new System.Drawing.Point(130, 202);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 2;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // lblPostedMsg
            // 
            this.lblPostedMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPostedMsg.Location = new System.Drawing.Point(121, 273);
            this.lblPostedMsg.Name = "lblPostedMsg";
            this.lblPostedMsg.Size = new System.Drawing.Size(100, 23);
            this.lblPostedMsg.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(341, 415);
            this.Controls.Add(this.lblPostedMsg);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.txtTwitterMsg);
            this.Controls.Add(this.lblCounter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.TextBox txtTwitterMsg;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Label lblPostedMsg;
    }
}

