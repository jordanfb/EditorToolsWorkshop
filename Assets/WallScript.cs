using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour {

    public Vector2[] meshPoints;

    private MeshFilter meshFilter;
    private PolygonCollider2D polyCollider;

    private Mesh mesh;

	// Use this for initialization
	void Start () {
        meshFilter = GetComponent<MeshFilter>();
        polyCollider = GetComponent<PolygonCollider2D>();
        SetMesh();
	}

    public void SetMesh()
    {
        meshFilter = GetComponent<MeshFilter>();
        polyCollider = GetComponent<PolygonCollider2D>();
        Triangulator triangulator = new Triangulator(meshPoints);
        int[] triangles = triangulator.Triangulate();
        mesh = new Mesh();

        List<Vector3> meshPoint3s = new List<Vector3>();
        foreach (Vector2 v in meshPoints)
        {
            meshPoint3s.Add(v);
        }
        mesh.vertices = meshPoint3s.ToArray();
        mesh.triangles = triangles;
        mesh.RecalculateNormals();

        meshFilter.mesh = mesh;
        polyCollider.points = meshPoints;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
