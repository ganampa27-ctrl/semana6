using UnityEngine;

public class ejercicio8 : MonoBehaviour
{
    public bool tienellavedorada = true;
    public int level = 15;
    public bool noestaencombate = true;

    void Start()
    {
        if ((tienellavedorada || level > 15) && noestaencombate)
        {
            Debug.Log("Cofre abierto");
        }
        else
        {
            Debug.Log("no puedes abrir el cofre");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}