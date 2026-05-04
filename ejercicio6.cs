using UnityEngine;

public class ejercicio6 : MonoBehaviour
{
    decimal[] numeros = new decimal[5];
    void Start()
    {
        numeros[0] = 20.5m;
        numeros[1] = 12.3m;
        numeros[3] = 1.9m;
        numeros[4] = 40.37m;

        print("primero elemento :" + numeros[0]);
        print("ultimo elemento :" + numeros[numeros.Length - 1]);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
