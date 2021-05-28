using System;
using System.Collections.Generic;

namespace TournamentWinner
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public string TournamentWinner(List<List<string> > competitions, List<int> results)
        {
            //constant variable for comparing
            int HOME_TEAM_WON = 1;
            //constant key value pair for the intial comparing so no errors occur
            string currentBestTeam = "";

            Dictionary<string, int> scores = new Dictionary<string, int>();
            scores[currentBestTeam] = 0;

            for(var i = 0; i < competitions.Count; i++)
            {
                //single out one row of the 2D List
                List<string> competition = competitions[i];
                int result = results[i]; 
                //pointers setup for each team 
                string homeTeam = competition[0];
                string awayTeam = competition[1];

                string winningTeam = (HOME_TEAM_WON == result) ? homeTeam : awayTeam;
                //update scores in dictionary / database
                updateScores(winningTeam, 3, scores);
                //assign new best team
                if (scores[winningTeam] > scores[currentBestTeam])
                {
                    currentBestTeam = winningTeam;
                }


            }
            return currentBestTeam;

        }
        public void updateScores(string team, int points, Dictionary<string, int> scores)
        {
            //check to see if the team has already won before
            if (!scores.ContainsKey(team))
            {
                //add more points to existing points
                scores[team] = scores[team] + points;
            }
        }
    }
}
