using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCam : MonoBehaviour
{
    public GameObject target;
    public GameObject human1;
    public GameObject human2;
    public GameObject bird1;
    public GameObject bird2;
    public GameObject fish1;
    public GameObject fish2;
    public GameObject rabbit1;
    public GameObject rabbit2;
    public GameObject rabbitTrack;
    Vector3 offset;

    void Start()
    {

        target = human1;
        offset = transform.position - target.transform.position;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            target = human1;
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
            target = rabbitTrack;
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
            target = fish1;
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
            target = bird1;
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
