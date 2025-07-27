using UnityEngine;

public class PrimitivoUno : MonoBehaviour
{
    GameObject objToSpawn;

    Vector3[] vertices = {
        new Vector3(0, 0, 0),
        new Vector3(1, 0, 0),
        new Vector3(1, 1, 0),
        new Vector3(0, 1, 0),
        new Vector3(0, 1, 1),
        new Vector3(1, 1, 1),
        new Vector3(1, 0, 1),
        new Vector3(0, 0, 1),
    };

    int[] triangulos = {
        0, 2, 1,
        0, 3, 2,
        3, 4, 2,
        2, 4, 5,
        1, 2, 5,
        1, 5, 6,
        6, 5, 4,
        6, 4, 7,
        0, 7, 3,
        3, 7, 4,
        0, 6, 7,
        0, 1, 6
    };

    void Start()
    {
        objToSpawn = new GameObject("PrimitivoUno");

        var meshFilter = objToSpawn.AddComponent<MeshFilter>();
        Mesh mesh = new Mesh();
        mesh.vertices = vertices;
        mesh.triangles = triangulos;
        mesh.RecalculateNormals();
        meshFilter.mesh = mesh;

        var boxCollider = objToSpawn.AddComponent<BoxCollider>();
        boxCollider.center = new Vector3(0.5f, 0.5f, 0.5f);

        var renderer = objToSpawn.AddComponent<MeshRenderer>();
        renderer.material.color = new Color(Random.value, Random.value, Random.value);

        objToSpawn.transform.position = Vector3.one;
    }
}