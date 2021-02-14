using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSpriteFollower : MonoBehaviour
{
    private Vector3 offset;

    public GameObject plr;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - plr.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plr.transform.position + offset;
    }
}