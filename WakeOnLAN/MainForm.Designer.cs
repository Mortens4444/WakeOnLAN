namespace WakeOnLAN
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWakeUp = new System.Windows.Forms.Button();
            this.tbMacAddress = new System.Windows.Forms.TextBox();
            this.lblMacAddress = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWakeUp);
            this.groupBox1.Controls.Add(this.tbMacAddress);
            this.groupBox1.Controls.Add(this.lblMacAddress);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnWakeUp
            // 
            this.btnWakeUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWakeUp.Location = new System.Drawing.Point(203, 30);
            this.btnWakeUp.Name = "btnWakeUp";
            this.btnWakeUp.Size = new System.Drawing.Size(75, 23);
            this.btnWakeUp.TabIndex = 2;
            this.btnWakeUp.Text = "Wake up!";
            this.btnWakeUp.UseVisualStyleBackColor = true;
            this.btnWakeUp.Click += new System.EventHandler(this.btnWakeUp_Click);
            // 
            // tbMacAddress
            // 
            this.tbMacAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMacAddress.Location = new System.Drawing.Point(6, 32);
            this.tbMacAddress.MaxLength = 17;
            this.tbMacAddress.Name = "tbMacAddress";
            this.tbMacAddress.Size = new System.Drawing.Size(188, 20);
            this.tbMacAddress.TabIndex = 1;
            // 
            // lblMacAddress
            // 
            this.lblMacAddress.AutoSize = true;
            this.lblMacAddress.Location = new System.Drawing.Point(6, 16);
            this.lblMacAddress.Name = "lblMacAddress";
            this.lblMacAddress.Size = new System.Drawing.Size(71, 13);
            this.lblMacAddress.TabIndex = 0;
            this.lblMacAddress.Text = "MAC Address";
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnWakeUp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 61);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 100);
            this.MinimumSize = new System.Drawing.Size(300, 100);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wake On LAN";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnWakeUp;
        private System.Windows.Forms.TextBox tbMacAddress;
        private System.Windows.Forms.Label lblMacAddress;
    }
}

