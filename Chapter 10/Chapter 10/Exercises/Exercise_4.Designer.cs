namespace Chapter_10.Exercises
{
    partial class Exercise_4
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
            this.gbSports = new System.Windows.Forms.GroupBox();
            this.radGolf = new System.Windows.Forms.RadioButton();
            this.radMuayThai = new System.Windows.Forms.RadioButton();
            this.radRugby = new System.Windows.Forms.RadioButton();
            this.radFootball = new System.Windows.Forms.RadioButton();
            this.radBasketball = new System.Windows.Forms.RadioButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSportDesc = new System.Windows.Forms.Label();
            this.imgSport = new System.Windows.Forms.PictureBox();
            this.gbSports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSport)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSports
            // 
            this.gbSports.Controls.Add(this.radGolf);
            this.gbSports.Controls.Add(this.radMuayThai);
            this.gbSports.Controls.Add(this.radRugby);
            this.gbSports.Controls.Add(this.radFootball);
            this.gbSports.Controls.Add(this.radBasketball);
            this.gbSports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSports.Location = new System.Drawing.Point(0, 0);
            this.gbSports.Name = "gbSports";
            this.gbSports.Size = new System.Drawing.Size(111, 161);
            this.gbSports.TabIndex = 0;
            this.gbSports.TabStop = false;
            this.gbSports.Text = "Sports";
            // 
            // radGolf
            // 
            this.radGolf.AutoSize = true;
            this.radGolf.Location = new System.Drawing.Point(6, 112);
            this.radGolf.Name = "radGolf";
            this.radGolf.Size = new System.Drawing.Size(44, 17);
            this.radGolf.TabIndex = 4;
            this.radGolf.TabStop = true;
            this.radGolf.Text = "Golf";
            this.radGolf.UseVisualStyleBackColor = true;
            this.radGolf.CheckedChanged += new System.EventHandler(this.radGolf_CheckedChanged);
            // 
            // radMuayThai
            // 
            this.radMuayThai.AutoSize = true;
            this.radMuayThai.Location = new System.Drawing.Point(6, 89);
            this.radMuayThai.Name = "radMuayThai";
            this.radMuayThai.Size = new System.Drawing.Size(75, 17);
            this.radMuayThai.TabIndex = 3;
            this.radMuayThai.TabStop = true;
            this.radMuayThai.Text = "Muay Thai";
            this.radMuayThai.UseVisualStyleBackColor = true;
            this.radMuayThai.CheckedChanged += new System.EventHandler(this.radMuayThai_CheckedChanged);
            // 
            // radRugby
            // 
            this.radRugby.AutoSize = true;
            this.radRugby.Location = new System.Drawing.Point(6, 66);
            this.radRugby.Name = "radRugby";
            this.radRugby.Size = new System.Drawing.Size(56, 17);
            this.radRugby.TabIndex = 2;
            this.radRugby.TabStop = true;
            this.radRugby.Text = "Rugby";
            this.radRugby.UseVisualStyleBackColor = true;
            this.radRugby.CheckedChanged += new System.EventHandler(this.radRugby_CheckedChanged);
            // 
            // radFootball
            // 
            this.radFootball.AutoSize = true;
            this.radFootball.Location = new System.Drawing.Point(6, 43);
            this.radFootball.Name = "radFootball";
            this.radFootball.Size = new System.Drawing.Size(62, 17);
            this.radFootball.TabIndex = 1;
            this.radFootball.TabStop = true;
            this.radFootball.Text = "Football";
            this.radFootball.UseVisualStyleBackColor = true;
            this.radFootball.CheckedChanged += new System.EventHandler(this.radFootball_CheckedChanged);
            // 
            // radBasketball
            // 
            this.radBasketball.AutoSize = true;
            this.radBasketball.Location = new System.Drawing.Point(6, 19);
            this.radBasketball.Name = "radBasketball";
            this.radBasketball.Size = new System.Drawing.Size(74, 17);
            this.radBasketball.TabIndex = 0;
            this.radBasketball.TabStop = true;
            this.radBasketball.Text = "Basketball";
            this.radBasketball.UseVisualStyleBackColor = true;
            this.radBasketball.CheckedChanged += new System.EventHandler(this.radBasketball_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbSports);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(333, 161);
            this.splitContainer1.SplitterDistance = 111;
            this.splitContainer1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblSportDesc, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.imgSport, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.39751F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.60248F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(218, 161);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblSportDesc
            // 
            this.lblSportDesc.AutoSize = true;
            this.lblSportDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSportDesc.Location = new System.Drawing.Point(3, 123);
            this.lblSportDesc.Name = "lblSportDesc";
            this.lblSportDesc.Size = new System.Drawing.Size(212, 38);
            this.lblSportDesc.TabIndex = 0;
            this.lblSportDesc.Text = "Choose a sport!";
            this.lblSportDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgSport
            // 
            this.imgSport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgSport.Location = new System.Drawing.Point(3, 3);
            this.imgSport.Name = "imgSport";
            this.imgSport.Size = new System.Drawing.Size(212, 117);
            this.imgSport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSport.TabIndex = 1;
            this.imgSport.TabStop = false;
            // 
            // Exercise_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 161);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Exercise_4";
            this.Text = "Exercise 4";
            this.gbSports.ResumeLayout(false);
            this.gbSports.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSports;
        private System.Windows.Forms.RadioButton radGolf;
        private System.Windows.Forms.RadioButton radMuayThai;
        private System.Windows.Forms.RadioButton radRugby;
        private System.Windows.Forms.RadioButton radFootball;
        private System.Windows.Forms.RadioButton radBasketball;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSportDesc;
        private System.Windows.Forms.PictureBox imgSport;
    }
}