using UnityEngine;

namespace Numbers
{
    public class Fall : MonoBehaviour
    {
        private float _speed;
        private SpeedController _controller;

        private void OnEnable()
        {
            _controller = FindFirstObjectByType<SpeedController>();
            _speed = _controller.GetSpeed();
        }
        private void Update()
        {
            Move();
        }   
        private void Move()
        {
            transform.Translate(Vector2.down * _speed * Time.deltaTime);
        }
    }
}
