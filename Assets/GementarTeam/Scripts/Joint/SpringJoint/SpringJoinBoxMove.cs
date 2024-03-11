using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringJoinBoxMove : MonoBehaviour
{

    [SerializeField]
    private float speed = 1f;

    [SerializeField]
    private float distance = 30f;

    private Vector3 startLocation;
    // Start is called before the first frame update
    void Start()
    {
        startLocation = transform.position;
    }


    float changer = 1f;

    // Update is called once per frame
    void FixedUpdate()
    {

        Debug.Log(Vector3.Distance(startLocation, transform.position));

        if (Vector3.Distance(startLocation, transform.position) > distance)
        {
            startLocation = transform.position;
            //transform.Rotate(new Vector3(0,180,9), Space.Self);
            changer = changer * -1;
        }

        this.gameObject.transform.Translate(Vector3.back * Time.deltaTime * speed * changer);
    }
}
