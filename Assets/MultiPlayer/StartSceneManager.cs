using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class StartSceneManager : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SkateManager>().ConnectToGame();
    }

    private void Update()
    {
        if(PhotonNetwork.IsConnected)
        {
            Debug.Log("Connected");
        }

    }


}
