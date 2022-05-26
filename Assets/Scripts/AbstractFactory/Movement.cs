using UnityEngine;

namespace AbstractFactory
{
    public abstract class Movement
    {
        public abstract Vector3 Move();
    }
    
    public class FlyMovement : Movement
    {
        public override Vector3 Move()
        {
            return Vector3.up;
        }
    }
    public class WalkingMovement : Movement
    {
        public override Vector3 Move()
        {
            return Vector3.forward;
        }
    }
}