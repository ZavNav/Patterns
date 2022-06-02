using System;
using UnityEngine;

namespace Strategy
{
    public class CameraBehaviour : MonoBehaviour
    {
        private GameObject projectile;

        [SerializeField] private int speed = 4;
        private void Start()
        {
            projectile = Resources.Load<GameObject>("Prefabs/Strategy/Projectile");
        }

        private void Update()
        {
            MoveCamera();
            Shoot();
        }

        private void MoveCamera()
        {
            var x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            transform.Translate(x,0,0);
        }

        private void Shoot()
        {
            if(!Input.GetKeyDown(KeyCode.Space)) return;

            Instantiate(projectile, transform.position, Quaternion.identity);
        }
    }
}