using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveGem : MonoBehaviour
{
    public GameObject gem;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MC")||other.gameObject.CompareTag("human"))
        {
            gem.SetActive(true);
            if (gameObject.CompareTag("gem1"))
            {
                CrystalGems.Gem1();
            }
            if (gameObject.CompareTag("gem2"))
            {
                CrystalGems.Gem2();
            }
            if (gameObject.CompareTag("gem3"))
            {
                CrystalGems.Gem3();
            }
            if (gameObject.CompareTag("gem4"))
            {
                CrystalGems.Gem4();
            }
            if (gameObject.CompareTag("gem8"))
            {
                CrystalGems.Gem8();
            }

        }
    }
        }
