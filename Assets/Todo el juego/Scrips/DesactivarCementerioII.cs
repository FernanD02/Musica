using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivarCementerioII : MonoBehaviour {

    public GameObject Cementerio;
    public GameObject Bosque;
    public GameObject PropsDeCementerio;

    bool PosibilidadDeCambiarACementerio = false;
    bool Safety = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "DesaparecerCementeriov2" && Cementerio.activeSelf == true)
        {
            //////////////	  APARECE BOSQUE	  //////////////
            //////////////DESAPARECE CEMENTERIO//////////////
            Debug.Log("Cementerio Desaparecio");
            Debug.Log("Bosque Aparecio");
            Cementerio.SetActive(false);
            Bosque.SetActive(true);
            PropsDeCementerio.SetActive(false);
        }
        
        if (other.gameObject.name == "DesaparecerCementeriov2Safety" )
        {
            Safety = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "DesaparecerCementeriov2" && Safety == true)
        {
            Cementerio.SetActive(false);
            Bosque.SetActive(true);
            PropsDeCementerio.SetActive(false);
        }

        if (other.gameObject.name == "DesaparecerCementeriov2" && Safety == false)
        {
            Cementerio.SetActive(true);
            Bosque.SetActive(false);
            PropsDeCementerio.SetActive(true);
        }

        if (other.gameObject.name == "DesaparecerCementeriov2" )
        {
            Safety = false;
        }

    }
}
