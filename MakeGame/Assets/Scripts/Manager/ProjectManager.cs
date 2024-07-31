using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectManager : MonoBehaviour
{
    static ProjectManager s_instance;
    public static ProjectManager Instance { get { Init();  return s_instance; } }

    void Start()
    {
        Init();
    }

    void Update()
    {
        
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
