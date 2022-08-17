//USES A RIGIDBODY (Unity)//

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCharacterController : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;



    //Start is called before the first frame update//
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    //Update is called once per frame
    void FixedUpdate()
    {
        float moveLR = Input.GetAxis("Horizontal");
        float moveFB = Input.GetAxis("Vertical");

        rb.AddForce(new Vector3(speed * moveLR, 0, speed * moveFB));
    }
}