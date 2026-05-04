using UnityEngine;

public class ejercicio3 : MonoBehaviour
{
    int[] vida = new int[3];
    void Start()
    {
        vida[0] = 20;
        vida[1] = 5;
        vida[2] = 8;

        print("puntaje :" + vida[0]);
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
