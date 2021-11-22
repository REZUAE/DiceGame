using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
     public class Player
    {
        string name;
        string avatar;
        int points;
        int bank;
        int round = 0;
        string color;
        public Player(string name, string avatar)
        {
            this.name = name;
            this.avatar = avatar;
            this.points = 0;
            this.bank = 0;
            this.round = 1;
            this.color = "white";
        }
        public void addPoints(int point)
        {
            this.points += point;
        }
        public void fillBank(int bank)
        {
            this.bank = bank;
        }
        public void emptiebank()
        {
            this.bank = 0;
        }
        public int getRound()
        {
            return this.round;
        }
        public void selected()
        {
            this.color = "green";
        }
        public void unSelect()
        {
            this.color = "white";
        }
        public int getBank()
        {
            return this.bank;
        }
    }
}
