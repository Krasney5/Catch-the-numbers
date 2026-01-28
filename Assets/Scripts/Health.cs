using TMPro;
using UI;
using Unity.VisualScripting;
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
    public void TakeDamage()
    {
        _hp -= 1;
        ChekHealth();
    }
    
    private void ChekHealth()
    {
        if (_hp <= 0)
        {
            _hpText.SetText("0");
            _loseScreen.Lose();
        }
        else
        {
            _hpText.SetText(_hp.ToString());
        }
    }
}
