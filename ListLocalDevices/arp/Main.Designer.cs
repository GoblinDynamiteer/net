namespace arp
{
    partial class Main
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
            this.listBoxDevices = new System.Windows.Forms.ListBox();
            this.btnGetDevices = new System.Windows.Forms.Button();
            this.tbIp = new System.Windows.Forms.TextBox();
            this.tbMac = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxDevices
            // 
            this.listBoxDevices.FormattingEnabled = true;
            this.listBoxDevices.ItemHeight = 25;
            this.listBoxDevices.Location = new System.Drawing.Point(26, 83);
            this.listBoxDevices.Name = "listBoxDevices";
            this.listBoxDevices.Size = new System.Drawing.Size(803, 504);
            this.listBoxDevices.TabIndex = 0;
            this.listBoxDevices.SelectedIndexChanged += new System.EventHandler(this.listBoxDevices_SelectedIndexChanged);
            // 
            // btnGetDevices
            // 
            this.btnGetDevices.Location = new System.Drawing.Point(26, 605);
            this.btnGetDevices.Name = "btnGetDevices";
            this.btnGetDevices.Size = new System.Drawing.Size(233, 76);
            this.btnGetDevices.TabIndex = 1;
            this.btnGetDevices.Text = "Get Devices";
            this.btnGetDevices.UseVisualStyleBackColor = true;
            this.btnGetDevices.Click += new System.EventHandler(this.btnGetDevices_Click);
            // 
            // tbIp
            // 
            this.tbIp.Location = new System.Drawing.Point(26, 726);
            this.tbIp.Name = "tbIp";
            this.tbIp.Size = new System.Drawing.Size(233, 31);
            this.tbIp.TabIndex = 2;
            // 
            // tbMac
            // 
            this.tbMac.Location = new System.Drawing.Point(298, 726);
            this.tbMac.Name = "tbMac";
            this.tbMac.Size = new System.Drawing.Size(233, 31);
            this.tbMac.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 884);
            this.Controls.Add(this.tbMac);
            this.Controls.Add(this.tbIp);
            this.Controls.Add(this.btnGetDevices);
            this.Controls.Add(this.listBoxDevices);
            this.Name = "Main";
            this.Text = "ARP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDevices;
        private System.Windows.Forms.Button btnGetDevices;
        private System.Windows.Forms.TextBox tbIp;
        private System.Windows.Forms.TextBox tbMac;
    }
}

