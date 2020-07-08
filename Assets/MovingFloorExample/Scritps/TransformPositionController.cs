using UnityEngine;

namespace MovingFloorExample
{
    public class TransformPositionController : MonoBehaviour
    {
        void Start()
        {
            
        }

        void FixedUpdate()
        {
            float vertical = Input.GetAxis("Vertical");
            float horizontal = Input.GetAxis("Horizontal");

            Vector3 move = transform.forward * vertical + transform.right * horizontal;
            transform.position += move;
        }
    }
}
