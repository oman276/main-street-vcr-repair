using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningBarrierBlock : MonoBehaviour
{
    public Transform rotationPoint;
    public LayerMask movementBlock;

    public float currentRotation = 0;
    public float targetRotation = 0;

    // Update is called once per frame
    void Update()
    {
        if(currentRotation != targetRotation)
        {
            currentRotation = currentRotation - 5;
            transform.eulerAngles = Vector3.forward * currentRotation;
        }


    }

    public void OnMouseDown()
    {
        if(!Physics2D.OverlapCircle(rotationPoint.position, 0.1f, movementBlock))
        {
            FindObjectOfType<AudioManager>().Play("rotatingBlock");
            targetRotation = targetRotation - 90;
            FindObjectOfType<DialogueManager>().rotatingBlockTrigger();
        }
        else
        {
            FindObjectOfType<AudioManager>().Play("pieceStopped");
        }
        
    }

}
