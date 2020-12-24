using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbFollow : MonoBehaviour
{
    public GameObject temp;
    public Transform target;
    public Vector3 lastPos;
    public Vector3 displace;
    public Vector3 orbStart;
    public Vector3 targetStart;
    // Start is called before the first frame update
    void Start()
    {
        temp = GameObject.Find("Player");
        target = temp.transform;
        lastPos = target.position;
        targetStart = target.position;
        orbStart = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(target.transform.position != lastPos)
        {
            displace = target.transform.position - targetStart;
            transform.position = Vector3.Lerp(transform.position, orbStart + displace, Time.deltaTime);
            transform.LookAt(target.parent);
        }
        lastPos = target.transform.position;
    }    
} 
