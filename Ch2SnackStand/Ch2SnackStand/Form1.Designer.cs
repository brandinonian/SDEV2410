namespace Ch2SnackStand
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
            this.title = new System.Windows.Forms.Label();
            this.snackTextBox = new System.Windows.Forms.TextBox();
            this.drinkTextBox = new System.Windows.Forms.TextBox();
            this.snackLabel = new System.Windows.Forms.Label();
            this.drinkLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.Font = new System.Drawing.Font("Sitka Heading", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(125, 75);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(250, 35);
            this.title.TabIndex = 0;
            this.title.Text = "Company Snack Stand";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // snackTextBox
            // 
            this.snackTextBox.Location = new System.Drawing.Point(250, 150);
            this.snackTextBox.Name = "snackTextBox";
            this.snackTextBox.Size = new System.Drawing.Size(100, 22);
            this.snackTextBox.TabIndex = 1;
            // 
            // drinkTextBox
            // 
            this.drinkTextBox.Location = new System.Drawing.Point(250, 200);
            this.drinkTextBox.Name = "drinkTextBox";
            this.drinkTextBox.Size = new System.Drawing.Size(100, 22);
            this.drinkTextBox.TabIndex = 2;
            // 
            // snackLabel
            // 
            this.snackLabel.AutoSize = true;
            this.snackLabel.Location = new System.Drawing.Point(150, 150);
            this.snackLabel.Name = "snackLabel";
            this.snackLabel.Size = new System.Drawing.Size(77, 17);
            this.snackLabel.TabIndex = 3;
            this.snackLabel.Text = "Snack Item";
            this.snackLabel.Click += new System.EventHandler(this.snackLabel_Click);
            // 
            // drinkLabel
            // 
            this.drinkLabel.AutoSize = true;
            this.drinkLabel.Location = new System.Drawing.Point(150, 200);
            this.drinkLabel.Name = "drinkLabel";
            this.drinkLabel.Size = new System.Drawing.Size(71, 17);
            this.drinkLabel.TabIndex = 4;
            this.drinkLabel.Text = "Drink Item";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(200, 250);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(100, 25);
            this.calcButton.TabIndex = 5;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(150, 300);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(76, 17);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.Text = "Total Cost:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.drinkLabel);
            this.Controls.Add(this.snackLabel);
            this.Controls.Add(this.drinkTextBox);
            this.Controls.Add(this.snackTextBox);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox snackTextBox;
        private System.Windows.Forms.TextBox drinkTextBox;
        private System.Windows.Forms.Label snackLabel;
        private System.Windows.Forms.Label drinkLabel;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label totalLabel;
    }
}

