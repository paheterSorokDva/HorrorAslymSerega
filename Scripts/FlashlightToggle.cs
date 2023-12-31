﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class FlashlightToggle : MonoBehaviour
{
    public GameObject Flashlight;
    public GameObject lightGO; //light gameObject to work with
    private bool isOn = false; //is flashlight on or off?

    // Use this for initialization
    void Start()
    {
        //set default off
        lightGO.SetActive(isOn);
    }

    // Update is called once per frame
    void Update()
    {
        //toggle flashlight on key down
        if (Input.GetKeyDown(KeyCode.F))
        {
            //toggle light
            isOn = !isOn;
            //turn light on
            if (isOn)
            {
                lightGO.SetActive(true);
                Flashlight.GetComponent<AudioSource>().Play();
            }
            //turn light off
            else
            {
                lightGO.SetActive(false);
                Flashlight.GetComponent<AudioSource>().Play();
            }
        }
    }
}
