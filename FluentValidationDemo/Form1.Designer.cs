namespace FluentValidationDemo
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
            label1 = new Label();
            fnLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            errorListBox = new ListBox();
            fnTextBox = new TextBox();
            snTextBox = new TextBox();
            abTextBox = new TextBox();
            dateTimePicker = new DateTimePicker();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 14);
            label1.Name = "label1";
            label1.Size = new Size(97, 21);
            label1.TabIndex = 0;
            label1.Text = "Create User";
            // 
            // fnLabel
            // 
            fnLabel.AutoSize = true;
            fnLabel.Location = new Point(14, 49);
            fnLabel.Name = "fnLabel";
            fnLabel.Size = new Size(64, 15);
            fnLabel.TabIndex = 1;
            fnLabel.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 78);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 2;
            label3.Text = "Second Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 107);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 3;
            label4.Text = "Account Balance";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 139);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 4;
            label5.Text = "Date of Birth";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(339, 28);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 5;
            label6.Text = "Error list";
            // 
            // errorListBox
            // 
            errorListBox.FormattingEnabled = true;
            errorListBox.ItemHeight = 15;
            errorListBox.Location = new Point(339, 46);
            errorListBox.Name = "errorListBox";
            errorListBox.Size = new Size(247, 154);
            errorListBox.TabIndex = 6;
            // 
            // fnTextBox
            // 
            fnTextBox.Location = new Point(136, 46);
            fnTextBox.Name = "fnTextBox";
            fnTextBox.Size = new Size(162, 23);
            fnTextBox.TabIndex = 7;
            // 
            // snTextBox
            // 
            snTextBox.Location = new Point(136, 75);
            snTextBox.Name = "snTextBox";
            snTextBox.Size = new Size(162, 23);
            snTextBox.TabIndex = 8;
            // 
            // abTextBox
            // 
            abTextBox.Location = new Point(136, 104);
            abTextBox.Name = "abTextBox";
            abTextBox.Size = new Size(162, 23);
            abTextBox.TabIndex = 9;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(136, 133);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(162, 23);
            dateTimePicker.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(50, 178);
            button1.Name = "button1";
            button1.Size = new Size(168, 23);
            button1.TabIndex = 11;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 215);
            Controls.Add(button1);
            Controls.Add(dateTimePicker);
            Controls.Add(abTextBox);
            Controls.Add(snTextBox);
            Controls.Add(fnTextBox);
            Controls.Add(errorListBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(fnLabel);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Fluent Validation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label fnLabel;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListBox errorListBox;
        private TextBox fnTextBox;
        private TextBox snTextBox;
        private TextBox abTextBox;
        private DateTimePicker dateTimePicker;
        private Button button1;
    }
}