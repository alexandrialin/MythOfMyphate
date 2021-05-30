using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationFishP2Script : MonoBehaviour
{
    float speed = 4f;
    float rotSpeed = 80;
    float gravity = 0;
    //Animator anim;
    // Start is called before the first frame update
    Vector3 moveDir = Vector3.zero;
    CharacterController controller;
    void Start()
    {
        controller = GetComponent<CharacterController>();
        //anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
            if (Input.GetKey(KeyCode.UpArrow))
            {
                //anim.SetInteger("condition", 1);
                moveDir = new Vector3(0, 0, 1);
                moveDir *= speed;
                transform.eulerAngles = new Vector3(0, 180, 0);

            }
            if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                //anim.SetInteger("condition", 0);
                moveDir = new Vector3(0, 0, 0);

            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                //anim.SetInteger("condition", 1);
                moveDir = new Vector3(0, 0, -1);
                moveDir *= speed;
                transform.eulerAngles = new Vector3(0, 0, 0);

            }
            if (Input.GetKeyUp(KeyCode.DownArrow))
            {
                //anim.SetInteger("condition", 0);
                moveDir = new Vector3(0, 0, 0);

            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
               // anim.SetInteger("condition", 1);
                moveDir = new Vector3(1, 0, 0);
                moveDir *= speed;
                transform.eulerAngles = new Vector3(0, 270, 0);

            }
            if (Input.GetKeyUp(KeyCode.RightArrow))
            {
                //anim.SetInteger("condition", 0);
                moveDir = new Vector3(0, 0, 0);

            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                //anim.SetInteger("condition", 1);
                moveDir = new Vector3(-1, 0, 0);
                moveDir *= speed;
                transform.eulerAngles = new Vector3(0, 90, 0);

            }
            if (Input.GetKeyUp(KeyCode.LeftArrow))
            {
                //anim.SetInteger("condition", 0);

                moveDir = new Vector3(0, 0, 0);
            }
            if (Input.GetKey(KeyCode.Space))
            {
            moveDir = new Vector3(0, 1, 0);
            moveDir *= speed;


        }
            if (Input.GetKey(KeyCode.RightControl) || Input.GetKey(KeyCode.LeftControl))
        {
            moveDir = new Vector3(0, -1, 0);
            moveDir *= speed;


        }
        if (Input.GetKeyUp(KeyCode.RightControl) || Input.GetKey(KeyCode.LeftControl))
        {
            moveDir = new Vector3(0, 0, 0);


        }
        if (Input.GetKeyUp(KeyCode.Space))
            {
            moveDir = new Vector3(0, 0, 0);
        }
            if (Input.GetKey(KeyCode.X))
            {
               // anim.SetInteger("fight", 1);



            }
            if (Input.GetKeyUp(KeyCode.X))
            {
                //anim.SetInteger("fight", 0);
            }
        
        //moveDir.y -= gravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime);

    }
    void OnTriggerEnter(Collider other)
    {

        other.isTrigger = false;




    }
}
