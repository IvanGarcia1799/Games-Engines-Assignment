using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour
{
    public int elements = 80;
    public int map = 0;
    public float radius = 3;
    public float scale = 10;
    public float rotSpeed = 200;
    List<GameObject> orbList = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        float theta = Mathf.PI * 2.0f / (float) elements;
        map = (int)(Mathf.Floor(AudioAnalyzer.frameSize/elements));
        for(int i = 0 ; i < elements ; i ++)
        {
            GameObject sp = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sp.AddComponent<OrbFollow>();
            sp.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            Vector3 pos = new Vector3(Mathf.Sin(theta * i) * radius, 0, Mathf.Cos(theta * i) * radius);
            sp.transform.position = transform.TransformPoint(pos);
            sp.GetComponent<Renderer>().material.color = 
                Color.HSVToRGB(i / (float) elements, 1, 1);
            orbList.Add(sp);
        }
    }

    // Update is called once per frame
    void Update()
    {
        int curs = 0;
        for(int i = 0 ; i < orbList.Count ; i ++)
        {
            Color orbColor = orbList[i].GetComponent<Renderer>().material.color;
            orbColor.r = Mathf.Lerp(orbColor.r, 0.1f + (Mathf.Abs(AudioAnalyzer.spectrum[curs]) * scale), Time.deltaTime * 10);
            orbList[i].GetComponent<Renderer>().material.color = orbColor;
            Vector3 lscale = orbList[i].transform.localScale; 
            lscale.y = Mathf.Lerp(lscale.y, 0.2f + (Mathf.Abs(AudioAnalyzer.spectrum[curs]) * scale), Time.deltaTime * 10);
            lscale.x = Mathf.Lerp(lscale.x, 0.1f + (Mathf.Abs(AudioAnalyzer.spectrum[curs]) * scale), Time.deltaTime * 10);
            orbList[i].transform.localScale = lscale;
            curs += map;
        }
    }
}