using UnityEngine;

namespace MovingFloorExample
{
    [RequireComponent(typeof(Rigidbody))]
    public class RigidbodyPositionController : MonoBehaviour
    {
        private Rigidbody _rigidbody;

        void Start()
        {
            _rigidbody = this.GetComponent<Rigidbody>();
        }

        void FixedUpdate()
        {
            _rigidbody.MovePosition(this.transform.position + transform.right * Time.deltaTime);
        }
    }
}
