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
public AudioSource efectoArboles;
public AudioSource efectoGrillos;
public AudioSource efectoRespiracion;
public AudioSource efectoLechuza;
public AudioSource efectoGallo;


public void activateMusic(AudioSource music)
{
music.Play();
music.loop = true;
}
}
