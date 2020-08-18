using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class StartSceneManager : MonoBehaviourPunCallbacks
{
    public bool isConected;
    /*
    public override void OnLeftRoom()
    {
        PhotonNetwork.LeaveLobby();
    }
    */
    private void Start()
    {

        PhotonNetwork.AutomaticallySyncScene = false;


        if (PhotonNetwork.IsConnected)
        {

             PhotonNetwork.Disconnect(); 

        }
     
    }
    private void Update()
    {
        isConected = PhotonNetwork.IsConnected;
        if (!PhotonNetwork.IsConnected)
            GetComponent<SkateManager>().ConnectToGame();
    }
}
