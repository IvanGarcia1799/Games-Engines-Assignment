using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshW : MonoBehaviour
{

    Mesh mesh;
    Vector3[] vertices;
    int[] triangles;

    public int xValue = 20;
    public int zValue = 20;
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
                vertices[vertix] = new Vector3(j, 0, i);
                vertix++;
            }
        }
    }

    void UpdateMesh()
    {
        mesh.Clear();

        mesh.vertices = vertices;
        mesh.triangles = triangles;

        mesh.RecalculateNormals();
    }

    private void OnDrawGizmos() 
    {
        if(vertices == null)
            return;

        for (int i = 0; i < vertices.Length; i++)
        {
            Gizmos.DrawSphere(vertices[i], .1f);
        }
    }
}
