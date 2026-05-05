using System.Collections.Generic;
using UnityEngine;

public class ejercicio10 : MonoBehaviour
{
    /*10 Mostrar tamaño
 Imprime la cantidad de elementos de una lista 
    usando Count.
     */
    List<string> lista = new List<string>();  
    void Start()
    {
        lista.Add("manzana");
        lista.Add("banana");
        lista.Add("naranja");

        print("Cantidad de elementos en la lista: " + lista.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
