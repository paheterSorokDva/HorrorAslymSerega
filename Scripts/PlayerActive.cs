using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActive : MonoBehaviour
{
    [SerializeField] float distance;
    
    [SerializeField] private float sphereCastRadius;
    
    private void FixedUpdate()
    {
       //Debug.DrawLine(transform.position, transform.position + transform.forward * 10);
        if (Input.GetButtonDown("Fire1")) {
             //Ray ray;
             RaycastHit hit;

            if (Physics.Raycast(transform.position, transform.forward, out hit, distance))
            {

                if (hit.transform.tag == "AnimtedDoor") /// Обращение к тегу
                {
                    hit.transform.GetComponent<DoorSetting>()._lockDoorKey = false;

                    hit.transform.GetComponent<Animator>().enabled = true;

                    hit.transform.GetComponent<DoorSetting>().Check();

                    hit.transform.GetComponent<AudioSource>().playOnAwake = true;

                    hit.transform.GetComponent<AudioSource>().enabled = false;

                    Animator anim = hit.transform.GetComponent<Animator>();
                    anim.SetBool("open", !anim.GetBool("open"));
                }
                if (hit.transform.tag == "DoorLock")
                {
                    hit.transform.GetComponent<DoorSetting>()._lockDoorKey = true;

                    hit.transform.GetComponent<Animator>().enabled = false;

                    hit.transform.GetComponent<DoorSetting>().Check();

                    hit.transform.GetComponent<AudioSource>().playOnAwake = false;

                    hit.transform.GetComponent<AudioSource>().enabled = true;

                    
                    var audio = hit.transform.GetComponent<AudioSource>();
                    audio.Play();
                    
                }
             } 

            /*if (Physics.SphereCast(ray, sphereCastRadius, out hit, distance))
            {

                if (hit.transform.tag == "AnimtedDoor") /// Обращение к тегу
                {
                    Animator anim = hit.transform.GetComponent<Animator>();
                    anim.SetBool("open", !anim.GetBool("open"));

                }
            }*/

            
        }

    }

    
    
}
