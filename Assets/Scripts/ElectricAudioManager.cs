using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricAudioManager : MonoBehaviour
{
    public bool firstUpdate = false;
    public bool twoBeams;
    public bool isOn = true;
    public bool isOff = false;

    public GameObject beam1;
    public GameObject beam2;

    // Start is called before the first frame update
    void Start()
    {
        //FindObjectOfType<AudioManager>().Play("electricity");
        print("Start is Triggering");
    }

    // Update is called once per frame
    void Update()
    {
        if(firstUpdate == false)
        {
            FindObjectOfType<AudioManager>().Play("electricity");
            firstUpdate = true;
        }

        if(twoBeams == false) //One Beam
        {
            if(beam1.active == false)
            {
                if(isOn == true)
                {
                    FindObjectOfType<AudioManager>().StopPlaying("electricity");
                    isOn = false;
                    isOff = true;
                }

            }
            else
            {
                if(isOff == true)
                {
                    FindObjectOfType<AudioManager>().Play("electricity");
                    isOn = true;
                    isOff = false;
                }

            }
        }


        else // Two Beams
        {
            if(beam1.active == false && beam2.active == false)
            {
                if(isOn == true)
                {
                    FindObjectOfType<AudioManager>().StopPlaying("electricity");
                    isOn = false;
                    isOff = true;
                }
            }
            else
            {
                if(isOff == true)
                {
                    FindObjectOfType<AudioManager>().Play("electricity");
                    isOn = true;
                    isOff = false;
                }
            }
        }
    }
}
