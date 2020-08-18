using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class BoardEngine : MonoBehaviour
{
    Rigidbody engine;
    [Range(1, 700)] public float enginePower;
    public Animator animator;
    public Transform moveDirection;
    float startMass;
    public PhotonView pv;
    // Start is called before the first frame update
    void Start()
    {
        enginePower = 500;
        engine = GetComponentInParent<Rigidbody>();
        startMass = engine.mass;
        GameObject.FindObjectOfType<ProgressBarCircle>().BarValue = GameStates.energyValue;
    }
    float vertical, horizontal, distanceToGround;
    RaycastHit groud;
    // Update is called once per frame
    void Update()
    {
        vertical = GetComponent<InputManager>().vertical;
        horizontal = GetComponent<InputManager>().horizontal;
        animator.SetFloat("Turn", horizontal);

        if (pv.IsMine)
        {

            if (GameStates.energyValue < 0.1)
            {
                Debug.Log("Looser");
                Photon.Pun.PhotonNetwork.LeaveRoom(); 
                Photon.Pun.PhotonNetwork.Disconnect();
                Photon.Pun.PhotonNetwork.LoadLevel("Finish");
                //GameObject.FindObjectOfType<SceneController>().DealyLoadScene("Finish");
            }

            float upBust = 0;
            transform.parent.transform.parent.transform.Rotate(0, horizontal * 2, 0);

            if (Physics.Raycast(transform.position, -transform.up, out groud))
            {
                if (groud.distance < 1)
                {
                    upBust = 1.5f;
                }
            }

            GameStates.energyValue -= Mathf.Abs(GetComponent<InputManager>().vertical / 4);

            GameObject.FindObjectOfType<ProgressBarCircle>().BarValue = GameStates.energyValue;

            if (GameStates.energyValue > 0)
                engine.AddForce(moveDirection.forward * enginePower * vertical * 2 + transform.up * enginePower * upBust, ForceMode.Impulse);

            engine.mass = startMass + Mathf.Pow(transform.position.y * 2, 6);
            if (vertical > 0)
            {
                GameStates.rushTime += vertical;
            }

        }




    }
}
