using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public   class SkateManager  :  MonoBehaviourPunCallbacks
{
    public   string nickName = "alkihuri";
    public   string roomName = "RoomOne";
    public void ConnectToGame()
    {
        
        if(!PhotonNetwork.IsConnected)
        {
            PhotonNetwork.AutomaticallySyncScene = false;
            PhotonNetwork.GameVersion = "1";
            PhotonNetwork.ConnectUsingSettings();
        }
         
     
    }

    public void JoinRoom()
    { 
     if(PhotonNetwork.CountOfRooms<1)
            PhotonNetwork.CreateRoom(roomName);
        else
            PhotonNetwork.JoinRoom(roomName);
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("жани к1анцуна вацок");
        PhotonNetwork.LoadLevel("Start");
    }
   
    public override void OnCreatedRoom()
    {
        PhotonNetwork.JoinRoom(roomName); 
        Debug.Log("комната  гьабуна ха  ");
    }
    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
        Debug.Log("Гьанже х1азе бегльиля ха");
    }
}
