using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedButton : MonoBehaviour
{
    public GameObject electricBeam;
    public LayerMask movementBlock;


    public bool isPressed = false;


    // Update is called once per frame
    void Update()
    {
        if (Physics2D.OverlapCircle(transform.position, 0.2f, movementBlock))
        {
            electricBeam.gameObject.SetActive(false);
            if (isPressed == false)
            {
                FindObjectOfType<AudioManager>().Play("redButtonPress");
                isPressed = true;
                FindObjectOfType<DialogueManager>().redButtonTrigger();
            }
        }
        else
        {
            electricBeam.gameObject.SetActive(true);
            isPressed = false;
        }
    }
}
