using UnityEngine;

namespace Hands
{
    public class MouseFollow : MonoBehaviour
    {
        private void Start()
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Confined;
        }

        private void Update()
        {
            Move();
        }

        private void Move()
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10f;

            Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
            transform.position = worldPos;
        }

        private void OnDisable()
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}