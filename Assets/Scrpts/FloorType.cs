using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorType : MonoBehaviour
{
    private AudioSource Steps;
    public AudioClip madera;
    public AudioClip tierra;
    public AudioClip concreto;
    public int floor = 1;
    
    void Start()
    {
        Steps = GetComponent<AudioSource>();
    }
    
    void Update()
    {
        if (floor == 1)
        {
            Steps.clip = madera;
        }
        else if (floor == 2)
        {
            Steps.clip = tierra;
        }
        else
        {
            Steps.clip = concreto;
        }
    }
}
