using System.Collections.Generic;
using UnityEngine;

public class ejercicio4 : MonoBehaviour
{
    public List<string> enemigos = new List<string>();
    void Start()
    {
        enemigos.Add("slime");
        enemigos.Add("orco");
        enemigos.Add("Esqueleto");
        enemigos.Add("criper");

        int randomIndex = Random.Range(0, enemigos.Count - 1);
        print("elemento :" + enemigos[randomIndex]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
