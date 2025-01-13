using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo
{
    internal class Quest
    {
        string name;
        string complexity;
        string time;
        int id;
        bool completed;
        string compTime;
        public string Name { get => name; set => name = value; }
        public string Complexity { get => complexity; set => complexity = value; }
        public string Time { get => time; set => time = value; }
        public int Id { get => id; set => id = value; }
        public bool Completed { get => completed; set => completed = value; }
        public string CompTime { get => compTime; set => compTime = value; }

        public Quest(string name, string complexity, string time, int id, bool completed, string compTime = "")
        {
            this.Name = name;
            this.Complexity = complexity;
            this.Time = time;
            this.Id = id;
            this.Completed = completed;
            this.CompTime = compTime;
        }

        public void Complete(User user)
        {
            switch (complexity)
            {
                case "Easy":
                    user.Xp += 10;
                    user.Money += 10;
                    break;
                case "Medium":
                    user.Xp += 50;
                    user.Money += 50;
                    break;
                case "Difficult":
                    user.Xp += 100;
                    user.Money += 100;
                    break;
                case "Impossible":
                    user.Xp += 250;
                    user.Money += 250;
                    break;
                default:
                    break;
            }
            this.Completed = true;
            this.CompTime = DateTime.Today.Date.ToString("dd");
            user.XpCalc();
        }
    }
}
