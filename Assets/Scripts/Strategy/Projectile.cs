using System;
using UnityEngine;

namespace Strategy
{
    [RequireComponent(typeof(Rigidbody))]
    public class Projectile : MonoBehaviour
    {
        [SerializeField] private int force;

        private void Start()
        {
            GetComponent<Rigidbody>().AddForce(Vector3.forward * force, ForceMode.Impulse);
            Destroy(gameObject, 3);
        }

        private void OnCollisionEnter(Collision collision)
        {
            collision.gameObject.GetComponent<Enemy>()?.ApplyDamage();
        }
    }
}