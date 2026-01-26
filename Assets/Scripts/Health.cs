using TMPro;
using UI;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int _hp;
    [SerializeField] private TextMeshProUGUI _hpText;
    private LoseScreen _loseScreen;
    void Start()
    {
        _hpText.SetText(_hp.ToString());
        _loseScreen = FindObjectOfType<LoseScreen>();
    }
    public void GetDamage()
    {
        _hp -= 1;
        ChekHealth();
        _hpText.SetText(_hp.ToString());
    }
    
    private void ChekHealth()
    {
        if (_hp <= 0)
        {
            _loseScreen.Lose();
        }
    }
}
