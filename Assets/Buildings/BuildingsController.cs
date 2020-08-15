using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingsController : MonoBehaviour
{
     
    // Update is called once per frame
    void Update()
    { 
        for(int i =0;i<transform.childCount;i++)
        {
            float rand = Mathf.Sin(Time.time) / 30;
            transform.GetChild(i).transform.position = transform.GetChild(i).gameObject.GetComponent<BuildingData>().startTransform.position + new Vector3(rand/100, rand/5, rand/100);
            transform.GetChild(i).transform.Rotate(0, rand, 0);
        }
    }
}
