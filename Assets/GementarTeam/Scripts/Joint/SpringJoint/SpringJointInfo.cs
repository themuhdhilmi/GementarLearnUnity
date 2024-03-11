using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringJointInfo : MonoBehaviour
{
    [InfoBox("Spring joint is usefull to create something springy, just like a crane. ")]
    [InfoBox("Increasing damper will make the object less springy")]


    [SerializeField]
    private float bulletForce = 50.0f;

    [SerializeField]
    private Bullet bullet;

    private void Start()
    {
        SetBulletForce();
    }

    [Button("Set Bullet Force")]
    private void SetBulletForce()
    {
        bullet.SetForce(bulletForce);
    }

    [Button("Fire Bullet")]
    private void FireBullet()
    {
        bullet.FireX();
    }
}
