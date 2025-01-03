using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Todo
{
    public partial class FrmMain : Form
    {
        List<Quest> quests = new();
        int id = 0;

        public FrmMain()
        {
            InitializeComponent();
            addBtn.Click += AddBtnClick;
            dailyBtn.Click += TimeBtnClick;
            weeklyBtn.Click += TimeBtnClick;
            specialBtn.Click += TimeBtnClick;

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
                    name.Tag = quest.Id;
                    name.TextAlign = ContentAlignment.MiddleCenter;
                    MainTLP.Controls.Add(name);
                    Label comp = new();
                    comp.Text = quest.Complexity;
                    comp.Tag = quest.Id;
                    comp.TextAlign = ContentAlignment.MiddleCenter;
                    MainTLP.Controls.Add(comp);
                    Button complete = new();
                    complete.Text = "Complete";
                    complete.Tag = quest.Id;
                    MainTLP.Controls.Add(complete);
                    Button del = new();
                    del.Text = "Delete";
                    del.Tag = quest.Id;
                    MainTLP.Controls.Add(del);
                }
            }
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

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
