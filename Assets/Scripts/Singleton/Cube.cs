using System;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Serialization;

namespace Singleton
{
    public class Cube : MonoBehaviour
    {
        private MeshRenderer _mr;
        [SerializeField] private Color clickColor;
        private Color _myColor;

        protected int Points;
        protected void Start()
        {
            _mr = GetComponent<MeshRenderer>();
            _myColor = _mr.material.color;
        }

        protected async void ColorBlink()
        {
            _mr.material.color = clickColor;
            await Task.Delay(500);
            _mr.material.color = _myColor;
        }
    }
}