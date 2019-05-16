using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{

    public GameObject Contador;
    //PrnderVelas total;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Counter")
        {
            Contador.SetActive(true);
        }

    }
}
