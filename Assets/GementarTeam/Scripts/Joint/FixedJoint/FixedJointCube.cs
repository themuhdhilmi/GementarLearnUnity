using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedJointCube : MonoBehaviour
{
    private void OnJointBreak(float breakForce)
    {
        Debug.Log($"Joint {this.gameObject.name} breaked with {breakForce} Force");
    }
}
