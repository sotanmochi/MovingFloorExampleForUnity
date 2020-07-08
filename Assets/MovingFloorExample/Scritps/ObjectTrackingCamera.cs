using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MovingFloorExample
{
    public class ObjectTrackingCamera : MonoBehaviour
    {
        [SerializeField] Camera _Camera;
        [SerializeField] GameObject _Target;

        Transform _CameraTransform;
        Vector3 _Offset;

        void Start()
        {
            _CameraTransform = _Camera.transform;
            _Offset = _CameraTransform.position - _Target.transform.position;
        }

        void Update()
        {
            _CameraTransform.position = _Target.transform.position + _Offset;
        }
    }
}
