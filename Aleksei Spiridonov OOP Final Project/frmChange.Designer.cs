namespace Aleksei_Spiridonov_OOP_Final_Project
{
    partial class frmChange
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
            currencySelectionComboBox = new ComboBox();
            groupBox1 = new GroupBox();
            fromDollarButton = new RadioButton();
            toDollarButton = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            amountTextBox = new TextBox();
            groupBox2 = new GroupBox();
            labelToDollar = new Label();
            labelFromDollar = new Label();
            exchangeButton = new Button();
            resetButton = new Button();
            quitButton = new Button();
            groupBox3 = new GroupBox();
            exchengeResultLabel = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // currencySelectionComboBox
            // 
            currencySelectionComboBox.FormattingEnabled = true;
            currencySelectionComboBox.Items.AddRange(new object[] { "1", "2" });
            currencySelectionComboBox.Location = new Point(101, 115);
            currencySelectionComboBox.Name = "currencySelectionComboBox";
            currencySelectionComboBox.Size = new Size(200, 23);
            currencySelectionComboBox.TabIndex = 0;
            currencySelectionComboBox.Text = "Select a Currency...";
            currencySelectionComboBox.SelectedIndexChanged += currencySelectionComboBox_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(fromDollarButton);
            groupBox1.Controls.Add(toDollarButton);
            groupBox1.Location = new Point(101, 162);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Exchange:";
            // 
            // fromDollarButton
            // 
            fromDollarButton.AutoSize = true;
            fromDollarButton.Location = new Point(23, 56);
            fromDollarButton.Name = "fromDollarButton";
            fromDollarButton.Size = new Size(87, 19);
            fromDollarButton.TabIndex = 3;
            fromDollarButton.Text = "From Dollar";
            fromDollarButton.UseVisualStyleBackColor = true;
            // 
            // toDollarButton
            // 
            toDollarButton.AutoSize = true;
            toDollarButton.Checked = true;
            toDollarButton.Location = new Point(23, 22);
            toDollarButton.Name = "toDollarButton";
            toDollarButton.Size = new Size(71, 19);
            toDollarButton.TabIndex = 2;
            toDollarButton.TabStop = true;
            toDollarButton.Text = "To Dollar";
            toDollarButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(239, 9);
            label1.Name = "label1";
            label1.Size = new Size(309, 50);
            label1.TabIndex = 2;
            label1.Text = "Money Exchange";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(438, 118);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 3;
            label2.Text = "Amount:";
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(498, 115);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(178, 23);
            amountTextBox.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelToDollar);
            groupBox2.Controls.Add(labelFromDollar);
            groupBox2.Location = new Point(438, 162);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Currency Information:";
            // 
            // labelToDollar
            // 
            labelToDollar.AutoSize = true;
            labelToDollar.Location = new Point(34, 26);
            labelToDollar.Name = "labelToDollar";
            labelToDollar.Size = new Size(60, 15);
            labelToDollar.TabIndex = 1;
            labelToDollar.Text = "lbToDollar";
            // 
            // labelFromDollar
            // 
            labelFromDollar.AutoSize = true;
            labelFromDollar.Location = new Point(34, 58);
            labelFromDollar.Name = "labelFromDollar";
            labelFromDollar.Size = new Size(76, 15);
            labelFromDollar.TabIndex = 0;
            labelFromDollar.Text = "lbFromDollar";
            // 
            // exchangeButton
            // 
            exchangeButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            exchangeButton.Location = new Point(152, 316);
            exchangeButton.Name = "exchangeButton";
            exchangeButton.Size = new Size(97, 36);
            exchangeButton.TabIndex = 5;
            exchangeButton.Text = "Exchange";
            exchangeButton.UseVisualStyleBackColor = true;
            exchangeButton.Click += exchangeButton_Click;
            // 
            // resetButton
            // 
            resetButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            resetButton.Location = new Point(325, 316);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(97, 36);
            resetButton.TabIndex = 6;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // quitButton
            // 
            quitButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            quitButton.Location = new Point(498, 316);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(97, 36);
            quitButton.TabIndex = 7;
            quitButton.Text = "Quit";
            quitButton.UseVisualStyleBackColor = true;
            quitButton.Click += quitButton_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(exchengeResultLabel);
            groupBox3.Location = new Point(219, 371);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(313, 75);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Exchange Result:";
            // 
            // exchengeResultLabel
            // 
            exchengeResultLabel.AutoSize = true;
            exchengeResultLabel.ForeColor = Color.Magenta;
            exchengeResultLabel.Location = new Point(87, 33);
            exchengeResultLabel.Name = "exchengeResultLabel";
            exchengeResultLabel.Size = new Size(49, 15);
            exchengeResultLabel.TabIndex = 0;
            exchengeResultLabel.Text = "lbResult";
            // 
            // frmChange
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(groupBox3);
            Controls.Add(quitButton);
            Controls.Add(resetButton);
            Controls.Add(exchangeButton);
            Controls.Add(groupBox2);
            Controls.Add(amountTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(currencySelectionComboBox);
            MaximumSize = new Size(802, 502);
            MinimumSize = new Size(800, 500);
            Name = "frmChange";
            Text = "Money Exchange - LaSalle Office";
            Load += frmChange_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox currencySelectionComboBox;
        private GroupBox groupBox1;
        private RadioButton fromDollarButton;
        private RadioButton toDollarButton;
        private Label label1;
        private Label label2;
        private TextBox amountTextBox;
        private GroupBox groupBox2;
        private Label labelToDollar;
        private Label labelFromDollar;
        private Button exchangeButton;
        private Button resetButton;
        private Button quitButton;
        private GroupBox groupBox3;
        private Label exchengeResultLabel;
    }
}
