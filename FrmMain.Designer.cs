﻿namespace Todo
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
            statBtn = new Button();
            questBtn = new Button();
            shopBtn = new Button();
            dailyBtn = new Button();
            weeklyBtn = new Button();
            specialBtn = new Button();
            addBtn = new Button();
            MainTLP = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            delBtn = new Button();
            completeBtn = new Button();
            MainTLP.SuspendLayout();
            SuspendLayout();
            // 
            // lvlLbl
            // 
            lvlLbl.AutoSize = true;
            lvlLbl.Location = new Point(13, 9);
            lvlLbl.Name = "lvlLbl";
            lvlLbl.Size = new Size(43, 15);
            lvlLbl.TabIndex = 1;
            lvlLbl.Text = "Level 5";
            // 
            // xpLbl
            // 
            xpLbl.AutoSize = true;
            xpLbl.Location = new Point(74, 9);
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
            complexityLbl.Location = new Point(99, 49);
            complexityLbl.Name = "complexityLbl";
            complexityLbl.Size = new Size(68, 15);
            complexityLbl.TabIndex = 4;
            complexityLbl.Text = "Complexity";
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
            // specialBtn
            // 
            specialBtn.Location = new Point(269, 472);
            specialBtn.Name = "specialBtn";
            specialBtn.Size = new Size(103, 23);
            specialBtn.TabIndex = 7;
            specialBtn.Text = "Special";
            specialBtn.UseVisualStyleBackColor = true;
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
            // MainTLP
            // 
            MainTLP.ColumnCount = 4;
            MainTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            MainTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            MainTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            MainTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            MainTLP.Controls.Add(label1, 0, 0);
            MainTLP.Controls.Add(label2, 1, 0);
            MainTLP.Controls.Add(delBtn, 3, 0);
            MainTLP.Controls.Add(completeBtn, 2, 0);
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
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 39);
            label1.TabIndex = 0;
            label1.Text = "nev";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(92, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 39);
            label2.TabIndex = 0;
            label2.Text = "hard";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // delBtn
            // 
            delBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            delBtn.Location = new Point(270, 3);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(86, 33);
            delBtn.TabIndex = 1;
            delBtn.Text = "Delete";
            delBtn.UseVisualStyleBackColor = true;
            // 
            // completeBtn
            // 
            completeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            completeBtn.Location = new Point(181, 3);
            completeBtn.Name = "completeBtn";
            completeBtn.Size = new Size(83, 33);
            completeBtn.TabIndex = 1;
            completeBtn.Text = "Complete";
            completeBtn.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 561);
            Controls.Add(MainTLP);
            Controls.Add(specialBtn);
            Controls.Add(weeklyBtn);
            Controls.Add(addBtn);
            Controls.Add(dailyBtn);
            Controls.Add(shopBtn);
            Controls.Add(questBtn);
            Controls.Add(statBtn);
            Controls.Add(complexityLbl);
            Controls.Add(tnameLbl);
            Controls.Add(goldLbl);
            Controls.Add(xpLbl);
            Controls.Add(lvlLbl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FrmMain_Load;
            MainTLP.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lvlLbl;
        private Label xpLbl;
        private Label goldLbl;
        private Label tnameLbl;
        private Label complexityLbl;
        private Button statBtn;
        private Button questBtn;
        private Button shopBtn;
        private Button dailyBtn;
        private Button weeklyBtn;
        private Button specialBtn;
        private Button addBtn;
        private TableLayoutPanel MainTLP;
        private Label label1;
        private Label label2;
        private Button delBtn;
        private Button completeBtn;
    }
}
