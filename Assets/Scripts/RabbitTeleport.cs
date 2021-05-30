using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class RabbitTeleport : MonoBehaviour
{
    public Button yourButton;
    //public GameObject box;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }

    // Update is called once per frame
    void TaskOnClick()
    {
        if (gameObject.CompareTag("BunnyChase"))
        {
            SceneManager.LoadScene("Grassfields");
        }
        if (gameObject.CompareTag("Grassfields"))
        {
            SceneManager.LoadScene("BunnyChase");
        }
        if (gameObject.CompareTag("Cutscene1"))
        {
            SceneManager.LoadScene("Village 1");
        }
        if (gameObject.CompareTag("Underwater"))
        {
            SceneManager.LoadScene("Shark");
        }
        if (gameObject.CompareTag("Shark"))
        {
            SceneManager.LoadScene("Underwater");
        }

    }
}
