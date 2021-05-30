using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwitch : MonoBehaviour
{
    public GameObject target;
    public GameObject target2;
    public GameObject human1;
    public GameObject human2;
    public GameObject bird1;
    public GameObject bird2;
    public GameObject fish1;
    public GameObject fish2;
    public GameObject rabbit1;
    public GameObject rabbit2;
    public GameObject rabbitTrack1;
    public GameObject rabbitTrack2;
    public Vector3 coordinates1;
    public Vector3 coordinates2;
    Vector3 offset;

    void Start()
    {


        target = human1;
        target2 = human2;
        offset = transform.position - target.transform.position;
    }
    void Update()
    {
        coordinates1 = target.transform.position;
        coordinates2 = target2.transform.position;
        
        if (Input.GetKey(KeyCode.Alpha1))
        {
            human1.transform.position = coordinates1;
            human2.transform.position = coordinates2;
            target = human1;
            target2 = human2;
            human1.SetActive(true);
            human2.SetActive(true);
            rabbit1.SetActive(false);
            rabbit2.SetActive(false);
            fish1.SetActive(false);
            fish2.SetActive(false);
            bird1.SetActive(false);
            bird2.SetActive(false);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            rabbit1.transform.position = coordinates1;
            rabbit2.transform.position = coordinates2;
            target = rabbitTrack1;
            target2 = rabbitTrack2;
            human1.SetActive(false);
            human2.SetActive(false);
            rabbit1.SetActive(true);
            rabbit2.SetActive(true);
            fish1.SetActive(false);
            fish2.SetActive(false);
            bird1.SetActive(false);
            bird2.SetActive(false);
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            fish1.transform.position = coordinates1;
            fish2.transform.position = coordinates2;
            target = fish1;
            target2 = fish2;

            human1.SetActive(false);
            human2.SetActive(false);
            rabbit1.SetActive(false);
            rabbit2.SetActive(false);
            fish1.SetActive(true);
            fish2.SetActive(true);
            bird1.SetActive(false);
            bird2.SetActive(false);
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            bird1.transform.position = coordinates1;
            bird2.transform.position = coordinates2;
            target = bird1;
            target2 = bird2;
            human1.SetActive(false);
            human2.SetActive(false);
            rabbit1.SetActive(false);
            rabbit2.SetActive(false);
            fish1.SetActive(false);
            fish2.SetActive(false);
            bird1.SetActive(true);
            bird2.SetActive(true);
        }
    }
    void LateUpdate()
    {

        Vector3 desiredPosition = target.transform.position + offset;
        transform.position = desiredPosition;

    }
}
