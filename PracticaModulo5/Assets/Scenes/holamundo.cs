using UnityEngine;

public class holamundo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    Debug.Log("Hola desde Start");
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogWarning("Hola desde Update");
    }

    void FixedUpdate()
    {
        Debug.LogWarning("Hola desde Fixed Update cada 50 frames");
    }

     void LatedUpdate()
    {
        Debug.LogWarning("Hola desde Late Update");
    }

     void OnDisable()
    {
        Debug.LogError("Hola desde ERROR");
    }
}
