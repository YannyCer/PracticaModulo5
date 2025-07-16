using UnityEngine;

public class componente2 : MonoBehaviour
{
    private void Awake()
    {
      
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(componente1.miObjeto.name);
    }

    // Update is called once per frame
    void Update()
    {
      

    }
}