using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceParty : MonoBehaviour
{
    private Animator anim;
    

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            anim.SetTrigger("Dance_01");
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetTrigger("Dance_02");
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            anim.SetTrigger("Dance_03");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetTrigger("Thriller_1");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetTrigger("Thriller_2");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetTrigger("Thriller_3");
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            anim.SetTrigger("Thriller_4");
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            anim.SetTrigger("Ending_Pose");
        }
    }
}
