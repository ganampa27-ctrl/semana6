using UnityEngine;

public class ejercicio7 : MonoBehaviour
{
    double[] numeros = new double[2] { 23.4,40.03 };

    void Start()
    {
        double temp = numeros[0];//->A
        numeros[0] = numeros[1];//-> B , B
        numeros[1] = temp; //->B,A


        print("numero :" + numeros[0]);//-> A
        print("numero :" + numeros[1]);//-> B
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
