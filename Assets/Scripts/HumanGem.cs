using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanGem : MonoBehaviour
{
    public GameObject dialogue;

    void OnTriggerEnter(Collider other)
    {
        
        
        if (other.gameObject.CompareTag("human"))
        {

            dialogue.gameObject.SetActive(true);
            CrystalGems.Gem3();
        }
        //GetComponent<Collider>().isTrigger = false;
    }
}
