namespace Tst
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dayWcomboBox = new ComboBox();
            dayMonthcomboBox = new ComboBox();
            monthComboBox = new ComboBox();
            yearComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Enterbutton = new Button();
            SuspendLayout();
            // 
            // dayWcomboBox
            // 
            dayWcomboBox.FormattingEnabled = true;
            dayWcomboBox.Location = new Point(606, 195);
            dayWcomboBox.Name = "dayWcomboBox";
            dayWcomboBox.Size = new Size(182, 33);
            dayWcomboBox.TabIndex = 0;
            // 
            // dayMonthcomboBox
            // 
            dayMonthcomboBox.FormattingEnabled = true;
            dayMonthcomboBox.Location = new Point(418, 195);
            dayMonthcomboBox.Name = "dayMonthcomboBox";
            dayMonthcomboBox.Size = new Size(182, 33);
            dayMonthcomboBox.TabIndex = 1;
            // 
            // monthComboBox
            // 
            monthComboBox.FormattingEnabled = true;
            monthComboBox.Location = new Point(218, 195);
            monthComboBox.Name = "monthComboBox";
            monthComboBox.Size = new Size(182, 33);
            monthComboBox.TabIndex = 2;
            // 
            // yearComboBox
            // 
            yearComboBox.FormattingEnabled = true;
            yearComboBox.Location = new Point(20, 195);
            yearComboBox.Name = "yearComboBox";
            yearComboBox.Size = new Size(182, 33);
            yearComboBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 133);
            label1.Name = "label1";
            label1.Size = new Size(45, 25);
            label1.TabIndex = 4;
            label1.Text = "שנה";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(293, 133);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 5;
            label2.Text = "חודש";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(479, 133);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 6;
            label3.Text = "היום בחודש";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(680, 133);
            label4.Name = "label4";
            label4.Size = new Size(101, 25);
            label4.TabIndex = 7;
            label4.Text = "היום בשבוע";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(355, 31);
            label5.Name = "label5";
            label5.Size = new Size(134, 25);
            label5.TabIndex = 8;
            label5.Text = "כתיבת  התאריך";
            // 
            // Enterbutton
            // 
            Enterbutton.Location = new Point(335, 303);
            Enterbutton.Name = "Enterbutton";
            Enterbutton.Size = new Size(112, 34);
            Enterbutton.TabIndex = 9;
            Enterbutton.Text = "Enter";
            Enterbutton.UseVisualStyleBackColor = true;
            Enterbutton.Click += Enterbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Enterbutton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(yearComboBox);
            Controls.Add(monthComboBox);
            Controls.Add(dayMonthcomboBox);
            Controls.Add(dayWcomboBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox dayWcomboBox;
        private ComboBox dayMonthcomboBox;
        private ComboBox monthComboBox;
        private ComboBox yearComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button Enterbutton;
    }
}
