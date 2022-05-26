using UnityEngine;

namespace AbstractFactory
{
    public abstract class Weapon 
    {
        public abstract void Hit();
    }
    
    public class Arch : Weapon
    {
        public override void Hit()
        {
            Debug.Log("arrow released");
        }
    }
    public class Sword : Weapon
    {
        public override void Hit()
        {
            Debug.Log("sword swing");
        }
    }
}
