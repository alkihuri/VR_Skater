using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class CameraController : MonoBehaviour
{
    public float cameraField;
    // Start is called before the first frame update
    void Start()
    {
        cameraField = 60;
        if (!GetComponentInParent<PhotonView>().IsMine)
            GetComponent<Camera>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Mathf.Abs(GameObject.FindObjectOfType<InputManager>().vertical) >0)
            GetComponent<Camera>().fieldOfView = cameraField + GetComponentInParent<Rigidbody>().velocity.magnitude*2.0f;
        else
        {
            if (GetComponent<Camera>().fieldOfView>60)
            {
                GetComponent<Camera>().fieldOfView -= 0.3f;
            }
        }
    }
}
