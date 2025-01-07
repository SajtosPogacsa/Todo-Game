using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Todo
{
    public partial class FrmMain : Form
    {
        User user = new();
        List<Quest> quests = new();
        int id = 0;

        public FrmMain()
        {
            InitializeComponent();
            addBtn.Click += AddBtnClick;
            dailyBtn.Click += TimeBtnClick;
            weeklyBtn.Click += TimeBtnClick;
            specialBtn.Click += TimeBtnClick;
            StatRefresh();
        }

        private void TimeBtnClick(object? sender, EventArgs e)
        {
            Button btn = sender as Button;
            DisplayQuests(btn.Text);
        }

        private void DisplayQuests(string time)
        {
            MainTLP.Controls.Clear();
            MainTLP.RowCount = 0;
            MainTLP.RowCount = 10;

            foreach (Quest quest in quests)
            {
                if (quest.Time == time)
                {
                    Label name = new();
                    name.Text = quest.Name;
                    name.Name = quest.Id.ToString();
                    name.TextAlign = ContentAlignment.MiddleCenter;
                    MainTLP.Controls.Add(name);
                    Label comp = new();
                    comp.Text = quest.Complexity;
                    comp.Name = quest.Id.ToString();
                    comp.TextAlign = ContentAlignment.MiddleCenter;
                    MainTLP.Controls.Add(comp);
                    Button complete = new();
                    complete.Text = "Complete";
                    complete.Name = quest.Id.ToString();
                    complete.Click += CompleteClick;
                    MainTLP.Controls.Add(complete);
                    Button del = new();
                    del.Text = "Delete";
                    del.Name = quest.Id.ToString();
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
            quests.Find(x => x.Id.ToString() == btn.Name).Complete(user);
            StatRefresh();
        }

        private void AddBtnClick(object? sender, EventArgs e)
        {
            InputFrm inpFrm = new();
            DialogResult Res = inpFrm.ShowDialog();

            if (Res == DialogResult.OK)
            {
                Quest newQuest = new(inpFrm.inf.Name, inpFrm.inf.Complexity, inpFrm.inf.Time, id);
                quests.Add(newQuest);
                id += 1;
            }

        }

        private void StatRefresh()
        {
            lvlLbl.Text = $"Level {user.Lvl.ToString()}";
            xpLbl.Text = $"{user.Xp.ToString()}/{user.XpNeeded} XP";
            goldLbl.Text = $"{user.Money.ToString()}G";
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
