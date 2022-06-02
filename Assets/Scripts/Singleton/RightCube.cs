using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Singleton
{
    public class RightCube : Cube
    {
        private void Awake()
        {
            Points = 10;
        }

        private void OnMouseEnter()
        {
            ColorBlink();
            transform.Translate(0, Random.Range(-1f,1f), 0);
            GameManager.Instance.UpdateScore(Points, this);
        }
    }
}
