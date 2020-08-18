using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        PhotonNetwork.AutomaticallySyncScene = false;
        PhotonNetwork.LeaveRoom();
        GameObject.FindObjectOfType<SceneController>().LoadScene("Prewarm");
    }
}
