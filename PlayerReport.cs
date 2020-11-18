using System;
namespace finalexampractice
{
    public class PlayerReport
    {
        private Player[] players;

        public PlayerReport(Player[] players)
        {
            this.players = players;
        }

        public void PrintAllPlayers(){
            for(int i = 0; i < Player.GetCount(); i++){
                Console.WriteLine(players[i].ToString());
            }
        }
        public void AverageByTeam(){
            //your code for part 2 goes here
 
        }

    }
}