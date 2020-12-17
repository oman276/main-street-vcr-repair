using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpTrigger : MonoBehaviour
{
    public VerticalSlidingBlock slidingBlock;
    public Sand sand;
    public float gridSize = 1.2836f;
    public LayerMask movementBlock;
    public LayerMask sandMask;

    // Start is called before the first frame update
    void Start()
    {
        slidingBlock = GetComponentInParent<VerticalSlidingBlock>();
    }


    public void OnMouseDown()
    {
        if (!Physics2D.OverlapCircle(new Vector3(transform.position.x, transform.position.y + gridSize, transform.position.z), 0.2f, movementBlock))
        {
            if (Physics2D.OverlapCircle(new Vector3(transform.position.x, transform.position.y + gridSize, transform.position.z), 0.2f, sandMask))
            {
                sand = Physics2D.OverlapCircle(new Vector3(transform.position.x, transform.position.y + gridSize, transform.position.z), 0.2f, sandMask).GetComponent<Sand>();
                sand.SandUpCheck();

                if (sand.sandMove == true)
                {
                    slidingBlock.UpTrigger();
                }

            }
            else
            {
                slidingBlock.UpTrigger();
            }
        }
        else
        {
            FindObjectOfType<AudioManager>().Play("pieceStopped");
        }
    }
}
