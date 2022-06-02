using UnityEngine;
using UnityEngine.UI;

namespace Strategy
{
    public class StrongEnemy : Enemy
    {
        private void Start()
        {
            CurrentHealth = MaxHealth = 70;
            Damage = 3;
        }

        public override void ApplyDamage()
        {
            base.ApplyDamage();
            transform.Rotate(20,20,20);
        }
    }
}