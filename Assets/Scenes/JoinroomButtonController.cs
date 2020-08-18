using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

public class JoinroomButtonController : MonoBehaviour
{
    public float sec;
    private void Start()
    {
        sec = 0;
    }
    private void Update()
    {
        GetComponent<Button>().interactable = PhotonNetwork.IsConnectedAndReady;
        
        if(!PhotonNetwork.IsConnectedAndReady)
        {
            sec += Time.deltaTime;
        }
        else if(PhotonNetwork.IsConnectedAndReady)
        {
            sec = 0;
        }

        if(sec > 5)
        {
            PhotonNetwork.LoadLevel("Prewarm");
        }
    }
}
