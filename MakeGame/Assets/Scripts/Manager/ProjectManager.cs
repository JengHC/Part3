using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class ProjectManager : MonoBehaviour
{
    static ProjectManager s_instance;
    static ProjectManager Instance { get { Init();  return s_instance; } }

    InputManager _input = new InputManager();
    ResourceManager _resource = new ResourceManager();
    UIManager _ui = new UIManager();

    public static InputManager Input { get { return Instance._input; } }
    public static ResourceManager Resource { get { return Instance._resource; } }
    public static UIManager UI { get { return Instance._ui; } }

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
