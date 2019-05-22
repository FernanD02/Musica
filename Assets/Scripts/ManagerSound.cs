using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSound : MonoBehaviour
{
    public AudioSource nivel1;
    public AudioSource nivel2;
    public AudioSource nivel3;
    public AudioSource efectoViento;
    public AudioSource efectoFuego;
    public AudioSource efectoSierra;
    public AudioSource efectoCampanas;
    public AudioSource efectoPasosTierra;
    public AudioSource efectoarboles;
    public AudioSource efectogrillos;
    public AudioSource efectorespiracion;
    public AudioSource efectolechuza;
    public AudioSource efectogallo;

    public void activateEffect(AudioSource effect,bool isLoop)
    {
        effect.Play();
        effect.loop = isLoop;
    }

    public void activateMusict(AudioSource music)
    {
        music.Play();
        music.loop = true;
    }
}
