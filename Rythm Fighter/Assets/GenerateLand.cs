using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Tile
{
    public GameObject theTile;
    public float creationTime;

    public Tile(GameObject t, float cTime) {
        {
            theTile = t;
            creationTime = cTime;
        }
    }
}
public class GenerateLand : MonoBehaviour
{

    public GameObject plane;
    public GameObject player;

    int planeSize = 20;
    int renderSize = 14;

    Vector3 startPos;

    Hashtable tiles = new Hashtable();

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.transform.position = Vector3.zero;
        startPos = Vector3.zero;

        float updateTime = Time.realtimeSinceStartup;

        for(int i = -renderSize; i < renderSize; i++)
        {
            for(int j = -renderSize; j < renderSize; j++)
            {
                Vector3 pos = new Vector3((i * planeSize + startPos.x), 0, (j * planeSize + startPos.z));

                GameObject t = (GameObject) Instantiate(plane, pos, Quaternion.identity);

                string tileName = "Tile_" + ((int)(pos.x)).ToString() + "_" + ((int)(pos.z)).ToString();
                t.name = tileName;
                Tile tile = new Tile(t, updateTime);
                tiles.Add(tileName, tile);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
