using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerController : MonoBehaviour
{

    public MonoBehaviour[] localScripts;
    public GameObject root;
    // Start is called before the first frame update
    void Start()
    {
        localScripts = root.GetComponentsInChildren<MonoBehaviour>();
        if(!GetComponent<PhotonView>().IsMine)
            foreach (MonoBehaviour mn in localScripts)
            {
                Destroy(mn);
            }
    }

     
}
