using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueRedo : MonoBehaviour
{
    public Text textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject[] photos;

    public GameObject continueButton;

    private void Start()
    {
        
        StartCoroutine(Type());
    }


    // Only display the continue button if the given sentence is complete
    private void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName != "GotoMenu")
        {
            if (textDisplay.text == sentences[index])
            {
                continueButton.SetActive(true);

            }
        }
    }

    // Give the text the "typed" appearance
    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    // Set a reference to the next sentence / determine if the previous sentence has completed
    public void NextSentence()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        continueButton.SetActive(false);
        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
        }
        if (sceneName != "Game1" && sceneName != "Game2" && sceneName !="GotoMenu")
            {
            //Instantiate(photos[index - 1], new Vector3(0, 0, 0), Quaternion.identity);
        }



    }
}
