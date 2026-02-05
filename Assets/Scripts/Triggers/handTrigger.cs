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
    private Spawn _spawn;
    void Start()
    {
        _scoreCounter = FindObjectOfType<ScoreCounter>();
        _health = FindObjectOfType<Health>();
        _spawn = FindObjectOfType<Spawn>();
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
            _health.TakeDamage();
            _spawn.DeletePrefabs(triggered.gameObject);
        }
    }
}
