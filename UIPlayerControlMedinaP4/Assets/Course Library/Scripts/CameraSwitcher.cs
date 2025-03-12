using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera MainCamera;
        public Camera Camera2;
    // Start is called before the first frame update
    void Start()
    {
        MainCamera.enabled = true;
        Camera2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            MainCamera.enabled = !MainCamera.enabled;
            Camera2.enabled = !Camera2.enabled;  
        }
    }
}
