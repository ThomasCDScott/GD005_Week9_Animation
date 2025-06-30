using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public Animator anim;

    private void OnTriggerEnter(Collider other)
    {
        //anim.SetTrigger("OpenDoor");
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                anim.SetTrigger("OpenDoor");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        anim.SetTrigger("ClosedDoor");
    }
}
