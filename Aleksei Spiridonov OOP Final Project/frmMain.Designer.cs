namespace Aleksei_Spiridonov_OOP_Final_Project
{
    partial class frmMain
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
            tableLayoutPanel1 = new TableLayoutPanel();
            quitButton = new Button();
            changeButton = new Button();
            adminButton = new Button();
            startButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(quitButton, 0, 3);
            tableLayoutPanel1.Controls.Add(changeButton, 0, 2);
            tableLayoutPanel1.Controls.Add(adminButton, 0, 1);
            tableLayoutPanel1.Controls.Add(startButton, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(300, 100, 300, 100);
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(786, 461);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // quitButton
            // 
            quitButton.Dock = DockStyle.Fill;
            quitButton.Location = new Point(303, 298);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(180, 60);
            quitButton.TabIndex = 3;
            quitButton.Text = "Quit";
            quitButton.UseVisualStyleBackColor = true;
            quitButton.Click += quitButton_Click;
            // 
            // changeButton
            // 
            changeButton.Dock = DockStyle.Fill;
            changeButton.Location = new Point(303, 233);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(180, 59);
            changeButton.TabIndex = 2;
            changeButton.Text = "Change";
            changeButton.UseVisualStyleBackColor = true;
            changeButton.Click += changeButton_Click;
            // 
            // adminButton
            // 
            adminButton.Dock = DockStyle.Fill;
            adminButton.Location = new Point(303, 168);
            adminButton.Name = "adminButton";
            adminButton.Size = new Size(180, 59);
            adminButton.TabIndex = 1;
            adminButton.Text = "Admin";
            adminButton.UseVisualStyleBackColor = true;
            adminButton.Click += adminButton_Click_1;
            // 
            // startButton
            // 
            startButton.Dock = DockStyle.Fill;
            startButton.Location = new Point(303, 103);
            startButton.Name = "startButton";
            startButton.Size = new Size(180, 59);
            startButton.TabIndex = 0;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 461);
            Controls.Add(tableLayoutPanel1);
            IsMdiContainer = true;
            MaximumSize = new Size(802, 502);
            MinimumSize = new Size(800, 500);
            Name = "frmMain";
            Text = "Money Exchange - LaSalle Office";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button quitButton;
        private Button changeButton;
        private Button adminButton;
        private Button startButton;
    }
}