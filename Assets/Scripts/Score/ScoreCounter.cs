using TMPro;
using UnityEngine;
using System;
using YG;

namespace Score
{
    public class ScoreCounter : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI _text;
        [SerializeField] int _score;

        private int _maxScore;

        public int Score { get => _score; set => _score = value; }
        public int MaxScore { get => _maxScore; set => _maxScore = value; }

        public event Action MaxScoreChanged;

        private const string _leaderBoardName = "Score";

        void Start()
        {
            _text.SetText(_score.ToString());
        }

        public void AddingAPoint(int score)
        {
            _score += score;
            if (_score > _maxScore)
            {
                _maxScore = _score;
                YandexGame.NewLeaderboardScores(_leaderBoardName, _score);
                MaxScoreChanged?.Invoke();
            }
            _text.SetText(_score.ToString());
        }
    }
}