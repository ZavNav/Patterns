using System;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryMethod
{
    public class Controller : MonoBehaviour
    {
        private readonly List<Creature> _creatures = new();

        private Vector3 target;

        private void Start()
        {
            target = Vector3.left;
            
        }

        private void Retarget()
        {
            target.x *= -1;
        }

        public void CreateElf()
        {
           _creatures.Add(CreatureFactory.CreateCreature<Elf>());
        }

        public void CreateOrc()
        {
            _creatures.Add(CreatureFactory.CreateCreature<Orc>());
        }

        public void CreateHuman()
        {
            _creatures.Add(CreatureFactory.CreateCreature<Human>());
        }
    }
}
