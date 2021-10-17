using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    //Variables
    public static int cantMonedas = 0;
    // Start is called before the first frame update

    void Start()
    {
        Moneda.cantMonedas++;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnDestroy()
    {
        Moneda.cantMonedas--;

        if(Moneda.cantMonedas <= 0)
        {
            GameObject Timer = GameObject.Find("GameTimer");
            Destroy(Timer);
            Debug.Log("El juego ha terminado, has ganado!!!");
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Se ha recolectado la moneda #" + Moneda.cantMonedas);
        if (collider.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
