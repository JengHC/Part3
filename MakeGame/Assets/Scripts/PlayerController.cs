using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float speed = 10.0f;

    void Start()
    {
        
    }
    //GameObject(Player)
        // trnaform
        //PlayerController(*)
    void Update()
    {
        // Local -> Global;
        // TransformDirection
        
        // Global -> Local;
        // InverseTransformDirection

        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward *Time.deltaTime* speed);

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime* speed);

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime* speed);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime* speed);

        }
    }
}