using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        anim.ResetTrigger("PlayAnimation");
        if (Input.GetAxisRaw("Jump") > 0)
        {
            Debug.Log("Jump!");
            anim.SetTrigger("PlayAnimation");
            
        }
        

    }
}
