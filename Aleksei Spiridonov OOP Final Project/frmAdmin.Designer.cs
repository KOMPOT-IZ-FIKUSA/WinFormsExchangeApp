namespace Aleksei_Spiridonov_OOP_Final_Project
{
    partial class frmAdmin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            nameInputFIeld = new TextBox();
            valueInputField = new TextBox();
            countryInputField = new TextBox();
            addButton = new Button();
            deleteButton = new Button();
            editButton = new Button();
            saveButton = new Button();
            cancelButton = new Button();
            lastButton = new Button();
            nextButton = new Button();
            previousButton = new Button();
            firstButton = new Button();
            positionLabel = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 52);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 96);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "Value:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 154);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 2;
            label3.Text = "Country Name:";
            // 
            // nameInputFIeld
            // 
            nameInputFIeld.Enabled = false;
            nameInputFIeld.Location = new Point(164, 49);
            nameInputFIeld.Name = "nameInputFIeld";
            nameInputFIeld.Size = new Size(155, 23);
            nameInputFIeld.TabIndex = 3;
            nameInputFIeld.TextChanged += textBox1_TextChanged;
            // 
            // valueInputField
            // 
            valueInputField.Enabled = false;
            valueInputField.Location = new Point(164, 97);
            valueInputField.Name = "valueInputField";
            valueInputField.Size = new Size(76, 23);
            valueInputField.TabIndex = 4;
            valueInputField.TextChanged += valueInputField_TextChanged;
            // 
            // countryInputField
            // 
            countryInputField.Enabled = false;
            countryInputField.Location = new Point(164, 151);
            countryInputField.Name = "countryInputField";
            countryInputField.Size = new Size(155, 23);
            countryInputField.TabIndex = 5;
            countryInputField.TextChanged += countryInputField_TextChanged;
            // 
            // addButton
            // 
            addButton.Location = new Point(341, 49);
            addButton.Name = "addButton";
            addButton.Size = new Size(77, 32);
            addButton.TabIndex = 6;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(341, 87);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(77, 32);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(341, 125);
            editButton.Name = "editButton";
            editButton.Size = new Size(77, 32);
            editButton.TabIndex = 8;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(341, 163);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(77, 32);
            saveButton.TabIndex = 9;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(341, 201);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(77, 32);
            cancelButton.TabIndex = 10;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // lastButton
            // 
            lastButton.Location = new Point(258, 201);
            lastButton.Name = "lastButton";
            lastButton.Size = new Size(77, 32);
            lastButton.TabIndex = 11;
            lastButton.Text = "Last";
            lastButton.UseVisualStyleBackColor = true;
            lastButton.Click += lastButton_Click;
            // 
            // nextButton
            // 
            nextButton.Location = new Point(175, 201);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(77, 32);
            nextButton.TabIndex = 12;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // previousButton
            // 
            previousButton.Location = new Point(92, 201);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(77, 32);
            previousButton.TabIndex = 13;
            previousButton.Text = "Previous";
            previousButton.UseVisualStyleBackColor = true;
            previousButton.Click += previousButton_Click;
            // 
            // firstButton
            // 
            firstButton.Location = new Point(9, 201);
            firstButton.Name = "firstButton";
            firstButton.Size = new Size(77, 32);
            firstButton.TabIndex = 14;
            firstButton.Text = "First";
            firstButton.UseVisualStyleBackColor = true;
            firstButton.Click += firstButton_Click;
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new Point(12, 247);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new Size(60, 15);
            positionLabel.TabIndex = 15;
            positionLabel.Text = "lbPosition";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(257, 100);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 16;
            label4.Text = "US Dollar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label5.Location = new Point(114, 4);
            label5.Name = "label5";
            label5.Size = new Size(205, 32);
            label5.TabIndex = 17;
            label5.Text = "Admin Exchange";
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 282);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(positionLabel);
            Controls.Add(firstButton);
            Controls.Add(previousButton);
            Controls.Add(nextButton);
            Controls.Add(lastButton);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(editButton);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Controls.Add(countryInputField);
            Controls.Add(valueInputField);
            Controls.Add(nameInputFIeld);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(451, 321);
            MinimumSize = new Size(450, 320);
            Name = "frmAdmin";
            Text = "Money Exchange - LaSalle Office";
            Load += frmAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox nameInputFIeld;
        private TextBox valueInputField;
        private TextBox countryInputField;
        private Button addButton;
        private Button deleteButton;
        private Button editButton;
        private Button saveButton;
        private Button cancelButton;
        private Button lastButton;
        private Button nextButton;
        private Button previousButton;
        private Button firstButton;
        private Label positionLabel;
        private Label label4;
        private Label label5;
    }
}