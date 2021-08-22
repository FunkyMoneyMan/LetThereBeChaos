using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public static float MoveSpeed = 5f;
    //public Animator animator;
    //public Camera cam;
    //public Interactable focus;
    public float JumpHight = 2;

    // Start is called before the first frame update
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        //cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        {
            float straffe = 0;
            if (Input.GetButton("Horizontal")) straffe = Input.GetAxis("Horizontal") > 0 ? MoveSpeed : -MoveSpeed;
            float translation = 0;
            if (Input.GetButton("Vertical")) translation = Input.GetAxis("Vertical") > 0 ? MoveSpeed : -MoveSpeed;

            transform.Translate(straffe * Time.deltaTime, translation * Time.deltaTime, 0);
        }
        if (Input.GetKeyDown("space"))
        {
            transform.Translate(0, JumpHight, 0);
        }
    }
}
