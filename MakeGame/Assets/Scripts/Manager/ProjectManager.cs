using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectManager : MonoBehaviour
{
    static ProjectManager s_instance;
    static ProjectManager Instance { get { Init();  return s_instance; } }

    InputManager _input = new InputManager();
    public static InputManager input { get { return Instance._input; } }

    void Start()
    {
        Init();
    }

    void Update()
    {
        _input.OnUpdate();
    }
    static void Init()
    {
        if(s_instance == null)
        {
            GameObject go = GameObject.Find("@ProjectManager");
            if(go==null)
            {
                go = new GameObject { name = "@ProjectManger" };
                go.AddComponent<ProjectManager>();
            }
            DontDestroyOnLoad(go);
            s_instance = go.GetComponent<ProjectManager>();
        }
    }
}
