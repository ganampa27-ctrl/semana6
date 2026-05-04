
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //arrays
    string[] nombres = new string[4];

    string[] poderes = new string[4] {"smash","dune","fareball","3" };

    List<int> puntaje = new List<int>();

    List<string> nombresDeMounstros = new List<string>();

    void Start()
    {

        nombresDeMounstros.Add("slime");
        nombresDeMounstros.Add("orco");
        nombresDeMounstros.Add("Esqueleto");
        nombresDeMounstros.Add("criper");

        nombresDeMounstros.Remove("slime");

        int randomIndex = Random.Range(0, nombresDeMounstros.Count-1); 

        print("un elmento al azar:" + nombresDeMounstros[randomIndex]);
        /*puntaje.Add(10);
        puntaje.Add(5);
        puntaje.Add(6);
         int*/


        /*
        nombres[0]= "firulais";
        nombres[1]= "Minina";
        nombres[2]= "Michina";
        nombres[3]= "Oso";
        print("primer elemento :"
         */
        // print("primer elemento :" + poderes[  poderes.Length-1 ]);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
