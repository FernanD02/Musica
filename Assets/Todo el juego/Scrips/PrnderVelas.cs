using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrnderVelas : MonoBehaviour {

    public GameObject Texto;
    public GameObject Fire;
    public GameObject Candelarios;
    public Transform Vela1;
    public Transform Vela2;
    public Transform Vela3;
    public Transform Vela4;
    public Transform Vela5;
    bool inTrigger1 = false;
    bool inTrigger2 = false;
    bool inTrigger3 = false;
    bool inTrigger4 = false;
    bool inTrigger5 = false;
    bool vel1 = false;
    bool vel2 = false;
    bool vel3 = false;
    bool vel4 = false;
    bool vel5 = false;
    public int numVelasPren = 0;
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;
    public GameObject dash;
    public GameObject fire;




    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Vela1" && vel1 == false)
        {
            inTrigger1 = true;
            Texto.SetActive(true);
        }

        if (other.gameObject.name == "Vela2" && vel2 == false)
        {
            inTrigger2 = true;
            Texto.SetActive(true);
        }

        if (other.gameObject.name == "Vela3" && vel3 == false)
        {
            inTrigger3 = true;
            Texto.SetActive(true);
        }

        if (other.gameObject.name == "Vela4" && vel4 == false)
        {
            inTrigger4 = true;
            Texto.SetActive(true);
        }

        if (other.gameObject.name == "Vela5" && vel5 == false)
        {
            inTrigger5 = true;
            Texto.SetActive(true);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Vela1")
        {
            inTrigger1 = false;
            Texto.SetActive(false);
        }

        if (other.gameObject.name == "Vela2")
        {
            inTrigger2 = false;
            Texto.SetActive(false);
        }

        if (other.gameObject.name == "Vela3")
        {
            inTrigger3 = false;
            Texto.SetActive(false);
        }

        if (other.gameObject.name == "Vela4")
        {
            inTrigger4 = false;
            Texto.SetActive(false);
        }

        if (other.gameObject.name == "Vela5")
        {
            inTrigger5 = false;
            Texto.SetActive(false);
        }
    }

    void Update ()
    {

        if (numVelasPren == 5)
        {
            //Candelarios.SetActive(true);
            SceneManager.LoadScene("Nivel_2");
        }

        if (Input.GetButtonUp("Jump") && inTrigger1 == true && vel1 == false)
        {
            Instantiate(Fire, Vela1.position, Vela1.rotation);
            vel1 = true;
            numVelasPren += 1;
        }

        if (Input.GetButtonUp("Jump") && inTrigger2 == true && vel2 == false)
        {
            Instantiate(Fire, Vela2.position, Vela2.rotation);
            vel2 = true;
            numVelasPren += 1;
        }

        if (Input.GetButtonUp("Jump") && inTrigger3 == true && vel3 == false)
        {
            Instantiate(Fire, Vela3.position, Vela3.rotation);
            vel3 = true;
            numVelasPren += 1;
        }

        if (Input.GetButtonUp("Jump") && inTrigger4 == true && vel4 == false)
        {
            Instantiate(Fire, Vela4.position, Vela4.rotation);
            vel4 = true;
            numVelasPren += 1;
        }

        if (Input.GetButtonUp("Jump") && inTrigger5 == true && vel5 == false)
        {
            Instantiate(Fire, Vela5.position, Vela5.rotation);
            vel5 = true;
            numVelasPren += 1;
        }
        /*
        if (numVelasPren == 1)
        {
            fire.SetActive(true);
            one.SetActive(true);
            two.SetActive(false);
            three.SetActive(false);
            four.SetActive(false);
            five.SetActive(true);
            dash.SetActive(true);
        }
        if (numVelasPren == 2)
        {
            fire.SetActive(true);
            one.SetActive(false);
            two.SetActive(true);
            three.SetActive(false);
            four.SetActive(false);
            five.SetActive(true);
            dash.SetActive(true);
        }
        if (numVelasPren == 3)
        {
            fire.SetActive(true);
            one.SetActive(false);
            two.SetActive(false);
            three.SetActive(true);
            four.SetActive(false);
            five.SetActive(true);
            dash.SetActive(true);
        }
        if (numVelasPren == 4)
        {
            fire.SetActive(true);
            one.SetActive(false);
            two.SetActive(false);
            three.SetActive(false);
            four.SetActive(true);
            five.SetActive(true);
            dash.SetActive(true);
        }

        if (numVelasPren == 5)
        {
            fire.SetActive(false);
            one.SetActive(false);
            two.SetActive(false);
            three.SetActive(false);
            four.SetActive(false);
            five.SetActive(false);
            dash.SetActive(false);
        }
        */

    }
}
