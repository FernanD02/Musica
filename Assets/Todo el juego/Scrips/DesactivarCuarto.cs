using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivarCuarto : MonoBehaviour {

    public GameObject Cuarto;
    public GameObject InvisibleWall;
    public GameObject PropsDeCementerio;
    public GameObject Player;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "DesaparecerCuarto")
        {
            Cuarto.SetActive(false);
            InvisibleWall.SetActive(true);
            PropsDeCementerio.SetActive(true);
        }
    }
}
