using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Photon.Pun;
public class SpawnerController : MonoBehaviourPunCallbacks
{
    public GameObject energy;
    List <EnergyController> countOf;


    public override void OnJoinedRoom()
    {
      
    }
    private void Start()
    {
        GameStates.RefreshData();
        if(PhotonNetwork.IsConnected)
            PhotonNetwork.Instantiate("Player", transform.GetChild(0).position, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {

        

        countOf = GameObject.FindObjectsOfType<EnergyController>().ToList();
        if(countOf.Count<10)
        {
            Transform random = transform.GetChild(Random.Range(0, transform.childCount));
            PhotonNetwork.Instantiate("Energy", random.position, random.rotation);
        }

    }
}
