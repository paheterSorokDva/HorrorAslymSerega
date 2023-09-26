using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AnimFoot : MonoBehaviour
{
    public AudioClip[] FootaudioClips;
    public GameObject playAudio;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //if (Physics.Raycast(transform.position, transform.up, out hit, 1))
        // {
        // FootStep();
        // }

        /*       if (Input.GetKey(KeyCode.W) || 
                   Input.GetKey(KeyCode.S) ||
                   Input.GetKey(KeyCode.A) ||
                   Input.GetKey(KeyCode.D))
               {
                   FootStep();
               }
        */

        if (Input.GetAxis("Horizontal") != 0)
        {
            FootStep();
        }
        if (Input.GetAxis("Vertical") != 0)
        {
            FootStep();
        }

    }

    public void FootStep()
    {
        
        int randInt = Random.Range(0, FootaudioClips.Length);
        
        if (playAudio.GetComponent<AudioSource>().isPlaying)
        {

        }
        else
        {
            playAudio.GetComponent<AudioSource>().PlayOneShot(FootaudioClips[randInt]);
        }

    }
}
