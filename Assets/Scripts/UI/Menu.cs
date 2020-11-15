using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Animator animator;

    public void OnStart()
    {
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        animator.SetBool("Start", true);
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(1);
    } 

    public void OnCredits()
    {

    }

    public void OnExit()
    {
        Application.Quit();
        Debug.Log("Has exited");
    }
}
