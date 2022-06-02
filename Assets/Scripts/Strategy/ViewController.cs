using System;
using UnityEngine;
using UnityEngine.UI;

namespace Strategy
{
    public class ViewController : MonoBehaviour
    {
        public static ViewController Instance;

        private void Start()
        {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);
        }

        public void UpdateHealthSlider(int maxHealth, int curHealth, Slider slider)
        {
            slider.value = Mathf.InverseLerp(0, maxHealth, curHealth);
        }
    }
}