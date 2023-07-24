namespace Ch4AnnualBonus
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.numYearsLabel = new System.Windows.Forms.Label();
            this.yearlySalesLabel = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.calcLabel = new System.Windows.Forms.Label();
            this.numYearsTextBox = new System.Windows.Forms.TextBox();
            this.yearlySalesTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft New Tai Lue", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(95, 54);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(217, 35);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Annual Bonuses";
            // 
            // numYearsLabel
            // 
            this.numYearsLabel.AutoSize = true;
            this.numYearsLabel.Location = new System.Drawing.Point(56, 138);
            this.numYearsLabel.Name = "numYearsLabel";
            this.numYearsLabel.Size = new System.Drawing.Size(173, 22);
            this.numYearsLabel.TabIndex = 1;
            this.numYearsLabel.Text = "Enter Years of Service";
            // 
            // yearlySalesLabel
            // 
            this.yearlySalesLabel.AutoSize = true;
            this.yearlySalesLabel.Location = new System.Drawing.Point(56, 204);
            this.yearlySalesLabel.Name = "yearlySalesLabel";
            this.yearlySalesLabel.Size = new System.Drawing.Size(143, 22);
            this.yearlySalesLabel.TabIndex = 2;
            this.yearlySalesLabel.Text = "Enter Yearly Sales";
            // 
            // calcBtn
            // 
            this.calcBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.calcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calcBtn.Location = new System.Drawing.Point(124, 254);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(115, 29);
            this.calcBtn.TabIndex = 3;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = false;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // calcLabel
            // 
            this.calcLabel.AutoSize = true;
            this.calcLabel.Location = new System.Drawing.Point(271, 257);
            this.calcLabel.Name = "calcLabel";
            this.calcLabel.Size = new System.Drawing.Size(0, 22);
            this.calcLabel.TabIndex = 4;
            // 
            // numYearsTextBox
            // 
            this.numYearsTextBox.Location = new System.Drawing.Point(249, 131);
            this.numYearsTextBox.Name = "numYearsTextBox";
            this.numYearsTextBox.Size = new System.Drawing.Size(100, 29);
            this.numYearsTextBox.TabIndex = 5;
            // 
            // yearlySalesTextBox
            // 
            this.yearlySalesTextBox.Location = new System.Drawing.Point(249, 197);
            this.yearlySalesTextBox.Name = "yearlySalesTextBox";
            this.yearlySalesTextBox.Size = new System.Drawing.Size(100, 29);
            this.yearlySalesTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(432, 360);
            this.Controls.Add(this.yearlySalesTextBox);
            this.Controls.Add(this.numYearsTextBox);
            this.Controls.Add(this.calcLabel);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.yearlySalesLabel);
            this.Controls.Add(this.numYearsLabel);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Annual Bonus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label numYearsLabel;
        private System.Windows.Forms.Label yearlySalesLabel;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label calcLabel;
        private System.Windows.Forms.TextBox numYearsTextBox;
        private System.Windows.Forms.TextBox yearlySalesTextBox;
    }
}

