using Microsoft.VisualBasic;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Todo
{
    public partial class FrmMain : Form
    {
        public User user;
        List<Quest> quests = new();
        int id = 0;

        public FrmMain()
        {
            InitializeComponent();
            this.Load += LoadUserData;
            this.Load += LoadQuestData;
            addBtn.Click += AddBtnClick;
            dailyBtn.Click += TimeBtnClick;
            weeklyBtn.Click += TimeBtnClick;
            specialBtn.Click += TimeBtnClick;
            cardBtn.Click += CardBtnClick;
            this.Shown += FrmMainShown;

            this.FormClosing += SaveUserData;
            this.FormClosing += SaveQuestData;

        }

        private void CardBtnClick(object? sender, EventArgs e)
        {
            CardInventory CiFrm = new();
            CiFrm.Show(this);
            CiFrm.FormClosed += CiFrmFormClosed;
        }

        private void CiFrmFormClosed(object? sender, FormClosedEventArgs e)
        {
            StatRefresh();
        }

        private void SaveQuestData(object? sender, FormClosingEventArgs e)
        {
            FileStream fs = new("questdata.bin", FileMode.Create);

            using (BinaryWriter bw = new(fs))
            {
                foreach (Quest quest in quests)
                {
                    bw.Write(quest.Id);
                    bw.Write(quest.Name);
                    bw.Write(quest.Completed);
                    bw.Write(quest.Complexity);
                    bw.Write(quest.Time);
                    bw.Write(quest.CompTime);
                }
            }

            fs.Close();
        }

        private void LoadQuestData(object? sender, EventArgs e)
        {
            FileStream fs = new("questdata.bin", FileMode.OpenOrCreate);

            if (fs.Length == 0)
            {
                fs.Close();
                return;
            }

            using (BinaryReader br = new(fs))
            {
                while (br.PeekChar() != -1)
                {
                    int id = br.ReadInt32();
                    string name = br.ReadString();
                    bool completed = br.ReadBoolean();
                    string complexity = br.ReadString();
                    string time = br.ReadString();
                    string compTime = br.ReadString();
                    Quest q = new(name, complexity, time, id, completed, compTime);
                    quests.Add(q);
                }
            }

            fs.Close();
        }

        private void LoadUserData(object? sender, EventArgs e)
        {
            FileStream fs = new("userdata.bin", FileMode.OpenOrCreate);

            if (fs.Length == 0)
            {
                user = new();
            } else
            {
                using (BinaryReader br = new(fs))
                {
                    int money = br.ReadInt32();
                    int xp = br.ReadInt32();
                    int lvl = br.ReadInt32();
                    user = new(lvl, xp, money);
                    
                }
            }


            fs.Close();
            StatRefresh();
        }

        private void SaveUserData(object? sender, FormClosingEventArgs e)
        {
            FileStream fs = new("userdata.bin", FileMode.OpenOrCreate);

            using(BinaryWriter bw = new(fs))
            {
                bw.Write((int)user.Money);
                bw.Write((int)user.Xp);
                bw.Write((int)user.Lvl); 
            }
            fs.Close();
        }

        private void TimeBtnClick(object? sender, EventArgs e)
        {
            Button btn = sender as Button;
            foreach (var item in this.Controls)
            {
              if (item is Button)
                {
                    Button btnColor = item as Button;
                    btnColor.BackColor = Color.DarkGray;
                }
            }
            btn.BackColor = Color.LightSlateGray;
            DisplayQuests(btn.Text);
        }

        private void DisplayQuests(string time)
        {
            MainTLP.Controls.Clear();
            MainTLP.RowCount = 0;
            MainTLP.RowCount = 10;

            string date = DateTime.Today.Date.ToString("dd");

            foreach (Quest quest in quests)
            {
                if (quest.CompTime != date)
                {
                    quest.CompTime = "";
                    quest.Completed = false;
                }

                if (quest.Time == time)
                {
                    Label name = new();
                    name.Text = quest.Name;
                    name.Name = quest.Id.ToString();
                    name.ForeColor = Color.White;
                    name.TextAlign = ContentAlignment.MiddleCenter;
                    MainTLP.Controls.Add(name);
                    Label comp = new();
                    comp.Text = quest.Complexity;
                    comp.Name = quest.Id.ToString();
                    comp.ForeColor = Color.White;
                    comp.TextAlign = ContentAlignment.MiddleCenter;
                    MainTLP.Controls.Add(comp);
                    Button complete = new();
                    complete.Text = "Complete";
                    complete.Name = quest.Id.ToString();
                    complete.ForeColor = Color.White;
                    complete.BackColor = Color.DarkGray;
                    complete.FlatAppearance.BorderSize = 0;
                    if (quest.Completed)
                    {
                        complete.Enabled = false;
                        complete.BackColor = Color.LightGreen;
                    }
                    complete.Click += CompleteClick;
                    MainTLP.Controls.Add(complete);
                    Button del = new();
                    del.Text = "Delete";
                    del.Name = quest.Id.ToString();
                    del.ForeColor = Color.White;
                    del.BackColor = Color.DarkGray;
                    del.FlatAppearance.BorderSize = 0;
                    del.Click += DelClick;
                    MainTLP.Controls.Add(del);
                }
            }
        }

        private void DelClick(object? sender, EventArgs e)
        {
            Button btn = sender as Button;
            do
            {
                MainTLP.Controls.RemoveByKey(btn.Name);
            }
            while (MainTLP.Controls.IndexOfKey(btn.Name) != -1);
            quests.Remove(quests.Find(x => x.Id.ToString() == btn.Name));
        }

        private void CompleteClick(object? sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Enabled = false;
            btn.BackColor = Color.LightGreen;
            quests.Find(x => x.Id.ToString() == btn.Name).Complete(user);
            StatRefresh();
        }

        private void AddBtnClick(object? sender, EventArgs e)
        {
            InputFrm inpFrm = new();
            DialogResult Res = inpFrm.ShowDialog();

            if (Res == DialogResult.OK)
            {
                Quest newQuest = new(inpFrm.inf.Name, inpFrm.inf.Complexity, inpFrm.inf.Time, id, false);
                quests.Add(newQuest);
                id += 1;
                DisplayQuests(inpFrm.inf.Time);
            }

        }

        private void StatRefresh()
        {
            lvlLbl.Text = $"Level {user.Lvl.ToString()}";
            xpLbl.Text = $"{user.Xp.ToString()}/{user.XpNeeded} XP";
            goldLbl.Text = $"{user.Money.ToString()}G";
        }


        private void FrmMainShown(object? sender, EventArgs e)
        {
            DisplayQuests("Daily");
        }

    }
}
