using Game.Data;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Zenject;

namespace Game.Score
{
    public class ScoreSystem : IScoreSystem
    {
        [Inject]
        IScoreSettings scoreSettings;

        #region Fields
        private int playerScore;
        private int bombsCount;
        private bool isLastScoreAddedToScoreboard;
        #endregion

        public void AddPoint()
        {
            playerScore++;
        }

        public void AddBomb()
        {
            if (bombsCount >= 3) return;
            bombsCount++;
        }

        public void RemoveBomb()
        {
            bombsCount--;
        }

        public int GetCurrentScore()
        {
            return playerScore;
        }

        public int GetCurrentBombsCount()
        {
            return bombsCount;
        }

        public List<int> GetHighScoreList()
        {
            List<int> highScore = new List<int>();
            for (int i = 0; i < scoreSettings.GetScoreboardMaxPositions(); i++)
            {
                var savePosition = "ScorePosition" + i;
                if (PlayerPrefs.HasKey(savePosition))
                {
                    highScore.Add(PlayerPrefs.GetInt(savePosition));
                }
            }

            highScore.OrderByDescending(score => score);
            return highScore;

        }

        public void SaveScore()
        {
            isLastScoreAddedToScoreboard = false;
            var currentScore = playerScore;
            if (currentScore == 0) return;
            int maxPositions = scoreSettings.GetScoreboardMaxPositions();
            var scores = GetHighScoreList().OrderByDescending(score => score).Take(maxPositions).ToList();
            scores.Add(currentScore);
            scores = scores.OrderByDescending(score => score).ToList();

            if (scores.Count > maxPositions)
                scores.RemoveAt(scores.Count - 1);

            if (scores.Contains(playerScore))
            {
                var savePosition = 0;
                foreach (var score in scores)
                {
                    PlayerPrefs.SetInt("ScorePosition" + savePosition, score);
                    savePosition++;
                }
                PlayerPrefs.Save();
                isLastScoreAddedToScoreboard = true;
            }
        }

        public bool IsScoreAddedToScoreboard()
        {
            return isLastScoreAddedToScoreboard;
        }

        public void RestartScore()
        {
            playerScore = 0;
        }
    }
}