namespace AbstractFactory
{
    public class Warrior : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new WalkingMovement();
        }
 
        public override Weapon CreateWeapon()
        {
            return new Sword();
        }
    }
}
