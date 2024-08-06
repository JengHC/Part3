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
        // Local <-> World <-> (VeiwPort <-> Screen) (화면) 

        // Debug.Log(Input.mousePosition); // Screen
        //Debug.Log(Camera.main.ScreenToViewportPoint(Input.mousePosition)); // ViewPort

        

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Debug.DrawRay(Camera.main.transform.position, ray.direction * 100.0f, Color.red, 1.0f);


            LayerMask mask = LayerMask.GetMask("Monster") | LayerMask.GetMask("Wall");
            //int mask = (1 << 8) | (1 << 9);


            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                
                Debug.Log($"Raycast Camera @ {hit.collider.gameObject.tag}");
            }
        }


        //if (Input.GetMouseButtonDown(0))
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //    //Vector3 mousPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
        //    //Vector3 dir = mousPos - Camera.main.transform.position;
        //    //dir = dir.normalized;

        //    Debug.DrawRay(Camera.main.transform.position, dir*100.0f, Color.red, 1.0f);

        //    RaycastHit hit;
        //    if (Physics.Raycast(Camera.main.transform.position, dir, out hit, 100.0f))
        //    {
        //        Debug.Log($"Raycast Camera @ {hit.collider.gameObject.name}");
        //    }
        //}       
    }
}
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.AI; // NavMeshAgent를 사용하기 위해 추가

//public class TestCollision : MonoBehaviour
//{
//    private NavMeshAgent navMeshAgent;

//    private void OnCollisionEnter(Collision collision)
//    {
//        Debug.Log($"Collision @ {collision.gameObject.name}!");
//    }

//    private void OnTriggerEnter(Collider other)
//    {
//        Debug.Log($"Trigger @ {other.gameObject.name}!");
//    }

//    void Start()
//    {
//        navMeshAgent = GetComponent<NavMeshAgent>();
//        if (navMeshAgent == null)
//        {
//            Debug.LogError("NavMeshAgent component is missing on this game object.");
//        }
//    }

//    void Update()
//    {
//        // 좌클릭 이벤트 처리
//        if (Input.GetMouseButtonDown(0))
//        {
//            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

//            Debug.DrawRay(Camera.main.transform.position, ray.direction * 100.0f, Color.red, 1.0f);

//            RaycastHit hit;
//            if (Physics.Raycast(ray, out hit, 100.0f))
//            {
//                Debug.Log($"Raycast Camera @ {hit.collider.gameObject.name}");
//            }
//        }

//        // 우클릭 이벤트 처리
//        if (Input.GetMouseButtonDown(1))
//        {
//            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//            RaycastHit hit;
//            if (Physics.Raycast(ray, out hit, 100.0f))
//            {
//                Debug.Log($"Raycast @ {hit.point}");
//                if (navMeshAgent != null)
//                {
//                    navMeshAgent.SetDestination(hit.point);
//                }
//            }
//        }
//    }
//}