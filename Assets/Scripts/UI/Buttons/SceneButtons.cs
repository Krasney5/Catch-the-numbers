using UnityEngine;
using UnityEngine.SceneManagement;

namespace Buttons
{
    public class SceneButtons : MonoBehaviour
    {
        public void LoadMainScene()
        {
            SceneManager.LoadScene("MainScene");
        }
        public void LoadMainMenu()
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("MainMenu");
        }
    }
}
