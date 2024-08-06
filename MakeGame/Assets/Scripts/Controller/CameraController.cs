using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    Define.CameraMode _mode = Define.CameraMode.QuarterView;

    [SerializeField]
    Vector3 _delta = new Vector3(0.0f,4.5f,-3.0f);

    [SerializeField]
    GameObject _player = null;

    void Start()
    {
        
    }

    void LateUpdate()
    {
        
        float _playerhight = 1.0f; // 캐릭터 원하는 높이
        Vector3 playerPosition = _player.transform.position + Vector3.up * _playerhight;

        if (_mode == Define.CameraMode.QuarterView)
        {
            RaycastHit hit;
            if(Physics.Raycast(_player.transform.position, _delta, out hit, _delta.magnitude, LayerMask.GetMask("Wall")))
            {
                // dist : 거리
                float dist = (hit.point - _player.transform.position).magnitude * 1.0f;
                transform.position = _player.transform.position + _delta.normalized * dist;
            }
            else
            {
                transform.position = _player.transform.position + _delta;
                transform.LookAt(_player.transform);
            }
        }
    }

    public void SetQuaterView(Vector3 delta)
    {
        _mode = Define.CameraMode.QuarterView;
        _delta = delta;
    }
}
