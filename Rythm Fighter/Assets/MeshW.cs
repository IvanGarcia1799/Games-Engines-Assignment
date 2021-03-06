﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshW : MonoBehaviour
{

    Mesh mesh;
    Vector3[] vertices;
    int[] triangles;

    public int xValue = 20;
    public int zValue = 20;
    public float scale = 10;
    // Start is called before the first frame update
    void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        CreateShape();
        UpdateMesh();
    }

    void CreateShape()
    {
        vertices = new Vector3[(xValue + 1) * (zValue + 1)];

        int vertix = 0;
        for (int i = 0; i <=zValue; i++)
        {
            for (int j = 0; j <= xValue; j++)
            {
                float y = Mathf.PerlinNoise((j  + this.transform.position.x)/5.0f, (i + this.transform.position.z)/5.0f) * 5;
                vertices[vertix] = new Vector3(j, y, i);
                vertix++;
            }
        }

        triangles = new int[xValue * zValue * 6];
        
        int vertiy = 0;
        int trian = 0;
        for(int j=0; j < zValue; j++)
        {
            for (int i = 0; i < xValue; i++)
            {    
                triangles[trian + 0] = vertiy + 0;
                triangles[trian + 1] = vertiy + xValue + 1;
                triangles[trian + 2] = vertiy + 1;
                triangles[trian + 3] = vertiy + 1;
                triangles[trian + 4] = vertiy + xValue + 1;
                triangles[trian + 5] = vertiy + xValue + 2;

                vertiy++;
                trian += 6;
            }
            vertiy++;
        }
    }

    void UpdateMesh()
    {
        mesh.Clear();

        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();
        mesh.RecalculateBounds();
        MeshCollider meshCollider = gameObject.GetComponent<MeshCollider>();
        meshCollider.sharedMesh = mesh;
    }

    void Update()
    {
        Color orbColor = this.GetComponent<Renderer>().material.color;
        orbColor.r = Mathf.Lerp(orbColor.r, 0.1f + (Mathf.Abs(AudioAnalyzer.spectrum[1]) * scale), Time.deltaTime * 10);
        orbColor.b = Mathf.Lerp(orbColor.b, 0.1f + (Mathf.Abs(AudioAnalyzer.spectrum[1]) * scale), Time.deltaTime * 10);
        orbColor.b = Mathf.Lerp(orbColor.g, 0.1f + (Mathf.Abs(AudioAnalyzer.spectrum[1]) * scale), Time.deltaTime * 10);
        this.GetComponent<Renderer>().material.color = orbColor;
    }
}
