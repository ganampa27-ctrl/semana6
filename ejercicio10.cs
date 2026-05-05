using UnityEngine;

public class ejercicio10 : MonoBehaviour
{
    public bool vealjugador = true;
    public bool estacerca = true;
    void Start()
    {
        if(vealjugador && estacerca)
        {
            Debug.Log("atacar");
        }
        else if(vealjugador && !estacerca)
        {
            Debug.Log("perseguir");
        }
        else
        {
            Debug.Log("patrullar");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
