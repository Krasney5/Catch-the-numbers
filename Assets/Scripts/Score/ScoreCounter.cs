using TMPro;
using UnityEngine;

namespace Score
{
    public class ScoreCounter : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI _text;
        [SerializeField] int _score;
        // Start is called before the first frame update
        void Start()
        {
            _text.SetText(_score.ToString());
        }

        public void AddingAPoint(int score)
        {
            _score += score;
            _text.SetText(_score.ToString());
        }
    }
}