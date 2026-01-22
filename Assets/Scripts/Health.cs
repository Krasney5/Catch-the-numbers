using TMPro;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int _hp;
    [SerializeField] private TextMeshProUGUI _hpText;
    void Start()
    {
        _hpText.SetText(_hp.ToString());
    }
    public void GetDamage()
    {
        _hp -= 1;
        _hpText.SetText(_hp.ToString());
    }
    
    private void ChekHealth()
    {
        if (_hp <= 0)
        {
            //появляется табличка и игра паузица
        }
    }
}
