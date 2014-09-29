namespace CalculatorAPP
{
    partial class CalcualtorAppUI
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
            this.fi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.firstNoTextBox = new System.Windows.Forms.TextBox();
            this.secondNoTextBox = new System.Windows.Forms.TextBox();
            this.resutTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.subtracButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fi
            // 
            this.fi.AutoSize = true;
            this.fi.Location = new System.Drawing.Point(11, 36);
            this.fi.Name = "fi";
            this.fi.Size = new System.Drawing.Size(66, 13);
            this.fi.TabIndex = 0;
            this.fi.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result";
            // 
            // firstNoTextBox
            // 
            this.firstNoTextBox.Location = new System.Drawing.Point(148, 41);
            this.firstNoTextBox.Name = "firstNoTextBox";
            this.firstNoTextBox.Size = new System.Drawing.Size(161, 20);
            this.firstNoTextBox.TabIndex = 3;
            // 
            // secondNoTextBox
            // 
            this.secondNoTextBox.Location = new System.Drawing.Point(148, 98);
            this.secondNoTextBox.Name = "secondNoTextBox";
            this.secondNoTextBox.Size = new System.Drawing.Size(161, 20);
            this.secondNoTextBox.TabIndex = 4;
            // 
            // resutTextBox
            // 
            this.resutTextBox.Location = new System.Drawing.Point(148, 138);
            this.resutTextBox.Name = "resutTextBox";
            this.resutTextBox.Size = new System.Drawing.Size(161, 20);
            this.resutTextBox.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(20, 246);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subtracButton
            // 
            this.subtracButton.Location = new System.Drawing.Point(137, 246);
            this.subtracButton.Name = "subtracButton";
            this.subtracButton.Size = new System.Drawing.Size(75, 23);
            this.subtracButton.TabIndex = 7;
            this.subtracButton.Text = "Subtract";
            this.subtracButton.UseVisualStyleBackColor = true;
            this.subtracButton.Click += new System.EventHandler(this.subtracButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(244, 246);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(75, 23);
            this.multiplyButton.TabIndex = 8;
            this.multiplyButton.Text = "Multiply";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(373, 246);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(75, 23);
            this.divideButton.TabIndex = 9;
            this.divideButton.Text = "Divide";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // CalcualtorAppUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 326);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.subtracButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.resutTextBox);
            this.Controls.Add(this.secondNoTextBox);
            this.Controls.Add(this.firstNoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fi);
            this.Name = "CalcualtorAppUI";
            this.Text = "Calcualtor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstNoTextBox;
        private System.Windows.Forms.TextBox secondNoTextBox;
        private System.Windows.Forms.TextBox resutTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtracButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divideButton;
    }
}

