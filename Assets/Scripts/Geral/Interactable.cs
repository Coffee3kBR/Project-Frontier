using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public int id;
    public GameObject exclamation;
    bool coroutine = false;
    public float delay;
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player")
        {
            exclamation.SetActive(true);
        }
    }
    private void OnTriggerStay(Collider other) 
    {
        if(other.gameObject.tag == "Player")
        {
            if(Input.GetButtonDown("Fire1") && !coroutine)
            {
                coroutine = true;
                StartCoroutine(Wait(delay));
            }
        }
        
    }
    private void OnTriggerExit(Collider other) {
       if(other.gameObject.tag == "Player")
        {
            exclamation.SetActive(false);
        } 
    }

    IEnumerator Wait(float delay)
    {
        EventManager.current.EventTrigger(id);
        yield return new WaitForSeconds(delay);
        coroutine = false;
    } 
}