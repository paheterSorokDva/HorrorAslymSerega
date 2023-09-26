using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSetting : MonoBehaviour
{
    public bool _lockDoorKey;
    //public GameObject lockSound;
    public AudioClip[] _clips;
    // Start is called before the first frame update
    void Start()
    {
        Check();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Check()
    {
        if (_lockDoorKey == false)
        {
            GetComponent<AudioSource>().clip = _clips[0];
        }
        else
        {
            GetComponent<AudioSource>().clip = _clips[1];
        }
    }
}
