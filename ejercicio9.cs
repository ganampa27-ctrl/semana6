using System.Collections.Generic;
using UnityEngine;

public class ejercicio9 : MonoBehaviour
{
    
    List<string> elementos = new List<string>();
    void Start()
    {
        elementos.Add("espada");
        elementos.Add("escudo");
        elementos.Add("armadura");
        
        elementos.Remove("escudo");
        print("Elementos restantes: " + elementos.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
