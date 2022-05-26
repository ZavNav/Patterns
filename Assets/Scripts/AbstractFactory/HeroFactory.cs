using UnityEngine;

namespace AbstractFactory
{
    public abstract class HeroFactory : MonoBehaviour
    {
        public abstract Movement CreateMovement();
        public abstract Weapon CreateWeapon();
    }
}
