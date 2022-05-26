using System;
using UnityEngine;

namespace AbstractFactory
{
    public class Hero : MonoBehaviour
    {
        private Weapon _weapon;
        private Movement _movement;
        private HeroFactory _heroFactory;

        private void Start()
        {
            ChangeClass<Warrior>();
        }

        private void Update()
        {
            if(Input.GetKey(KeyCode.W)) Run();
            if(Input.GetMouseButtonDown(0)) Hit();
        }

        public void ChangeClass<TClass>() where TClass : HeroFactory
        {
            Destroy(_heroFactory);
            _heroFactory = gameObject.AddComponent<TClass>();
            _weapon = _heroFactory.CreateWeapon();
            _movement = _heroFactory.CreateMovement();
            Debug.Log($"You are {typeof(TClass).Name} now");
        }

        private void Run()
        {
            transform.Translate(_movement.Move() * Time.deltaTime);
        }
        private void Hit()
        {
            _weapon.Hit();
        }
    }
}
