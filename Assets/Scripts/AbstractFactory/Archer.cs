namespace AbstractFactory
{
    public class Archer : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new FlyMovement();
        }
 
        public override Weapon CreateWeapon()
        {
            return new Arch();
        }
    }
}
