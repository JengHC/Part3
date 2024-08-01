using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 1. 위치 벡터
// 2. 방향 벡터
struct MyVector
{

    public float x;
    public float y;
    public float z;
    
    // 피타고라스
    //          +
    //     +    +
    // +--------+
    public float magnitude { get { return Mathf.Sqrt(x * x + y * y + z * z); } }

    // normalized 단위벡터
    public MyVector normalized { get { return new MyVector(x / magnitude, y / magnitude, z / magnitude); } }

    public MyVector(float x, float y, float z) { this.x = x; this.y = y; this.z = z; }

    public static MyVector operator + (MyVector a, MyVector b)
    {
        return new MyVector(a.x + b.x, a.y + b.y, a.z + b.z);
    }

    public static MyVector operator - (MyVector a, MyVector b)
    {
        return new MyVector(a.x - b.x, a.y - b.y, a.z - b.z);
    }

    public static MyVector operator *(MyVector a, float d)
    {
        return new MyVector(a.x * d, a.y * d, a.z * d);
    }

}
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float speed = 10.0f;

    void Start()
    {
        MyVector to = new MyVector(10.0f, 0.0f, 0.0f);
        MyVector from = new MyVector(5.0f, 0.0f, 0.0f);
        MyVector dir = to - from; //(-5.0f,0.0f,0.0f)

        dir = dir.normalized; // (1.0f; 0.0f, 0.0f)

        MyVector newPos = from + dir * speed;

        // 방향 벡터
            // 1. 거리(크기) 5  magnitude
            // 2. 실제 방향 ->  normalized

    }
    //GameObject(Player)
        // trnaform
        //PlayerController(*)
    void Update()
    {
        //transform.position.magnitude;
        //transform.position.normalized;

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
