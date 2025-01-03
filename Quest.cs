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

        public Quest(string name, string complexity, string time, int id)
        {
            this.Name = name;
            this.Complexity = complexity;
            this.Time = time;
            this.Id = id;
        }

        public string Name { get => name; set => name = value; }
        public string Complexity { get => complexity; set => complexity = value; }
        public string Time { get => time; set => time = value; }
        public int Id { get => id; set => id = value; }
    }
}
