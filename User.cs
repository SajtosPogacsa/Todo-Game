using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo
{
    public class User
    {
        private int lvl;
        private int xp;
        private int money;
        private int xpNeeded;

        public int Lvl { get => lvl; set => lvl = value; }
        public int Xp { get => xp; set => xp = value; }
        public int Money { get => money; set => money = value; }
        public int XpNeeded { get => xpNeeded; set => xpNeeded = value; }

        public User(int lvl, int xp, int money)
        {
            Lvl = lvl;
            Xp = xp;
            Money = money;
            XpCalc();
        }

        public User()
        {
            Lvl = 1;
            Xp = 0;
            Money = 0;
            XpCalc();
        }

        public void XpCalc()
        {
            XpNeeded = (((lvl *(lvl - 1))/15) * 100) + 100;
            if (Xp >= XpNeeded)
            {
                Lvl += 1;
                Xp = Xp - XpNeeded;
            }
        }
    }
}
