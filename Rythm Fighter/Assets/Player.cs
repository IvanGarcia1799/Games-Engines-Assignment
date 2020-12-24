using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float scale = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Color orbColor = this.GetComponent<Renderer>().material.color;
        orbColor.r = Mathf.Lerp(orbColor.r, 0.1f + (Mathf.Abs(AudioAnalyzer.spectrum[1]) * scale), Time.deltaTime * 10);
        orbColor.b = Mathf.Lerp(orbColor.b, 0.1f + (Mathf.Abs(AudioAnalyzer.spectrum[1]) * scale), Time.deltaTime * 10);
        this.GetComponent<Renderer>().material.color = orbColor;
    }
}
