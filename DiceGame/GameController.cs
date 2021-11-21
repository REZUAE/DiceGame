using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class GameController
    {
        private Player[] players; // 0 1 2 3
        private int rounds; // 30
        private int turn;
        public GameController(int rounds, int numberOfPlayers)
        {
            this.rounds = rounds;
            this.players = new Player[numberOfPlayers];
            this.turn = 0;
        }
        public void setPlayer(int index, Player player)
        {
            this.players[index] = player;
        }
        public Boolean RollDice(int index)
        {
            Random random = new Random();
            int score = random.Next(1, 6);
            this.players[index].fillBank(score);
            return this.changeTurn();
        }
        private Boolean changeTurn()
        {
            this.turn++;
            if (this.turn >= this.players.Length) //if the round is over
            {
                getRoundWinner();
                this.turn = 0;
                if (this.players[this.turn]
                  .getRound() > rounds)
                {
                    return false;
                }
                else
                {
                    this.players[this.players.Length - 1].unSelect();
                    this.players[this.turn].selected();
                }
            }
            else
            {
                this.players[this.turn - 1].unSelect();
                this.players[this.turn].selected();
            }

            return true;
        }

        public void getRoundWinner()
        {

        }
        public void setRoundWinner()
        {
            System.Collections.Generic.List<Player> highestBankers = new System.Collections.Generic.List<Player>();
            highestBankers.Add(players[0]);
            for (int i = 1; i < this.players.Length; i++)
            {
                //Edip rolled 4, Mahdi Rolled 1 and John Rolled 6” => John will win 6 
                //points.

                if (this.players[i].getBank() > highestBankers[0].getBank())
                {
                    highestBankers.Clear();
                    highestBankers.Add(this.players[i]);

                }
                //Edip rolled 4, Mahdi Rolled 2 and John Rolled 4” => Because Edip and
                //John Rolled the same, Mahdi will win the round and take 2 points.



            }
        }

    }
}
