using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {
    
    public GameObject Player;
    public GameObject Sp;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Dead")
        {
            Player.transform.position = Sp.transform.position;
            Player.transform.rotation = Sp.transform.rotation;
        }
    }
}
