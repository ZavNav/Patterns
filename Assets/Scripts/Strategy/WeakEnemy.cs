using System;
using UnityEngine;
using UnityEngine.UI;

namespace Strategy
{
    public class WeakEnemy : Enemy
    {
        private void Start()
        {
            CurrentHealth = MaxHealth = 30;
            Damage = 5;
        }

        public override void ApplyDamage()
        {
            base.ApplyDamage();
            transform.localScale *= 0.95f;
        }
    }
}