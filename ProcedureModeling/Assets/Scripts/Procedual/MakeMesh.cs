using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeMesh : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Make();
        MakeTriangle();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject Make()
    {
        //Create Object.
        GameObject obj = new GameObject("Mesh",typeof(MeshFilter),typeof(MeshRenderer));
        Mesh mesh = new Mesh();
        
        //Give Material to object.
        Material mat = new Material(Shader.Find("Standard"));

        Vector3[] vertices = new Vector3[4];
        Vector2[] uvs = new Vector2[4];
        int[] triangles = new int[6];

        //each of vertices has location.
        vertices[0] = new Vector3(0, 1, 0);
        vertices[1] = new Vector3(1, 1, 0);
        vertices[2] = new Vector3(0, 0, 0);
        vertices[3] = new Vector3(1, 0, 0);
        
        //uv coordinates have range from 0 to 1.
        // match to the vertex in the same index.
        uvs[0] = new Vector2(0, 1);
        uvs[1] = new Vector2(1, 1);
        uvs[2] = new Vector2(0, 0);
        uvs[3] = new Vector2(1, 0);
        
        //Select draw order
        triangles[0] = 0;
        triangles[1] = 1;
        triangles[2] = 2;
        triangles[3] = 1;
        triangles[4] = 3;
        triangles[5] = 2;
        
        //give value to mesh property
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.uv = uvs;
        
        
        obj.GetComponent<MeshFilter>().mesh = mesh;
        obj.GetComponent<MeshRenderer>().material = mat;

        return obj;
    }
    public GameObject MakeTriangle()
    {
        //Create Object.
        GameObject obj = new GameObject("Mesh",typeof(MeshFilter),typeof(MeshRenderer));
        Mesh mesh = new Mesh();
        
        //Give Material to object.
        Material mat = new Material(Shader.Find("Standard"));

        Vector3[] vertices = new Vector3[3];
        Vector2[] uvs = new Vector2[3];
        int[] triangles = new int[3];

        //each of vertices has location.
        vertices[0] = new Vector3(0, 1, 0);
        vertices[1] = new Vector3(1, 1, 0);
        vertices[2] = new Vector3(0, 0, 0);

        
        //uv coordinates have range from 0 to 1.
        // match to the vertex in the same index.
        uvs[0] = new Vector2(0, 1);
        uvs[1] = new Vector2(1, 1);
        uvs[2] = new Vector2(0, 0);

        
        //Select draw order
        triangles[0] = 0;
        triangles[1] = 1;
        triangles[2] = 2;

        
        //give value to mesh property
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.uv = uvs;
        
        
        obj.GetComponent<MeshFilter>().mesh = mesh;
        obj.GetComponent<MeshRenderer>().material = mat;

        return obj;
    }
}
