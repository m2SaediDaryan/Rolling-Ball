using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpsMaker : MonoBehaviour
{
    public Transform[] LocationCreation;
    public GameObject[] PickUps;
    public float InstantiateTime;
    private float TimeFromLastInstantiate;

    // Start is called before the first frame update
    void Start()
    {
        TimeFromLastInstantiate=InstantiateTime;
    }

    // Update is called once per frame
    void Update()
    {
        TimeFromLastInstantiate+=Time.deltaTime;
        if(TimeFromLastInstantiate>=InstantiateTime)
        {
            InstantiatePickUps();
            TimeFromLastInstantiate=0f;
        }
    }
    public void InstantiatePickUps()
    {
        int RandomPos = Random.Range(0, LocationCreation.Length);
        int PickUpsNumber = Random.Range(0, PickUps.Length);

        if (!PickUps[PickUpsNumber].activeSelf == true)
        {
            
            PickUps[PickUpsNumber].transform.position = LocationCreation[RandomPos].position;
            
            PickUps[PickUpsNumber].SetActive(true);
        }
        /*else
        {
            PickUps[PickUpsNumber].transform.position = LocationCreation[RandomPos].position;
            
            PickUps[PickUpsNumber].SetActive(true);
        }*/
    }
    public void OnPickupCaught()
    {
        InstantiatePickUps();
    }
}
