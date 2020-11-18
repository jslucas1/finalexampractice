using System;

namespace finalexampractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Player[] players = new Player[200];
            PlayerFile playerFileObj = new PlayerFile(players, "input.txt");
            playerFileObj.GetAllPlayers();

            PlayerUtility playerUtilObj = new PlayerUtility(players);
            playerUtilObj.Sort();

            PlayerReport playerReportObj = new PlayerReport(players);
            playerReportObj.PrintAllPlayers();
            Console.WriteLine("\n\n\nControl Break Report");
            playerReportObj.AverageByTeam();
        }
    }
}
