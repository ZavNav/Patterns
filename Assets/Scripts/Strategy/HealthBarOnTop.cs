using System;
using UnityEngine;

namespace Strategy
{
    public class HealthBarOnTop : MonoBehaviour
    {
        private Transform _cam;

        private void Start()
        {
            _cam = Camera.main.transform;
        }

        private void Update()
        {
            transform.LookAt(_cam, Vector3.down);
        }
    }
}
