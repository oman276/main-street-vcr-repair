using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugAudioController : MonoBehaviour
{
    public bool firstUpdate = false;


    // Update is called once per frame
    void Update()
    {
        if(firstUpdate == false)
        {
            FindObjectOfType<AudioManager>().Play("bugChatter");
            firstUpdate = true;
        }
    }
}
