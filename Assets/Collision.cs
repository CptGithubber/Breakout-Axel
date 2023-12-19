using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PANG : MonoBehaviour
{
    [SerializeField]
    Rigidbody myrigidbody;

    // Start is called before the first frame update
    void Start()
    {
        myrigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Foul");
        if (collision.gameObject.name == "Ball")
        {
            GameObject enemyGameobject = collision.gameObject;
         

            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        else if (collision.gameObject.name != "Ball")
        {
            Destroy(gameObject);
        }

    }
}
