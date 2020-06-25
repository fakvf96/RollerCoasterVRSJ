using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpulseCall : MonoBehaviour
{
    public bool brake = false;
    public AudioSource sound;
    public bool devoDesativar;
    // Start is called before the first frame update
   
    private void OnTriggerEnter(Collider other)
    {
       

        if (other.CompareTag("Player"))
        {
            if (sound)
                sound.Play();

            if (brake)
            {
                other.SendMessageUpwards("Brake");
            }
            other.SendMessageUpwards("ImpulseOn");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.SendMessageUpwards("ImpulseOff");
        }
    }
}
