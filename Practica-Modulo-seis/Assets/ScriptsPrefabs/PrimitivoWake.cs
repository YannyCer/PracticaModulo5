using UnityEngine;

public class PrimitivoWake : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    
    void Awake()
    {
        GetComponent<MeshRenderer>().material.color = ColorAleatorio();
    }

    Color ColorAleatorio()
    {
        return new Color(Random.value, Random.value, Random.value);
    }
}
