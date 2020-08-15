using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    public Animator animator;
    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Velocity", GameObject.FindObjectOfType<InputManager>().vertical);
    }
}
