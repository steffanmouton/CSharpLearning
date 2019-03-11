using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuidedExerciseLINQ
{
    public partial class Form1 : Form
    {
        public static string Filenamecsv = "datadoit.csv";
        public List<Score> PlayerScores = new List<Score>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var playerdata = File.ReadAllLines(Filenamecsv);
            foreach (var line in playerdata)
            {
                var entry = line.Split(',');
                var score = new Score
                {
                    levelName = entry[0],
                    playerName = entry[1],
                    score = float.Parse(entry[2]),
                    levelTime = float.Parse(entry[3]),
                    enemiesKilled = (int)float.Parse(entry[4]),
                    levelCompleted = float.Parse(entry[5]) > 0
                };
                PlayerScores.Add(score);
                //playerInfoTextBox.Text += line + Environment.NewLine;
            }

            //all players who did not complete level 1
            string text = "All Players who did not complete level 1";
            var query1 = PlayerScores.Where(score => score.levelName == "Level1" && !score.levelCompleted);
            playerInfoTextBox.Text += Environment.NewLine;
            playerInfoTextBox.Text += text += Environment.NewLine;
            foreach (var score in query1)
            {
                playerInfoTextBox.Text += score.playerName + Environment.NewLine;
            }
            

            //all players who have completed level 3
            text = "All Players who have completed level 3";
            var query2 = PlayerScores.Where(score => score.levelName == "Level3" && !score.levelCompleted);
            playerInfoTextBox.Text += Environment.NewLine;
            playerInfoTextBox.Text += text += Environment.NewLine;
            foreach (var score in query2)
            {
                playerInfoTextBox.Text += score.playerName + Environment.NewLine;
            }

            //all players who have more than 12 score, 63 leveltime, 6 kills
            text = "All players who have more than 12 score, 63 leveltime, 6 kills";
            var query3 = PlayerScores.Where(score =>
                score.score >= 12f && score.levelTime >= 63f && score.enemiesKilled >= 6).OrderByDescending( p => p.score);
            playerInfoTextBox.Text += Environment.NewLine;
            playerInfoTextBox.Text += text += Environment.NewLine;
            foreach (var score in query3)
            {
                playerInfoTextBox.Text += score.playerName + Environment.NewLine;
            }
        }
    }

    //List<Score> gameScores = new List<Score>();

}
