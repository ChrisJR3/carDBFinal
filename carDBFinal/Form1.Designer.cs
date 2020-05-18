namespace carDBFinal
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
            this.exitButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.mileageInput = new System.Windows.Forms.TextBox();
            this.colourInput = new System.Windows.Forms.TextBox();
            this.makeInput = new System.Windows.Forms.TextBox();
            this.yearInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(170, 122);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(64, 23);
            this.exitButton.TabIndex = 21;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Mileage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Colour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Make";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Year";
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(12, 170);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(300, 271);
            this.outputLabel.TabIndex = 16;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(72, 122);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(64, 23);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // mileageInput
            // 
            this.mileageInput.Location = new System.Drawing.Point(72, 89);
            this.mileageInput.Name = "mileageInput";
            this.mileageInput.Size = new System.Drawing.Size(127, 20);
            this.mileageInput.TabIndex = 14;
            // 
            // colourInput
            // 
            this.colourInput.Location = new System.Drawing.Point(72, 63);
            this.colourInput.Name = "colourInput";
            this.colourInput.Size = new System.Drawing.Size(127, 20);
            this.colourInput.TabIndex = 13;
            // 
            // makeInput
            // 
            this.makeInput.Location = new System.Drawing.Point(72, 37);
            this.makeInput.Name = "makeInput";
            this.makeInput.Size = new System.Drawing.Size(127, 20);
            this.makeInput.TabIndex = 12;
            // 
            // yearInput
            // 
            this.yearInput.Location = new System.Drawing.Point(72, 11);
            this.yearInput.Name = "yearInput";
            this.yearInput.Size = new System.Drawing.Size(127, 20);
            this.yearInput.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.mileageInput);
            this.Controls.Add(this.colourInput);
            this.Controls.Add(this.makeInput);
            this.Controls.Add(this.yearInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox mileageInput;
        private System.Windows.Forms.TextBox colourInput;
        private System.Windows.Forms.TextBox makeInput;
        private System.Windows.Forms.TextBox yearInput;
    }
}

