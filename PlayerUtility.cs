namespace finalexampractice
{
    public class PlayerUtility
    {
        private Player[] players;

        public PlayerUtility(Player[] players)
        {
            this.players = players;
        }
        public void Sort(){
            for(int i = 0; i < Player.GetCount() - 1; i++){
                int minIndex = i;
                for(int j = i + 1; j < Player.GetCount(); j++){
                    if(players[minIndex].GetTeam().CompareTo(players[j].GetTeam()) > 0){
                        minIndex = j;
                    }
                }
                if(minIndex != i){
                    Swap(minIndex, i);
                }
            }
        }
        public void Swap(int x, int y){
            Player temp = players[x];
            players[x] = players[y];
            players[y] = temp;
        }
    }
}