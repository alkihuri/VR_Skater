using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    private void OnTriggerExit(Collider other)
    {
        GameObject.FindObjectOfType<SceneController>().LoadScene("Finish");
    }
}
