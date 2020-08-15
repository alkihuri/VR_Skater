using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        float val = Mathf.Abs(GameObject.FindObjectOfType<InputManager>().vertical);
       
        if(GameStates.energyValue != 0)
        {
            if (val > 0.49)
                GetComponent<AudioSource>().volume += 0.07f;

            if (val < 0.50)
                GetComponent<AudioSource>().volume -= 0.07f;

            if (GetComponent<AudioSource>().volume < 0.07f)
                GetComponent<AudioSource>().volume = 0.07f;

        }
        else 
            GetComponent<AudioSource>().volume = 0;

    }
}
