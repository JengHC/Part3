using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollision : MonoBehaviour
{
    // 1. �� Ȥ�� ��� ���� RigidBody �־�� �Ѵ�. (Iskinematic : off)
    // 2. ������ Collider�� �־�� �Ѵ�. (IsTrigger : off)
    // 3. ������� Collider �� �־�� �Ѵ�. (IsTrigger : off)
    // 3���� ������ �����Ǿ�� CollisionEnter�� ����ȴ�.
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Collision @ {collision.gameObject.name}!");
    }

    // 1. �� �� Collider�� �־�� �Ѵ�.
    // 2. �� �� �ϳ��� IsTrigger : O
    // 3. �� �� �ϳ��� RigidBody�� �־�� �Ѵ�.
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
