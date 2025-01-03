namespace Todo
{
    partial class InputFrm
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
            okBtn = new Button();
            nameTbx = new TextBox();
            nameLbl = new Label();
            Complexity = new Label();
            compCb = new ComboBox();
            timeLbl = new Label();
            timeCb = new ComboBox();
            SuspendLayout();
            // 
            // okBtn
            // 
            okBtn.Location = new Point(12, 144);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(75, 23);
            okBtn.TabIndex = 0;
            okBtn.Text = "Ok";
            okBtn.UseVisualStyleBackColor = true;
            // 
            // nameTbx
            // 
            nameTbx.Location = new Point(12, 27);
            nameTbx.Name = "nameTbx";
            nameTbx.Size = new Size(146, 23);
            nameTbx.TabIndex = 1;
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Location = new Point(12, 9);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(39, 15);
            nameLbl.TabIndex = 2;
            nameLbl.Text = "Name";
            // 
            // Complexity
            // 
            Complexity.AutoSize = true;
            Complexity.Location = new Point(12, 53);
            Complexity.Name = "Complexity";
            Complexity.Size = new Size(68, 15);
            Complexity.TabIndex = 2;
            Complexity.Text = "Complexity";
            // 
            // compCb
            // 
            compCb.FormattingEnabled = true;
            compCb.Items.AddRange(new object[] { "Easy", "Medium", "Difficult", "Impossible" });
            compCb.Location = new Point(12, 71);
            compCb.MaxDropDownItems = 4;
            compCb.Name = "compCb";
            compCb.Size = new Size(146, 23);
            compCb.TabIndex = 3;
            // 
            // timeLbl
            // 
            timeLbl.AutoSize = true;
            timeLbl.Location = new Point(12, 97);
            timeLbl.Name = "timeLbl";
            timeLbl.Size = new Size(33, 15);
            timeLbl.TabIndex = 2;
            timeLbl.Text = "Time";
            // 
            // timeCb
            // 
            timeCb.FormattingEnabled = true;
            timeCb.Items.AddRange(new object[] { "Daily", "Weekly", "Special" });
            timeCb.Location = new Point(12, 115);
            timeCb.Name = "timeCb";
            timeCb.Size = new Size(146, 23);
            timeCb.TabIndex = 3;
            // 
            // InputFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(206, 178);
            Controls.Add(timeCb);
            Controls.Add(compCb);
            Controls.Add(timeLbl);
            Controls.Add(Complexity);
            Controls.Add(nameLbl);
            Controls.Add(nameTbx);
            Controls.Add(okBtn);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "InputFrm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add new quest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button okBtn;
        private TextBox nameTbx;
        private Label nameLbl;
        private Label Complexity;
        private ComboBox compCb;
        private Label timeLbl;
        private ComboBox timeCb;
    }
}