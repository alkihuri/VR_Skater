using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public  float vertical;
    public  float horizontal;

    public Joystick moveJ;
    private void Start()
    {
        moveJ = GameObject.FindObjectOfType<FixedJoystick>();
    }
    // Update is called once per frame
    void Update()
    {



        vertical = moveJ.Vertical;
        horizontal = moveJ.Horizontal;
#if UNITY_EDITOR

        vertical += Input.GetAxis("Vertical");
        horizontal += Input.GetAxis("Horizontal");
#endif

    }
}
