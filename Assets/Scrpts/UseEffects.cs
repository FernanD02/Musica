using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseEffects : MonoBehaviour
{
    public ManagerSound managerSound;


    public void OnTriggerEnter(Collider other)
    {
        playEffect(other.tag == "Arboles", managerSound.efectoArboles,true);
        playEffect(other.tag == "Arboles", managerSound.efectoArboles, true);
        playEffect(other.tag == "Arboles", managerSound.efectoArboles, true);
        playEffect(other.tag == "Arboles", managerSound.efectoArboles, true);
        playEffect(other.tag == "Arboles", managerSound.efectoArboles, true);
        playEffect(other.tag == "Arboles", managerSound.efectoArboles, true);
        playEffect(other.tag == "Arboles", managerSound.efectoArboles, true);
        playEffect(other.tag == "Arboles", managerSound.efectoArboles, true);
        playEffect(other.tag == "Arboles", managerSound.efectoArboles, true);
        playEffect(other.tag == "Arboles", managerSound.efectoArboles, true);
    }



    public void playEffect(bool tag, AudioSource effect, bool isLoop)
    {
        if (tag)
        {
            effect.Play();
            effect.loop = isLoop;
        }
    }



}
