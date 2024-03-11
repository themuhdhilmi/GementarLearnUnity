using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedJointInfo : MonoBehaviour
{

    [InfoBox("Fixed Joint is a joint whos fixed in place but can be break on certain force applied. This is usefull for example a shooting target that are static. (Target Stick)")]


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
