using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Valve : MonoBehaviour
{
    public Animator gate;
    public Animator valve;
    bool inReach = false;
    bool turned = false;
    public AudioSource valveClip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inReach && !turned)
        {
            if (Input.GetKey(KeyCode.E))
            {
                valve.SetBool("Turned", true);
                gate.SetBool("Open", true);
                valveClip.Play();
                turned = true;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
            inReach = true;
    }

    private void OnTriggerExit(Collider other)
    {
        inReach = false;
    }
}
