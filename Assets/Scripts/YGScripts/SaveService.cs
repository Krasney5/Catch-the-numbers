using Score;
using UnityEngine;
using YG;

namespace YGScripts
{
    public class SaveService : MonoBehaviour
    {
        private ScoreCounter _scoreCounter;

        private void Awake()
        {
            _scoreCounter = FindObjectOfType<ScoreCounter>();
            Load();
        }

        private void Save()
        {
            YandexGame.savesData.MaxScore = _scoreCounter.MaxScore;

            YandexGame.SaveProgress();
        }

        private void Load()
        {
            _scoreCounter.MaxScore = YandexGame.savesData.MaxScore;
        }

        private void OnEnable()
        {
            _scoreCounter.MaxScoreChanged += Save;
            YandexGame.GetDataEvent += Load;
        }

        private void OnDisable()
        {
            _scoreCounter.MaxScoreChanged -= Save;
            YandexGame.GetDataEvent -= Load;
        }
    }
}
