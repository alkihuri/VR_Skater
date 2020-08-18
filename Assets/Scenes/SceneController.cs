using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void Disconent()
    {
        Photon.Pun.PhotonNetwork.Disconnect();
    }

     public void ConnectToGame()
    {
        GameObject.FindObjectOfType<SkateManager>().ConnectToGame();
    }
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name); 
    }

    private void Awake()
    {
        
    }

    public void ApplicationExit()
    {
        Application.Quit();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void DelayLeftRoom(string name)
    {
        StartCoroutine(DalayLeft(name));   
    }
   

    IEnumerator DalayLeft(string name, int sec = 3)
    {
        yield return new WaitForSeconds(sec);
        Photon.Pun.PhotonNetwork.LeaveRoom();
        Photon.Pun.PhotonNetwork.LoadLevel(name);


    }
    public void DealyLoadScene(string name)
    {
        StartCoroutine(Dealay(name));
    }
    IEnumerator Dealay(string name, int sec =3 )
    {
        yield return new WaitForSeconds(sec);
        LoadScene(name);
        

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
