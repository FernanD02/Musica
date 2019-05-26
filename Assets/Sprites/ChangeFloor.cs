using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeFloor : MonoBehaviour
{
    public int typeFloor;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponentInChildren<FloorType>())
        {
            other.gameObject.GetComponentInChildren<FloorType>().floor = typeFloor;
        }
    }
}
