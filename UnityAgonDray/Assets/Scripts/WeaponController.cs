using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public Animator anim;
    public GameObject sword;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (sword.activeInHierarchy)
            {
                anim.SetTrigger("Swinging");
            }
        }
    }

    private void OnMouseDown()
    {
        if (sword.activeInHierarchy)
        {
            anim.SetTrigger("Swinging");
        }
    }
}
