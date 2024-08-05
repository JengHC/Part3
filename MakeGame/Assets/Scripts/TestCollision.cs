using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollision : MonoBehaviour
{
    // 1. 나 혹은 상대 한테 RigidBody 있어야 한다. (Iskinematic : off)
    // 2. 나한테 Collider가 있어야 한다. (IsTrigger : off)
    // 3. 상대한테 Collider 가 있어야 한다. (IsTrigger : off)
    // 3가지 조건이 만족되어야 CollisionEnter가 적용된다.
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Collision @ {collision.gameObject.name}!");
    }

    // 1. 둘 다 Collider가 있어야 한다.
    // 2. 둘 중 하나는 IsTrigger : O
    // 3. 둘 중 하나는 RigidBody가 있어야 한다.
    private void OnTriggerEnter(Collider other)
    {
        
        Debug.Log($"Triger @{other.gameObject.name} !");
    }

    void Start()
    {
        
    }

    void Update()
    {

        Vector3 look = transform.TransformDirection(Vector3.forward);
        Debug.DrawRay(transform.position + Vector3.up*1, look * 10, Color.red);

        RaycastHit[] hits;
        hits = Physics.RaycastAll(transform.position + Vector3.up, look,10);

        foreach(RaycastHit hit in hits)
        {
            Debug.Log($"Rayacs {hit.collider.gameObject.name}!");
        }

        //if (Physics.Raycast(transform.position, Vector3.forward,out hit,10))
        //{

        //    Debug.Log($"Rayacs {hit.collider.gameObject.name}!");
        //}
    }
}
