using System;
namespace finalexampractice
{
    public class Player
    {
        private string name;
        private string team;
        private double hits;
        private double atBats;
        private double average;

        private static int count;

        //Constructors
        public Player(string name, string team, double hits, double atBats, double average)
        {
            this.name = name;
            this.team = team;
            this.hits = hits;
            this.atBats = atBats;
            this.average = average;
        }

        public Player(){

        }

        //Getters and Setters

        public void SetName(string name){
            this.name = name;
        }

        public void SetTeam(string team){
            this.team = team;
        }

        public void SetHits(double hits){
            this.hits = hits;
        }
        public void SetAtBats(double atBats){
            this.atBats = atBats;
        }

        public void SetAverage(double average){
            this.average = average;
        }
        public string GetName(){
            return name;
        }
        public string GetTeam(){
            return team;
        }
        public double GetHits(){
            return hits;
        }
        public double GetAtBats(){
            return atBats;
        }
        public double GetAverage(){
            return average;
        }

        public static int GetCount(){
            return count;
        }
        public static void SetCount(int tempCount){
            count = tempCount;
        }
        public static void IncCount(){
            count++;
        }

        public override string ToString()
        {
            return $"{name} \t {team} \t {Math.Round(average,3)}";
        }

    }
}