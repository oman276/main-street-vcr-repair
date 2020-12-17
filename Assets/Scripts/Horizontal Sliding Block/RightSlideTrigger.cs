using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightSlideTrigger : MonoBehaviour
{
    public HorizontalSlidingBlock slidingBlock;
    public float gridSize = 1.2836f;
    public LayerMask movementBlock;
    public LayerMask sandMask;
    public Sand sand;

    // Start is called before the first frame update
    void Start()
    {
        slidingBlock = GetComponentInParent<HorizontalSlidingBlock>();
    }


    public void OnMouseDown()
    {
        //print("Right Clicked");
        if (!Physics2D.OverlapCircle(new Vector3(transform.position.x + gridSize, transform.position.y, transform.position.z), 0.2f, movementBlock))
        {
            if (Physics2D.OverlapCircle(new Vector3(transform.position.x + gridSize, transform.position.y, transform.position.z), 0.3f, sandMask))
            {
                sand = Physics2D.OverlapCircle(new Vector3(transform.position.x + gridSize, transform.position.y, transform.position.z), 0.3f, sandMask).GetComponent<Sand>();
                sand.SandRightCheck();
                if(sand == null)
                {
                    print("Sand not got");
                }
                if (sand.sandMove == true)
                {
                    slidingBlock.RightTrigger();
                }

            }
            else
            {
                slidingBlock.RightTrigger();
            }
        }
        else
        {
            FindObjectOfType<AudioManager>().Play("pieceStopped");
        }
    }
}
