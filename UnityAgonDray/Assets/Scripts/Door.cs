using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator door;
    public GameObject doorGO;
    bool inReach = false;
    public AudioSource doorClip;
    // Start is called before the first frame update
    void Start()
    {
        doorClip = doorGO.GetComponent<AudioSource>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (inReach)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                door.SetBool("Open", true);
                doorClip.Play();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered trigger");
        if(other.gameObject.tag == "Player")
        {
            inReach = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        inReach = false;
    }
}
