using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float force = 50.0f;
    private Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    [Button]
    public void FireX()
    {
        rigidbody.AddRelativeForce(new Vector3 (force, 0, 0));
    }

    public void SetForce(float force)
    {
        this.force = force;
    }
}
