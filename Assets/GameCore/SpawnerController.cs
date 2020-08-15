using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public GameObject energy;
    List <EnergyController> countOf;

    private void Start()
    {
        GameStates.RefreshData();
    }
    // Update is called once per frame
    void Update()
    {

        

        countOf = GameObject.FindObjectsOfType<EnergyController>().ToList();
        if(countOf.Count<10)
        {
            Transform random = transform.GetChild(Random.Range(0, transform.childCount));
            Instantiate(energy, random.position, random.rotation, random);
        }

    }
}
