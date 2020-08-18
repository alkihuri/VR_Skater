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
        PhotonNetwork.AutomaticallySyncScene = false;

        if (!PhotonNetwork.IsConnected)
        { 
            PhotonNetwork.GameVersion = "1";
            PhotonNetwork.ConnectUsingSettings();
        }
        else
        {
            Debug.Log("Ошибочка");
        }
         
     
    }

    public override void OnLeftRoom()
    {
        PhotonNetwork.LoadLevel("Prewarm");
    }


    public override void OnJoinedLobby()
    {
        Debug.Log("лоббиялде щвана");
        JoinRoom();
    }

    public void JoinLobby()
    {
        PhotonNetwork.JoinLobby();
    }
    public void JoinRoom()
    {  
        if(PhotonNetwork.CountOfRooms<1)    /// будет использоваться только одна команата поэтому проверяем если комната  уже создана ззначит просто заходим в нее как львы еже 
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
