using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class move : MonoBehaviour
{
    [SerializeField]
    Rigidbody myrigidbody;
    [SerializeField] float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        myrigidbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");

        myrigidbody.velocity = new Vector3(x, 0, 0) * speed;
    }

}
