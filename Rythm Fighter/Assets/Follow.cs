using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;
   // public float scale = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.transform.position, Time.deltaTime);
        transform.LookAt(target.parent);
        //Vector3 pos = transform.position;
        //pos.z = Mathf.Lerp(ls.y, 1 + (AudioAnalyzer.bands[1] * scale), Time.deltaTime * 3.0f);
    }
}
