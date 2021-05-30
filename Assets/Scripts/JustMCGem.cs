using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustMCGem : MonoBehaviour
{
    public GameObject dialogue;
    

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MC"))
        {

            dialogue.gameObject.SetActive(true);
            print("hi");

        }
        //GetComponent<Collider>().isTrigger = false;
    }
}
