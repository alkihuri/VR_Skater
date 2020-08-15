using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
  
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void ApplicationExit()
    {
        Application.Quit();
    }
    // Start is called before the first frame update
    void Start()
    {
        
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
