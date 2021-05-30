using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuizPoints : MonoBehaviour
{
    public Button yourButton;
    public static int points;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }

    // Update is called once per frame
    void TaskOnClick()
    {
        points++;
        if (points >= 3)
        {
            CrystalGems.Gem7();
        }

    }
}
