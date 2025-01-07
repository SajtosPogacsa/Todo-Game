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
        public string Name { get => name; set => name = value; }
        public string Complexity { get => complexity; set => complexity = value; }
        public string Time { get => time; set => time = value; }
        public int Id { get => id; set => id = value; }

        public Quest(string name, string complexity, string time, int id)
        {
            this.Name = name;
            this.Complexity = complexity;
            this.Time = time;
            this.Id = id;
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
                case "Hard":
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
        }
    }
}
