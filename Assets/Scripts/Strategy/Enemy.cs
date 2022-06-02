using System;
using UnityEngine;
using UnityEngine.UI;

namespace Strategy
{
    public abstract class Enemy : MonoBehaviour
    {
        private Slider _healthSlider;
        protected int MaxHealth;
        protected int CurrentHealth;
        protected int Damage;

        private void Awake()
        {
            _healthSlider = GetComponentInChildren<Slider>();
        }

        public virtual void ApplyDamage()
        {
            CurrentHealth -= Damage;
            ViewController.Instance.UpdateHealthSlider(MaxHealth, CurrentHealth, _healthSlider);
        }
    }
}
