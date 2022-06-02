using System;
using UnityEngine;

namespace Singleton
{
    public class LeftCube : Cube
    {
        private void Awake()
        {
            Points = 5;
        }

        private void OnMouseDown()
        {
            ColorBlink();
            transform.Rotate(20, 20, 0);
            GameManager.Instance.UpdateScore(Points, this);
        }
    }
}
