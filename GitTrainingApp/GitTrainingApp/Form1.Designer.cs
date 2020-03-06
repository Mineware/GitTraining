namespace GitTrainingApp
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
            this.btnClose = new System.Windows.Forms.Button();
            this.chbxClickMe = new System.Windows.Forms.CheckBox();
            this.labClientName = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnNewClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(169, 43);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chbxClickMe
            // 
            this.chbxClickMe.AutoSize = true;
            this.chbxClickMe.Location = new System.Drawing.Point(144, 147);
            this.chbxClickMe.Name = "chbxClickMe";
            this.chbxClickMe.Size = new System.Drawing.Size(75, 17);
            this.chbxClickMe.TabIndex = 1;
            this.chbxClickMe.Text = "Check Me";
            this.chbxClickMe.UseVisualStyleBackColor = true;
            this.chbxClickMe.CheckedChanged += new System.EventHandler(this.chbxClickMe_CheckedChanged);
            // 
            // labClientName
            // 
            this.labClientName.AutoSize = true;
            this.labClientName.Location = new System.Drawing.Point(357, 147);
            this.labClientName.Name = "labClientName";
            this.labClientName.Size = new System.Drawing.Size(35, 13);
            this.labClientName.TabIndex = 2;
            this.labClientName.Text = "label1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(76, 238);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(132, 82);
            this.listBox1.TabIndex = 3;
            // 
            // btnNewClient
            // 
            this.btnNewClient.Location = new System.Drawing.Point(455, 33);
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.Size = new System.Drawing.Size(90, 72);
            this.btnNewClient.TabIndex = 4;
            this.btnNewClient.Text = "button1";
            this.btnNewClient.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNewClient);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labClientName);
            this.Controls.Add(this.chbxClickMe);
            this.Controls.Add(this.btnClose);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.CheckBox chbxClickMe;
        private System.Windows.Forms.Label labClientName;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnNewClient;
    }
}

