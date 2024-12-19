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
            nameLbl = new Label();
            lvlLbl = new Label();
            xpLbl = new Label();
            goldLbl = new Label();
            tnameLbl = new Label();
            complexityLbl = new Label();
            questLbx = new CheckedListBox();
            statBtn = new Button();
            questBtn = new Button();
            shopBtn = new Button();
            dailyBtn = new Button();
            weeklyBtn = new Button();
            specialButton = new Button();
            addBtn = new Button();
            SuspendLayout();
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Location = new Point(12, 9);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(39, 15);
            nameLbl.TabIndex = 0;
            nameLbl.Text = "Name";
            // 
            // lvlLbl
            // 
            lvlLbl.AutoSize = true;
            lvlLbl.Location = new Point(73, 9);
            lvlLbl.Name = "lvlLbl";
            lvlLbl.Size = new Size(43, 15);
            lvlLbl.TabIndex = 1;
            lvlLbl.Text = "Level 5";
            // 
            // xpLbl
            // 
            xpLbl.AutoSize = true;
            xpLbl.Location = new Point(140, 9);
            xpLbl.Name = "xpLbl";
            xpLbl.Size = new Size(52, 15);
            xpLbl.TabIndex = 2;
            xpLbl.Text = "5/100 xp";
            // 
            // goldLbl
            // 
            goldLbl.AutoSize = true;
            goldLbl.Location = new Point(297, 9);
            goldLbl.Name = "goldLbl";
            goldLbl.Size = new Size(38, 15);
            goldLbl.TabIndex = 3;
            goldLbl.Text = "9999g";
            // 
            // tnameLbl
            // 
            tnameLbl.AutoSize = true;
            tnameLbl.Location = new Point(13, 49);
            tnameLbl.Name = "tnameLbl";
            tnameLbl.Size = new Size(62, 15);
            tnameLbl.TabIndex = 4;
            tnameLbl.Text = "Task name";
            // 
            // complexityLbl
            // 
            complexityLbl.AutoSize = true;
            complexityLbl.Location = new Point(190, 49);
            complexityLbl.Name = "complexityLbl";
            complexityLbl.Size = new Size(68, 15);
            complexityLbl.TabIndex = 4;
            complexityLbl.Text = "Complexity";
            // 
            // questLbx
            // 
            questLbx.FormattingEnabled = true;
            questLbx.Location = new Point(12, 79);
            questLbx.Name = "questLbx";
            questLbx.Size = new Size(360, 364);
            questLbx.TabIndex = 5;
            // 
            // statBtn
            // 
            statBtn.Location = new Point(12, 512);
            statBtn.Name = "statBtn";
            statBtn.Size = new Size(100, 40);
            statBtn.TabIndex = 6;
            statBtn.Text = "Stats";
            statBtn.UseVisualStyleBackColor = true;
            // 
            // questBtn
            // 
            questBtn.Location = new Point(140, 512);
            questBtn.Name = "questBtn";
            questBtn.Size = new Size(100, 40);
            questBtn.TabIndex = 6;
            questBtn.Text = "Quests";
            questBtn.UseVisualStyleBackColor = true;
            // 
            // shopBtn
            // 
            shopBtn.Location = new Point(272, 512);
            shopBtn.Name = "shopBtn";
            shopBtn.Size = new Size(100, 40);
            shopBtn.TabIndex = 6;
            shopBtn.Text = "Shop";
            shopBtn.UseVisualStyleBackColor = true;
            // 
            // dailyBtn
            // 
            dailyBtn.Location = new Point(12, 472);
            dailyBtn.Name = "dailyBtn";
            dailyBtn.Size = new Size(103, 23);
            dailyBtn.TabIndex = 7;
            dailyBtn.Text = "Daily";
            dailyBtn.UseVisualStyleBackColor = true;
            // 
            // weeklyBtn
            // 
            weeklyBtn.Location = new Point(140, 472);
            weeklyBtn.Name = "weeklyBtn";
            weeklyBtn.Size = new Size(103, 23);
            weeklyBtn.TabIndex = 7;
            weeklyBtn.Text = "Weekly";
            weeklyBtn.UseVisualStyleBackColor = true;
            // 
            // specialButton
            // 
            specialButton.Location = new Point(269, 472);
            specialButton.Name = "specialButton";
            specialButton.Size = new Size(103, 23);
            specialButton.TabIndex = 7;
            specialButton.Text = "Special";
            specialButton.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(269, 45);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(103, 23);
            addBtn.TabIndex = 7;
            addBtn.Text = "Add quest";
            addBtn.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 561);
            Controls.Add(specialButton);
            Controls.Add(weeklyBtn);
            Controls.Add(addBtn);
            Controls.Add(dailyBtn);
            Controls.Add(shopBtn);
            Controls.Add(questBtn);
            Controls.Add(statBtn);
            Controls.Add(questLbx);
            Controls.Add(complexityLbl);
            Controls.Add(tnameLbl);
            Controls.Add(goldLbl);
            Controls.Add(xpLbl);
            Controls.Add(lvlLbl);
            Controls.Add(nameLbl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLbl;
        private Label lvlLbl;
        private Label xpLbl;
        private Label goldLbl;
        private Label tnameLbl;
        private Label complexityLbl;
        private CheckedListBox questLbx;
        private Button statBtn;
        private Button questBtn;
        private Button shopBtn;
        private Button dailyBtn;
        private Button weeklyBtn;
        private Button specialButton;
        private Button addBtn;
    }
}
