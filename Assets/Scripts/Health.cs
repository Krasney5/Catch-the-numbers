using TMPro;
using UI;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int _hp;
    [SerializeField] private TextMeshProUGUI _hpText;
    private LoseScreen _loseScreen;
    private Spawn _spawn;

    void Start()
    {
        _hpText.SetText(_hp.ToString());
        _loseScreen = FindObjectOfType<LoseScreen>();
        _spawn = FindObjectOfType<Spawn>();
    }
    public void TakeDamage()
    {
        _hp--;
        CheckHealth();
    }

    public void AddHealth(int hp)
    {
        _hp += hp;
        CheckHealth();
    }
    
    private void CheckHealth()
    {
        if (_hp <= 0)
        {
            _hpText.SetText("0");
            _loseScreen.Lose();
            _spawn.DeletePrefabs();
        }
        else
        {
            _hpText.SetText(_hp.ToString());
        }
    }
}
