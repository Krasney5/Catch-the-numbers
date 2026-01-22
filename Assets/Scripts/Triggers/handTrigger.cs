using System;
using Numbers;
using Score;
using Triggers;
using UnityEngine;

public class handTrigger : Trigger<Fall>
{
    [SerializeField] private String _tag;
    private ScoreCounter _scoreCounter;
    private Health _health;
    void Start()
    {
        _scoreCounter = FindObjectOfType<ScoreCounter>();
        _health = FindObjectOfType<Health>();
    }
    
    
    protected override void OnEnter(Fall triggered)
    {
        if (triggered.tag == _tag)
        {
            _scoreCounter.AddingAPoint(10);
            Destroy(triggered.gameObject);
        }
        else
        {
            _health.GetDamage();
            Destroy(triggered.gameObject);
        }
    }
}
