using UnityEngine;
using YGScripts;

namespace UI
{
    public class LoseScreen : MonoBehaviour
    {
        [SerializeField] private GameObject _loseScreen;
        [SerializeField] private GameObject _hands;

        private ContinueByAd _continueByAd;

        private void Awake()
        {
            _continueByAd = FindObjectOfType<ContinueByAd>();
        }

        public void Lose()
        {
            _loseScreen.SetActive(true);
            _hands.SetActive(false);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
        }

        private void Continue()
        {
            _loseScreen.SetActive(false);
            _hands.SetActive(true);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Confined;
            Time.timeScale = 1f;
        }

        private void OnEnable()
        {
            _continueByAd.Continued += Continue;
        }

        private void OnDisable()
        {
            _continueByAd.Continued -= Continue;
        }
    }
}
