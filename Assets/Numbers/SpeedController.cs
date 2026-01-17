using System.Collections;
using UnityEngine;

namespace Numbers
{
    public class SpeedController : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _theTimeAfterWhichTheSpeedIncreases;
        [SerializeField] private float _theNumberByWhichTheSpeedIncreases;

        private void Start()
        {
            StartCoroutine(Boost());
        }

        private IEnumerator Boost()
        {
            while(true)
            {
                yield return new WaitForSeconds(_theTimeAfterWhichTheSpeedIncreases);
                _speed += _theNumberByWhichTheSpeedIncreases;
            }
        } 
        public float GetSpeed()
        {
            return _speed;
        }
    }
}
