namespace Fuel_Economy
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
            this.milesLabel = new System.Windows.Forms.Label();
            this.gallonsLabel = new System.Windows.Forms.Label();
            this.MPGLabel = new System.Windows.Forms.Label();
            this.miles = new System.Windows.Forms.TextBox();
            this.gallons = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.MPGOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // milesLabel
            // 
            this.milesLabel.AutoSize = true;
            this.milesLabel.Location = new System.Drawing.Point(13, 22);
            this.milesLabel.Name = "milesLabel";
            this.milesLabel.Size = new System.Drawing.Size(58, 13);
            this.milesLabel.TabIndex = 0;
            this.milesLabel.Text = "Input Miles";
            // 
            // gallonsLabel
            // 
            this.gallonsLabel.AutoSize = true;
            this.gallonsLabel.Location = new System.Drawing.Point(13, 45);
            this.gallonsLabel.Name = "gallonsLabel";
            this.gallonsLabel.Size = new System.Drawing.Size(69, 13);
            this.gallonsLabel.TabIndex = 1;
            this.gallonsLabel.Text = "Input Gallons";
            // 
            // MPGLabel
            // 
            this.MPGLabel.AutoSize = true;
            this.MPGLabel.Location = new System.Drawing.Point(13, 96);
            this.MPGLabel.Name = "MPGLabel";
            this.MPGLabel.Size = new System.Drawing.Size(56, 13);
            this.MPGLabel.TabIndex = 2;
            this.MPGLabel.Text = "Your MPG";
            // 
            // miles
            // 
            this.miles.Location = new System.Drawing.Point(113, 15);
            this.miles.Name = "miles";
            this.miles.Size = new System.Drawing.Size(100, 20);
            this.miles.TabIndex = 3;
            // 
            // gallons
            // 
            this.gallons.Location = new System.Drawing.Point(113, 42);
            this.gallons.Name = "gallons";
            this.gallons.Size = new System.Drawing.Size(100, 20);
            this.gallons.TabIndex = 4;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(16, 150);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(75, 23);
            this.calculateBtn.TabIndex = 5;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(133, 150);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // MPGOutputLabel
            // 
            this.MPGOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MPGOutputLabel.Location = new System.Drawing.Point(113, 95);
            this.MPGOutputLabel.Name = "MPGOutputLabel";
            this.MPGOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.MPGOutputLabel.TabIndex = 7;
            this.MPGOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.MPGOutputLabel);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.gallons);
            this.Controls.Add(this.miles);
            this.Controls.Add(this.MPGLabel);
            this.Controls.Add(this.gallonsLabel);
            this.Controls.Add(this.milesLabel);
            this.Name = "Form1";
            this.Text = "Fuel Economy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label milesLabel;
        private System.Windows.Forms.Label gallonsLabel;
        private System.Windows.Forms.Label MPGLabel;
        private System.Windows.Forms.TextBox miles;
        private System.Windows.Forms.TextBox gallons;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label MPGOutputLabel;
    }
}

