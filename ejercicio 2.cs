using System.Collections.Generic;
using UnityEngine;

public class ejercicio2 : MonoBehaviour
{
    List<string> inventario = new List<string>();
    void Start()
    {
        inventario.Add("mazo");
        inventario.Add("espada");
        inventario.Add("pocion");
   
        int randomIndex = Random.Range(0, inventario.Count - 1);
        print("elemento :" + inventario[randomIndex]);
    }
}
