using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogNoOff : MonoBehaviour {

    public GameObject CemetaryProps;
    public GameObject Fog1;
    public GameObject Fog2;
    public GameObject Fog3;
    public GameObject Fog4;
    public bool HouseGone = false;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Fog1Collider")
        {
            Fog1.SetActive(true);
            if (other.gameObject.name == "Fog1Collider" && HouseGone == true)
            {
                CemetaryProps.SetActive(true);
            }

        }

        if (other.gameObject.name == "Fog2Collider")
        {
            Fog2.SetActive(true);
        }

        if (other.gameObject.name == "Fog3Collider")
        {
            Fog3.SetActive(true);
        }

        if (other.gameObject.name == "Fog4Collider")
        {
            Fog4.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Fog1Collider")
        {
            Fog1.SetActive(false);
            if (other.gameObject.name == "Fog1Collider" && HouseGone == true)
            {
                CemetaryProps.SetActive(false);
            }
        }

        if (other.gameObject.name == "Fog2Collider")
        {
            Fog2.SetActive(false);
        }

        if (other.gameObject.name == "Fog3Collider")
        {
            Fog3.SetActive(false);
        }

        if (other.gameObject.name == "Fog4Collider")
        {
            Fog4.SetActive(false);
        }
    }
}
