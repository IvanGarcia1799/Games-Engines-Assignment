using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed = 50;
        public float scale = 50;
    public float rotSpeed = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float c = Input.GetAxis("Vertical");
        transform.Translate(0, 0, c * speed * Time.deltaTime);

        float r = Input.GetAxis("Horizontal");
        transform.Rotate(0, r * rotSpeed * Time.deltaTime, 0);

        float newspeed = speed;
        newspeed = Mathf.Lerp(newspeed, 1 + (AudioAnalyzer.bands[1] * scale), Time.deltaTime * 1.0f);
        speed = newspeed;
    }
}
