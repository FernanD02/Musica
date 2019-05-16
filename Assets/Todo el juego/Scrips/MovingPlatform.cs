using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {

    //public GameObject Jugador;
    public GameObject PlataformaMov;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Log")
        {
            //Jugador.transform.parent = PlataformaMov.transform;
            other.gameObject.transform.parent = PlataformaMov.transform;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Log")
        {
            //Jugador.transform.parent = null;
            other.gameObject.transform.parent = null;
        }
    }

}
