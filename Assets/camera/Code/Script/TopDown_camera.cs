using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IndiePixel.Cameras
{
    public class TopDown_camera : MonoBehaviour
    {
        public Transform _Target;
        public float _Height = 10f;
        public float _Distance = 20f;
        public float _Angle = 45f;
        // Start is called before the first frame update
        void Start()
        {
            HandleCamera();
        }

        // Update is called once per frame
        void Update()
        {
            HandleCamera();
        }

        protected virtual void HandleCamera()
        {
            if (!_Target)
            {
                return;
            }

            Vector3 worldPosition = (Vector3.forward * -_Distance) + (Vector3.up * _Height);
            Debug.DrawLine(_Target.position, worldPosition, Color.red);

            Vector3 rotatedVector = Quaternion.AngleAxis(_Angle, Vector3.up) * worldPosition;
            Debug.DrawLine(_Target.position, rotatedVector, Color.green);
        }
    }

}
