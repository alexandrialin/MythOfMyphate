using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class AnimalTeleport : MonoBehaviour
{
    public Button yourButton;
    
    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }

    // Update is called once per frame
    void TaskOnClick()
    {
        if (gameObject.CompareTag("rabbit"))
        {
            SceneManager.LoadScene("Grassfields");
        }
        if (gameObject.CompareTag("bird"))
        {
            SceneManager.LoadScene("BirdTrees");
        }
        if (gameObject.CompareTag("fish"))
        {
            SceneManager.LoadScene("Underwater");
        }


    }
}