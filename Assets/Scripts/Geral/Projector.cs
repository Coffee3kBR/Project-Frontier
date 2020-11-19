using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projector : MonoBehaviour
{
    public int id;
    public ParticleSystemRenderer particle;
    private void Start() 
    {
        EventManager.current.onEventTrigger += ActivateParticle;
    }
    void ActivateParticle(int id)
    {
        if(id == this.id)
        {
            if(particle.enabled)
                particle.enabled = false;
            else
                particle.enabled = true;
        }    
    }
    private void OnDestroy() 
    {
        EventManager.current.onEventTrigger -= ActivateParticle;                
    }
}
