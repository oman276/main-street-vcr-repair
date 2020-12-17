using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownTrigger : MonoBehaviour
{
    public VerticalSlidingBlock slidingBlock;
    public float gridSize = 1.2836f;

    public Sand sand;

    public LayerMask movementBlock;
    public LayerMask sandMask;

    // Start is called before the first frame update
    void Start()
    {
        slidingBlock = GetComponentInParent<VerticalSlidingBlock>();
    }


    public void OnMouseDown()
    {
        if (!Physics2D.OverlapCircle(new Vector3(transform.position.x, transform.position.y - gridSize, transform.position.z), 0.2f, movementBlock))
        {
            if (Physics2D.OverlapCircle(new Vector3(transform.position.x, transform.position.y - gridSize, transform.position.z), 0.2f, sandMask))
            {
                sand = Physics2D.OverlapCircle(new Vector3(transform.position.x, transform.position.y - gridSize, transform.position.z), 0.2f, sandMask).GetComponent<Sand>();
                sand.SandDownCheck();

                if(sand.sandMove == true)
                {
                    slidingBlock.DownTrigger();
                }
                               
            }
            else
            {
                slidingBlock.DownTrigger();
            }
        }
        else
        {
            FindObjectOfType<AudioManager>().Play("pieceStopped");
        }
    }
}
