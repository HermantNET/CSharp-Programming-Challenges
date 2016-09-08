namespace WinformsMenu
{
    partial class Title
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEx1 = new System.Windows.Forms.Button();
            this.btnEx9 = new System.Windows.Forms.Button();
            this.btnEx10 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.btnEx1);
            this.flowLayoutPanel1.Controls.Add(this.btnEx9);
            this.flowLayoutPanel1.Controls.Add(this.btnEx10);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Source Sans Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 44);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(212, 226);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnEx1
            // 
            this.btnEx1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEx1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEx1.Location = new System.Drawing.Point(3, 3);
            this.btnEx1.Name = "btnEx1";
            this.btnEx1.Size = new System.Drawing.Size(100, 100);
            this.btnEx1.TabIndex = 6;
            this.btnEx1.Text = "Exercise 1-4";
            this.btnEx1.UseVisualStyleBackColor = false;
            this.btnEx1.Click += new System.EventHandler(this.Exercise_Button_Click);
            // 
            // btnEx9
            // 
            this.btnEx9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEx9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEx9.Location = new System.Drawing.Point(3, 109);
            this.btnEx9.Name = "btnEx9";
            this.btnEx9.Size = new System.Drawing.Size(100, 100);
            this.btnEx9.TabIndex = 3;
            this.btnEx9.Text = "Exercise 9";
            this.btnEx9.UseVisualStyleBackColor = false;
            this.btnEx9.Click += new System.EventHandler(this.Exercise_Button_Click);
            // 
            // btnEx10
            // 
            this.btnEx10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEx10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEx10.Location = new System.Drawing.Point(109, 3);
            this.btnEx10.Name = "btnEx10";
            this.btnEx10.Size = new System.Drawing.Size(100, 100);
            this.btnEx10.TabIndex = 7;
            this.btnEx10.Text = "Exercise 10";
            this.btnEx10.UseVisualStyleBackColor = false;
            this.btnEx10.Click += new System.EventHandler(this.Exercise_Button_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(109, 109);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 100);
            this.button5.TabIndex = 5;
            this.button5.Text = "E&xit";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Exercise_Button_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(236, 41);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "C# Programming: Chapter 10";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(236, 275);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Title";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnEx9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnEx1;
        private System.Windows.Forms.Button btnEx10;
    }
}

