using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalGems : MonoBehaviour
{
    public GameObject gem1;
    public GameObject gem2;
    public GameObject gem3;
    public GameObject gem4;
    public GameObject gem5;
    public GameObject gem6;
    public GameObject gem7;
    public GameObject gem8;
    public GameObject gem9;
    public static int g1;
    public static int g2;
    public static int g3;
    public static int g4;
    public static int g5;
    public static int g6;
    public static int g7;
    public static int g8;
    public static int g9;
    // Start is called before the first frame update
    public static void Gem1()
    {
        g1 = 1;
    }
    public static void Gem2()
    {
        g2 = 1;
    }
    public static void Gem3()
    {
        g3 = 1;
    }
    public static void Gem4()
    {
        g4 = 1;
    }
    public static void Gem5()
    {
        g5 = 1;
    }
    public static void Gem6()
    {
        g6 = 1;
    }
    public static void Gem7()
    {
        g7 = 1;
    }
    public static void Gem8()
    {
        g8 = 1;
    }
    public static void Gem9()
    {
        g9 = 1;
    }


    void Update()
    {
        if (g1 == 1)
        {
            gem1.SetActive(true);
        }
        if (g2 == 1)
        {
            gem2.SetActive(true);
        }

        if (g3 == 1)
        {
            gem3.SetActive(true);
        }
        if (g4 == 1)
        {
            gem4.SetActive(true);
        }
        if (g5 == 1)
        {
            gem5.SetActive(true);
        }
        if (g6 == 1)
        {
            gem6.SetActive(true);
        }
        if (g7 == 1)
        {
            gem7.SetActive(true);
        }
        if (g8 == 1)
        {
            gem8.SetActive(true);
        }
        if (g9 == 1)
        {
            gem9.SetActive(true);
        }
    }
}
