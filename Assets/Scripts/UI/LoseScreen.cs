using UnityEngine;

namespace UI
{
    public class LoseScreen : MonoBehaviour
    {
        [SerializeField] private GameObject _loseScreen;
        [SerializeField] private GameObject _hands;

        public void Lose()
        {
            _loseScreen.SetActive(true);
            _hands.SetActive(false);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
