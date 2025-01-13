namespace Todo
{
    partial class FrmMain
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
            lvlLbl = new Label();
            xpLbl = new Label();
            goldLbl = new Label();
            tnameLbl = new Label();
            complexityLbl = new Label();
            cardBtn = new Button();
            questBtn = new Button();
            dailyBtn = new Button();
            weeklyBtn = new Button();
            specialBtn = new Button();
            addBtn = new Button();
            MainTLP = new TableLayoutPanel();
            SuspendLayout();
            // 
            // lvlLbl
            // 
            lvlLbl.AutoSize = true;
            lvlLbl.ForeColor = Color.White;
            lvlLbl.Location = new Point(13, 9);
            lvlLbl.Name = "lvlLbl";
            lvlLbl.Size = new Size(43, 15);
            lvlLbl.TabIndex = 1;
            lvlLbl.Text = "Level 5";
            // 
            // xpLbl
            // 
            xpLbl.AutoSize = true;
            xpLbl.ForeColor = Color.White;
            xpLbl.Location = new Point(74, 9);
            xpLbl.Name = "xpLbl";
            xpLbl.Size = new Size(52, 15);
            xpLbl.TabIndex = 2;
            xpLbl.Text = "5/100 xp";
            // 
            // goldLbl
            // 
            goldLbl.AutoSize = true;
            goldLbl.ForeColor = Color.White;
            goldLbl.Location = new Point(297, 9);
            goldLbl.Name = "goldLbl";
            goldLbl.Size = new Size(38, 15);
            goldLbl.TabIndex = 3;
            goldLbl.Text = "9999g";
            // 
            // tnameLbl
            // 
            tnameLbl.AutoSize = true;
            tnameLbl.ForeColor = Color.White;
            tnameLbl.Location = new Point(13, 49);
            tnameLbl.Name = "tnameLbl";
            tnameLbl.Size = new Size(62, 15);
            tnameLbl.TabIndex = 4;
            tnameLbl.Text = "Task name";
            // 
            // complexityLbl
            // 
            complexityLbl.AutoSize = true;
            complexityLbl.ForeColor = Color.White;
            complexityLbl.Location = new Point(99, 49);
            complexityLbl.Name = "complexityLbl";
            complexityLbl.Size = new Size(68, 15);
            complexityLbl.TabIndex = 4;
            complexityLbl.Text = "Complexity";
            // 
            // cardBtn
            // 
            cardBtn.BackColor = Color.DarkGray;
            cardBtn.FlatAppearance.BorderSize = 0;
            cardBtn.FlatStyle = FlatStyle.Flat;
            cardBtn.ForeColor = Color.White;
            cardBtn.Location = new Point(67, 509);
            cardBtn.Name = "cardBtn";
            cardBtn.Size = new Size(100, 40);
            cardBtn.TabIndex = 6;
            cardBtn.Text = "Cards";
            cardBtn.UseVisualStyleBackColor = false;
            // 
            // questBtn
            // 
            questBtn.BackColor = Color.DarkGray;
            questBtn.FlatAppearance.BorderSize = 0;
            questBtn.FlatStyle = FlatStyle.Flat;
            questBtn.ForeColor = Color.White;
            questBtn.Location = new Point(211, 509);
            questBtn.Name = "questBtn";
            questBtn.Size = new Size(100, 40);
            questBtn.TabIndex = 6;
            questBtn.Text = "Quests";
            questBtn.UseVisualStyleBackColor = false;
            // 
            // dailyBtn
            // 
            dailyBtn.BackColor = Color.DarkGray;
            dailyBtn.FlatAppearance.BorderSize = 0;
            dailyBtn.FlatStyle = FlatStyle.Flat;
            dailyBtn.ForeColor = Color.White;
            dailyBtn.Location = new Point(12, 472);
            dailyBtn.Name = "dailyBtn";
            dailyBtn.Size = new Size(103, 23);
            dailyBtn.TabIndex = 7;
            dailyBtn.Text = "Daily";
            dailyBtn.UseVisualStyleBackColor = false;
            // 
            // weeklyBtn
            // 
            weeklyBtn.BackColor = Color.DarkGray;
            weeklyBtn.FlatAppearance.BorderSize = 0;
            weeklyBtn.FlatStyle = FlatStyle.Flat;
            weeklyBtn.ForeColor = Color.White;
            weeklyBtn.Location = new Point(140, 472);
            weeklyBtn.Name = "weeklyBtn";
            weeklyBtn.Size = new Size(103, 23);
            weeklyBtn.TabIndex = 7;
            weeklyBtn.Text = "Weekly";
            weeklyBtn.UseVisualStyleBackColor = false;
            // 
            // specialBtn
            // 
            specialBtn.BackColor = Color.DarkGray;
            specialBtn.FlatAppearance.BorderSize = 0;
            specialBtn.FlatStyle = FlatStyle.Flat;
            specialBtn.ForeColor = Color.White;
            specialBtn.Location = new Point(269, 472);
            specialBtn.Name = "specialBtn";
            specialBtn.Size = new Size(103, 23);
            specialBtn.TabIndex = 7;
            specialBtn.Text = "Special";
            specialBtn.UseVisualStyleBackColor = false;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.DarkGray;
            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.ForeColor = Color.White;
            addBtn.Location = new Point(269, 45);
            addBtn.Margin = new Padding(0);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(103, 23);
            addBtn.TabIndex = 7;
            addBtn.Text = "Add quest";
            addBtn.UseVisualStyleBackColor = false;
            // 
            // MainTLP
            // 
            MainTLP.ColumnCount = 4;
            MainTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            MainTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            MainTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            MainTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            MainTLP.Location = new Point(13, 74);
            MainTLP.Name = "MainTLP";
            MainTLP.RowCount = 10;
            MainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            MainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            MainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            MainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            MainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            MainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            MainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            MainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            MainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            MainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            MainTLP.Size = new Size(359, 392);
            MainTLP.TabIndex = 8;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(384, 561);
            Controls.Add(MainTLP);
            Controls.Add(specialBtn);
            Controls.Add(weeklyBtn);
            Controls.Add(addBtn);
            Controls.Add(dailyBtn);
            Controls.Add(questBtn);
            Controls.Add(cardBtn);
            Controls.Add(complexityLbl);
            Controls.Add(tnameLbl);
            Controls.Add(goldLbl);
            Controls.Add(xpLbl);
            Controls.Add(lvlLbl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lvlLbl;
        private Label xpLbl;
        private Label goldLbl;
        private Label tnameLbl;
        private Label complexityLbl;
        private Button cardBtn;
        private Button questBtn;
        private Button dailyBtn;
        private Button weeklyBtn;
        private Button specialBtn;
        private Button addBtn;
        private TableLayoutPanel MainTLP;
    }
}
