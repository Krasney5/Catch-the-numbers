using System;
using UnityEngine;
using YG;

namespace YGScripts
{
    public class ContinueByAd : MonoBehaviour
    {
        [SerializeField] private int _id;

        public event Action Continued;

        private Health _health;

        private void Awake()
        {
            _health = FindObjectOfType<Health>();
        }

        private void Continue(int id)
        {
            if (id != _id)
                return;

            Continued?.Invoke();
            _health.AddHealth(3);
        }

        private void OnEnable()
        {
            YandexGame.RewardVideoEvent += Continue;
        }

        private void OnDisable()
        {
            YandexGame.RewardVideoEvent -= Continue;
        }
    }
}
