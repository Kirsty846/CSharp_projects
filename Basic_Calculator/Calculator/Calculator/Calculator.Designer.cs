namespace Calculator
{
    partial class Calculator
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
            this.Number1_button = new System.Windows.Forms.Button();
            this.Number2_button = new System.Windows.Forms.Button();
            this.Number3_button = new System.Windows.Forms.Button();
            this.Number4_button = new System.Windows.Forms.Button();
            this.Number5_button = new System.Windows.Forms.Button();
            this.Number6_button = new System.Windows.Forms.Button();
            this.Number7_button = new System.Windows.Forms.Button();
            this.Number8_button = new System.Windows.Forms.Button();
            this.Number9_button = new System.Windows.Forms.Button();
            this.Number0_button = new System.Windows.Forms.Button();
            this.Enter_button = new System.Windows.Forms.Button();
            this.Clear_button = new System.Windows.Forms.Button();
            this.Point_button = new System.Windows.Forms.Button();
            this.Result_textBox = new System.Windows.Forms.TextBox();
            this.Expression_textBox = new System.Windows.Forms.TextBox();
            this.Expression_label = new System.Windows.Forms.Label();
            this.Result_label = new System.Windows.Forms.Label();
            this.Add_button = new System.Windows.Forms.Button();
            this.Multiply_button = new System.Windows.Forms.Button();
            this.Subtract_button = new System.Windows.Forms.Button();
            this.Divide_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Number1_button
            // 
            this.Number1_button.Location = new System.Drawing.Point(30, 129);
            this.Number1_button.Name = "Number1_button";
            this.Number1_button.Size = new System.Drawing.Size(59, 50);
            this.Number1_button.TabIndex = 0;
            this.Number1_button.Text = "1";
            this.Number1_button.UseVisualStyleBackColor = true;
            this.Number1_button.Click += new System.EventHandler(this.UpdateDisplay);
            // 
            // Number2_button
            // 
            this.Number2_button.Location = new System.Drawing.Point(117, 129);
            this.Number2_button.Name = "Number2_button";
            this.Number2_button.Size = new System.Drawing.Size(59, 50);
            this.Number2_button.TabIndex = 1;
            this.Number2_button.Text = "2";
            this.Number2_button.UseVisualStyleBackColor = true;
            this.Number2_button.Click += new System.EventHandler(this.UpdateDisplay);
            // 
            // Number3_button
            // 
            this.Number3_button.Location = new System.Drawing.Point(205, 129);
            this.Number3_button.Name = "Number3_button";
            this.Number3_button.Size = new System.Drawing.Size(59, 50);
            this.Number3_button.TabIndex = 2;
            this.Number3_button.Text = "3";
            this.Number3_button.UseVisualStyleBackColor = true;
            this.Number3_button.Click += new System.EventHandler(this.UpdateDisplay);
            // 
            // Number4_button
            // 
            this.Number4_button.Location = new System.Drawing.Point(30, 198);
            this.Number4_button.Name = "Number4_button";
            this.Number4_button.Size = new System.Drawing.Size(59, 50);
            this.Number4_button.TabIndex = 3;
            this.Number4_button.Text = "4";
            this.Number4_button.UseVisualStyleBackColor = true;
            this.Number4_button.Click += new System.EventHandler(this.UpdateDisplay);
            // 
            // Number5_button
            // 
            this.Number5_button.Location = new System.Drawing.Point(117, 198);
            this.Number5_button.Name = "Number5_button";
            this.Number5_button.Size = new System.Drawing.Size(59, 50);
            this.Number5_button.TabIndex = 4;
            this.Number5_button.Text = "5";
            this.Number5_button.UseVisualStyleBackColor = true;
            this.Number5_button.Click += new System.EventHandler(this.UpdateDisplay);
            // 
            // Number6_button
            // 
            this.Number6_button.Location = new System.Drawing.Point(205, 198);
            this.Number6_button.Name = "Number6_button";
            this.Number6_button.Size = new System.Drawing.Size(59, 50);
            this.Number6_button.TabIndex = 5;
            this.Number6_button.Text = "6";
            this.Number6_button.UseVisualStyleBackColor = true;
            this.Number6_button.Click += new System.EventHandler(this.UpdateDisplay);
            // 
            // Number7_button
            // 
            this.Number7_button.Location = new System.Drawing.Point(30, 266);
            this.Number7_button.Name = "Number7_button";
            this.Number7_button.Size = new System.Drawing.Size(59, 50);
            this.Number7_button.TabIndex = 6;
            this.Number7_button.Text = "7";
            this.Number7_button.UseVisualStyleBackColor = true;
            this.Number7_button.Click += new System.EventHandler(this.UpdateDisplay);
            // 
            // Number8_button
            // 
            this.Number8_button.Location = new System.Drawing.Point(117, 266);
            this.Number8_button.Name = "Number8_button";
            this.Number8_button.Size = new System.Drawing.Size(59, 50);
            this.Number8_button.TabIndex = 7;
            this.Number8_button.Text = "8";
            this.Number8_button.UseVisualStyleBackColor = true;
            this.Number8_button.Click += new System.EventHandler(this.UpdateDisplay);
            // 
            // Number9_button
            // 
            this.Number9_button.Location = new System.Drawing.Point(205, 266);
            this.Number9_button.Name = "Number9_button";
            this.Number9_button.Size = new System.Drawing.Size(59, 50);
            this.Number9_button.TabIndex = 8;
            this.Number9_button.Text = "9";
            this.Number9_button.UseVisualStyleBackColor = true;
            this.Number9_button.Click += new System.EventHandler(this.UpdateDisplay);
            // 
            // Number0_button
            // 
            this.Number0_button.Location = new System.Drawing.Point(30, 334);
            this.Number0_button.Name = "Number0_button";
            this.Number0_button.Size = new System.Drawing.Size(59, 50);
            this.Number0_button.TabIndex = 9;
            this.Number0_button.Text = "0";
            this.Number0_button.UseVisualStyleBackColor = true;
            this.Number0_button.Click += new System.EventHandler(this.UpdateDisplay);
            // 
            // Enter_button
            // 
            this.Enter_button.Location = new System.Drawing.Point(301, 334);
            this.Enter_button.Name = "Enter_button";
            this.Enter_button.Size = new System.Drawing.Size(129, 50);
            this.Enter_button.TabIndex = 10;
            this.Enter_button.Text = "Enter";
            this.Enter_button.UseVisualStyleBackColor = true;
            this.Enter_button.Click += new System.EventHandler(this.CalculateResult);
            // 
            // Clear_button
            // 
            this.Clear_button.Location = new System.Drawing.Point(205, 334);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(59, 50);
            this.Clear_button.TabIndex = 11;
            this.Clear_button.Text = "C";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.ClearDisplay);
            // 
            // Point_button
            // 
            this.Point_button.Location = new System.Drawing.Point(117, 334);
            this.Point_button.Name = "Point_button";
            this.Point_button.Size = new System.Drawing.Size(59, 50);
            this.Point_button.TabIndex = 12;
            this.Point_button.Text = ".";
            this.Point_button.UseVisualStyleBackColor = true;
            this.Point_button.Click += new System.EventHandler(this.UpdateDisplay);
            // 
            // Result_textBox
            // 
            this.Result_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result_textBox.Location = new System.Drawing.Point(31, 69);
            this.Result_textBox.Name = "Result_textBox";
            this.Result_textBox.Size = new System.Drawing.Size(232, 38);
            this.Result_textBox.TabIndex = 13;
            // 
            // Expression_textBox
            // 
            this.Expression_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expression_textBox.Location = new System.Drawing.Point(31, 25);
            this.Expression_textBox.Name = "Expression_textBox";
            this.Expression_textBox.Size = new System.Drawing.Size(232, 38);
            this.Expression_textBox.TabIndex = 14;
            // 
            // Expression_label
            // 
            this.Expression_label.AutoSize = true;
            this.Expression_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expression_label.Location = new System.Drawing.Point(281, 35);
            this.Expression_label.Name = "Expression_label";
            this.Expression_label.Size = new System.Drawing.Size(115, 24);
            this.Expression_label.TabIndex = 15;
            this.Expression_label.Text = "Expression";
            // 
            // Result_label
            // 
            this.Result_label.AutoSize = true;
            this.Result_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result_label.Location = new System.Drawing.Point(281, 79);
            this.Result_label.Name = "Result_label";
            this.Result_label.Size = new System.Drawing.Size(68, 24);
            this.Result_label.TabIndex = 16;
            this.Result_label.Text = "Result";
            // 
            // Add_button
            // 
            this.Add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_button.Location = new System.Drawing.Point(301, 198);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(59, 50);
            this.Add_button.TabIndex = 17;
            this.Add_button.Text = "+";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.UpdateDisplay);
            // 
            // Multiply_button
            // 
            this.Multiply_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiply_button.Location = new System.Drawing.Point(301, 266);
            this.Multiply_button.Name = "Multiply_button";
            this.Multiply_button.Size = new System.Drawing.Size(59, 50);
            this.Multiply_button.TabIndex = 18;
            this.Multiply_button.Text = "x";
            this.Multiply_button.UseVisualStyleBackColor = true;
            this.Multiply_button.Click += new System.EventHandler(this.UpdateDisplay);
            // 
            // Subtract_button
            // 
            this.Subtract_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtract_button.Location = new System.Drawing.Point(371, 200);
            this.Subtract_button.Name = "Subtract_button";
            this.Subtract_button.Size = new System.Drawing.Size(59, 50);
            this.Subtract_button.TabIndex = 19;
            this.Subtract_button.Text = "-";
            this.Subtract_button.UseVisualStyleBackColor = true;
            this.Subtract_button.Click += new System.EventHandler(this.UpdateDisplay);
            // 
            // Divide_button
            // 
            this.Divide_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divide_button.Location = new System.Drawing.Point(371, 266);
            this.Divide_button.Name = "Divide_button";
            this.Divide_button.Size = new System.Drawing.Size(59, 50);
            this.Divide_button.TabIndex = 20;
            this.Divide_button.Text = "/";
            this.Divide_button.UseVisualStyleBackColor = true; 
            this.Divide_button.Click += new System.EventHandler(this.UpdateDisplay);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Divide_button);
            this.Controls.Add(this.Subtract_button);
            this.Controls.Add(this.Multiply_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Result_label);
            this.Controls.Add(this.Expression_label);
            this.Controls.Add(this.Expression_textBox);
            this.Controls.Add(this.Result_textBox);
            this.Controls.Add(this.Point_button);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.Enter_button);
            this.Controls.Add(this.Number0_button);
            this.Controls.Add(this.Number9_button);
            this.Controls.Add(this.Number8_button);
            this.Controls.Add(this.Number7_button);
            this.Controls.Add(this.Number6_button);
            this.Controls.Add(this.Number5_button);
            this.Controls.Add(this.Number4_button);
            this.Controls.Add(this.Number3_button);
            this.Controls.Add(this.Number2_button);
            this.Controls.Add(this.Number1_button);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Number1_button;
        private System.Windows.Forms.Button Number2_button;
        private System.Windows.Forms.Button Number3_button;
        private System.Windows.Forms.Button Number4_button;
        private System.Windows.Forms.Button Number5_button;
        private System.Windows.Forms.Button Number6_button;
        private System.Windows.Forms.Button Number7_button;
        private System.Windows.Forms.Button Number8_button;
        private System.Windows.Forms.Button Number9_button;
        private System.Windows.Forms.Button Number0_button;
        private System.Windows.Forms.Button Enter_button;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button Point_button;
        private System.Windows.Forms.TextBox Result_textBox;
        private System.Windows.Forms.TextBox Expression_textBox;
        private System.Windows.Forms.Label Expression_label;
        private System.Windows.Forms.Label Result_label;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Multiply_button;
        private System.Windows.Forms.Button Subtract_button;
        private System.Windows.Forms.Button Divide_button;
    }
}

