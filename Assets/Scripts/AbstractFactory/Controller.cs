using System;
using UnityEngine;

namespace AbstractFactory
{
    public class Controller : MonoBehaviour
    {
        private Hero _hero;

        private void Start()
        {
            _hero = FindObjectOfType<Hero>();
        }

        public void BecomeWarrior()
        {
            _hero.ChangeClass<Warrior>();
        }

        public void BecomeArcher()
        {
            _hero.ChangeClass<Archer>();
        }
    }
}