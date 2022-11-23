using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public GameObject grabGO;
    public GameObject activateGO;
    bool inReach = false;
    public AudioSource grabSource;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(inReach && Input.GetKeyDown(KeyCode.E))
        {
            activateGO.SetActive(true);
            grabSource.Play();
            Destroy(grabGO);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            inReach = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        inReach = false;
    }
}
