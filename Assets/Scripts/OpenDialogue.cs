using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenDialogue : MonoBehaviour
{
    public GameObject dialogue;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MC")||other.gameObject.CompareTag("human"))
        {

            dialogue.SetActive(true);
        }




    }
}
