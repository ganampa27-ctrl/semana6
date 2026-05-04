using UnityEngine;

public class player : MonoBehaviour
{
  int[] puntaje = new int[5];
    void Start()
    {
        puntaje[0] = 20;
        puntaje[1] = 5;
        puntaje[2] = 8;
        puntaje[3] = 30;
        puntaje[4] = 39;
        print("puntaje :" + puntaje[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
