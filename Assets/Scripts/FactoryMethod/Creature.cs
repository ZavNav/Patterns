using System;
using UnityEngine;

namespace FactoryMethod
{
    public abstract class Creature : MonoBehaviour
    {
        [SerializeField] protected int MaxHealth;
        [SerializeField] protected int CurrentHealth;
    }

    public class Orc : Creature
    {
        private void Start()
        {
            MaxHealth = 100;
            CurrentHealth = MaxHealth;
            Debug.Log("AGRH!");
        }
    }

    public class Elf : Creature
    {
        private void Start()
        {
            MaxHealth = 60;
            CurrentHealth = MaxHealth;
            Debug.Log("Shame on you");
        }
    }

    public class Human : Creature
    {
        private void Start()
        {
            MaxHealth = 10;
            CurrentHealth = MaxHealth;
            Debug.Log("Hello World!");
        }
    }
}
