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
    public Vector3 fixY;
    public float rotSpeed = 200;
    public float scale = 2;
    // Start is called before the first frame update
    void Start()
    {
        temp = GameObject.Find("Player");
        target = temp.transform;
        lastPos = target.position;
        targetStart = target.position;
        fixY = new Vector3(0,3f,0);
        orbStart = transform.position + fixY;
    }

    // Update is called once per frame
    void Update()
    {
        if(target.transform.position != lastPos)
        {
            transform.Rotate(AudioAnalyzer.smoothedAmplitude * Time.deltaTime * rotSpeed, AudioAnalyzer.smoothedAmplitude * Time.deltaTime * rotSpeed, AudioAnalyzer.smoothedAmplitude * Time.deltaTime * rotSpeed);
            for(int i= 0; i<100; i++)
            {
                Vector3 pos = orbStart;
                pos.y = Mathf.Lerp(pos.y, 5f + (AudioAnalyzer.bands[1] * scale), Time.deltaTime * 1.0f);
                orbStart.y=pos.y;
                displace = target.transform.position - targetStart;
                transform.position = Vector3.Lerp(transform.position, orbStart + displace, Time.deltaTime);
            }
        }
        lastPos = target.position;
    }    
} 
