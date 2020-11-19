using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip opendoor, closedoor;
    static AudioSource audioSource;
    void Start()
    {
        opendoor = Resources.Load<AudioClip>("portaabrindo");
        closedoor = Resources.Load<AudioClip>("portafechando"); 

        audioSource = GetComponent<AudioSource>();  
    }

    public static void PlaySound(string clip)
    {
        switch(clip)
        {
            case "portaabrindo":
                audioSource.PlayOneShot(opendoor);
                break;
            case "portafechando":
                audioSource.PlayOneShot(closedoor);
                break;
        }
    }
}
