using TMPro;
using UnityEngine;
using YG;

namespace UI
{
    public class MaxScoreText : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _maxScoreText;

        private void Start()
        {
            _maxScoreText.SetText(YandexGame.savesData.MaxScore.ToString());
        }
    }
}
