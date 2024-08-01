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

    float _yAngle = 0.0f;
    void Update()
    {

        _yAngle += Time.deltaTime * 100.0f;
        // 절대 회전값
        //transform.eulerAngles = new Vector3(0.0f, _yAngle, 0.0f);

        // +-delta
        //transform.Rotate(new Vector3(0.0f, Time.deltaTime * 100.0f, 0.0f));

        //transform.rotation = Quaternion.Euler(new Vector3(0.0f, _yAngle, 0.0f));


        if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward),0.2f);

            transform.position += Vector3.forward * Time.deltaTime * speed;

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), 0.2f);

            transform.position += Vector3.back * Time.deltaTime* speed;

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), 0.2f);

            transform.position += Vector3.left * Time.deltaTime * speed;

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), 0.2f);

            transform.position += Vector3.right * Time.deltaTime * speed;

        }
    }
}
