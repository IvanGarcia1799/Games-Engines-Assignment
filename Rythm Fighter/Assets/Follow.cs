using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;
    public float scale = 3;
    public GameObject temp;
    // Start is called before the first frame update
    void Start()
    {
        temp = GameObject.Find("Follower");
        target= temp.transform;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.transform.position, Time.deltaTime);
        transform.LookAt(target.parent);
        Vector3 pos = transform.position;
        pos.y = Mathf.Lerp(pos.y, 5f + (AudioAnalyzer.bands[1] * scale), Time.deltaTime * 1.0f);
        transform.position = pos;
    }
}
