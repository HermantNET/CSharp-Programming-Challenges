namespace Chapter_10.Exercises
{
    partial class Exercise_8
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
            this.lstBags = new System.Windows.Forms.ListBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSelected = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.grpShipping = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.radOvernight = new System.Windows.Forms.RadioButton();
            this.radThreeDay = new System.Windows.Forms.RadioButton();
            this.radStandard = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.grpShipping.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBags
            // 
            this.lstBags.FormattingEnabled = true;
            this.lstBags.Items.AddRange(new object[] {
            "full decorative",
            "beaded",
            "needlepoint design",
            "fringed",
            "fringed beaded",
            "plain"});
            this.lstBags.Location = new System.Drawing.Point(12, 25);
            this.lstBags.Name = "lstBags";
            this.lstBags.Size = new System.Drawing.Size(120, 82);
            this.lstBags.TabIndex = 0;
            this.lstBags.SelectedIndexChanged += new System.EventHandler(this.lstBags_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(197, 184);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last Selected";
            // 
            // lblSelected
            // 
            this.lblSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelected.Location = new System.Drawing.Point(138, 36);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(134, 71);
            this.lblSelected.TabIndex = 3;
            this.lblSelected.Text = "NA";
            this.lblSelected.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bags";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(149, 129);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 20);
            this.numQuantity.TabIndex = 5;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grpShipping
            // 
            this.grpShipping.Controls.Add(this.radStandard);
            this.grpShipping.Controls.Add(this.radThreeDay);
            this.grpShipping.Controls.Add(this.radOvernight);
            this.grpShipping.Location = new System.Drawing.Point(12, 113);
            this.grpShipping.Name = "grpShipping";
            this.grpShipping.Size = new System.Drawing.Size(131, 94);
            this.grpShipping.TabIndex = 6;
            this.grpShipping.TabStop = false;
            this.grpShipping.Text = "Shipping Options";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantity";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Clea&r";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // radOvernight
            // 
            this.radOvernight.AutoSize = true;
            this.radOvernight.Checked = true;
            this.radOvernight.Location = new System.Drawing.Point(6, 19);
            this.radOvernight.Name = "radOvernight";
            this.radOvernight.Size = new System.Drawing.Size(71, 17);
            this.radOvernight.TabIndex = 0;
            this.radOvernight.TabStop = true;
            this.radOvernight.Text = "Overnight";
            this.radOvernight.UseVisualStyleBackColor = true;
            // 
            // radThreeDay
            // 
            this.radThreeDay.AutoSize = true;
            this.radThreeDay.Location = new System.Drawing.Point(6, 42);
            this.radThreeDay.Name = "radThreeDay";
            this.radThreeDay.Size = new System.Drawing.Size(75, 17);
            this.radThreeDay.TabIndex = 1;
            this.radThreeDay.TabStop = true;
            this.radThreeDay.Text = "Three Day";
            this.radThreeDay.UseVisualStyleBackColor = true;
            // 
            // radStandard
            // 
            this.radStandard.AutoSize = true;
            this.radStandard.Location = new System.Drawing.Point(6, 65);
            this.radStandard.Name = "radStandard";
            this.radStandard.Size = new System.Drawing.Size(68, 17);
            this.radStandard.TabIndex = 2;
            this.radStandard.TabStop = true;
            this.radStandard.Text = "Standard";
            this.radStandard.UseVisualStyleBackColor = true;
            // 
            // Exercise_8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 222);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grpShipping);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lstBags);
            this.Name = "Exercise_8";
            this.Text = "Exercise_10";
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.grpShipping.ResumeLayout(false);
            this.grpShipping.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBags;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.GroupBox grpShipping;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radStandard;
        private System.Windows.Forms.RadioButton radThreeDay;
        private System.Windows.Forms.RadioButton radOvernight;
    }
}