using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MiniGemCount : MonoBehaviour
{
    public static int count;
    public GameObject gem5;
    public Text text;
    void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
        count++;
    }

    void Update()
    {
        if (count == 1)
        {
            text.text = "1/5 pieces of Crystal";
        }
        if (count == 2)
        {
            text.text = "2/5 pieces of Crystal";
        }
        if (count == 3)
        {
            text.text = "3/5 pieces of Crystal";
        }
        if (count == 4)
        {
            text.text = "4/5 pieces of Crystal";
        }
        if (count == 5)
        {
            text.text = " ";
            CrystalGems.Gem5();
            
;        }
    }
}
