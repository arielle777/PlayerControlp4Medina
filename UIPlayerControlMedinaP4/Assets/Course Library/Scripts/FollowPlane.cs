using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class FollowPlane : MonoBehaviour
{
    private Vector3 offset = new Vector3(30, 0, 10);

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}