using UnityEngine;

public class ejercicio9 : MonoBehaviour
{
    public int mana = 25;
    public int stamina = 55;
    public bool enemigocerca = true;
    void Start()
    {
        if (mana > 20 && stamina > 50 && enemigocerca)
        {
            Debug.Log("Puede lanzar habilidad especial");
        }
        else
        {
            Debug.Log("No puedes lanzar habilidad especial");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
