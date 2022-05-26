using System;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryMethod
{
    public class CreatureFactory : MonoBehaviour
    {
        public static Creature CreateCreature<TCreatureType>() where TCreatureType : Creature
        {
            return Instantiate(Resources.Load<GameObject>($"Prefabs/FactoryMethod/{typeof(TCreatureType).Name}"))
                .AddComponent<TCreatureType>();
        }
    }

}
