using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Tank
{
    public float speed = 10.0f;
    
}

class FastTank : Tank
{

}


class Player
{

}


public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float speed = 10.0f;

    void Start()
    {
        ProjectManager.input.KeyAction -= OnKeyboard;
        ProjectManager.input.KeyAction += OnKeyboard;

        Tank tank1 = new Tank(); // Tank Instance를 만든다.
        tank1.speed = 11.0f;
        Tank tank2 = new Tank(); // Tank Instance를 만든다.
        tank2.speed = 21.0f;
        Tank tank3 = new Tank(); // Tank Instance를 만든다.
        Tank tank4 = new Tank(); // Tank Instance를 만든다.
        Tank tank5 = new Tank(); // Tank Instance를 만든다.



    }

    void Update()
    {

    }

    void OnKeyboard()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), 0.2f);

            transform.position += Vector3.forward * Time.deltaTime * speed;

        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), 0.2f);

            transform.position += Vector3.back * Time.deltaTime * speed;

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
