using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public int id;
    public Animator door;

    private void Start() 
    {
        EventManager.current.onEventTrigger += ActivateDoor;
    }
    private void ActivateDoor(int id)
    {
        if(id == this.id)
        {
            if(door.GetBool("character_nearby"))
            {
                door.SetBool("character_nearby", false);
                SoundManager.PlaySound("portafechando");
            }
            else
            {
                door.SetBool("character_nearby", true);
                SoundManager.PlaySound("portaabrindo");
            }        
        }    
    }
    private void OnDestroy() 
    {
        EventManager.current.onEventTrigger -= ActivateDoor;                
    }

}
