using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Rigidmovement : MonoBehaviour
{
    [SerializeField]
    Rigidbody myrigidbody;
    GameObject Ball;
    [SerializeField]
    GameObject Player;
    [SerializeField]
    GameObject death;
    // Start is called before the first frame update
    void Start()
    {
        myrigidbody = GetComponent<Rigidbody>();
        myrigidbody.velocity = new Vector3(0, -5, 0);
       
    }

    // Update is called once per frame
    public void Update()
    {
        int lives = 3;
        float speed =5;
        myrigidbody.velocity = myrigidbody.velocity.normalized * speed;
        if (transform.position.y<-7)
        {
            Player.transform.position = new Vector3(0, -4, 0);
            transform.position = new Vector3(0, -1, 0);
            lives=lives-1;

            
        }
        if (transform.position.y > 15)
        {
            Player.transform.position = new Vector3(0, -4, 0);
            transform.position = new Vector3(0, -1, 0);
        }
        if(lives>=0)
        {
            
        }

    }
}
