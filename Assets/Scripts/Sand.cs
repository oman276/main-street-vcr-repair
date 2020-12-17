using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sand : MonoBehaviour
{
    public float currentX;
    public float targetX;
    public float currentY;
    public float targetY;

    public float gridSize = 1.2836f;
    public float moveSpeed = 5f;

    public LayerMask movementBlock;
    public bool sandMove = false;


    // Start is called before the first frame update
    void Start()
    {
        currentX = transform.position.x;
        targetX = transform.position.x;

        currentY = transform.position.y;
        targetY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(targetX, targetY, transform.position.z), moveSpeed * Time.deltaTime);
        sandMove = false;
    }

    public void SandUpCheck()
    {
        if (!Physics2D.OverlapCircle(new Vector3(transform.position.x, transform.position.y + gridSize, transform.position.z), 0.2f, movementBlock))
        {
            sandMove = true;
            FindObjectOfType<AudioManager>().Play("sandMove");        
            targetY = targetY + gridSize;
        }
        else
        {
            sandMove = false;
            FindObjectOfType<AudioManager>().Play("pieceStopped");
        }
    }

    public void SandDownCheck()
    {
        if (!Physics2D.OverlapCircle(new Vector3(transform.position.x, transform.position.y - gridSize, transform.position.z), 0.2f, movementBlock))
        {
            sandMove = true;
            FindObjectOfType<AudioManager>().Play("sandMove");
            targetY = targetY - gridSize;
        }
        else
        {
            sandMove = false;
            FindObjectOfType<AudioManager>().Play("pieceStopped");
        }
    }

    public void SandLeftCheck()
    {
        if (!Physics2D.OverlapCircle(new Vector3(transform.position.x - gridSize, transform.position.y, transform.position.z), 0.2f, movementBlock))
        {
            sandMove = true;
            FindObjectOfType<AudioManager>().Play("sandMove");
            targetX = targetX - gridSize;
        }
        else
        {
            sandMove = false;
            FindObjectOfType<AudioManager>().Play("pieceStopped");
        }
    }

    public void SandRightCheck()
    {
        if (!Physics2D.OverlapCircle(new Vector3(transform.position.x + gridSize, transform.position.y, transform.position.z), 0.2f, movementBlock))
        {
            sandMove = true;
            FindObjectOfType<AudioManager>().Play("sandMove");
            targetX = targetX + gridSize;
        }
        else
        {
            sandMove = false;
            FindObjectOfType<AudioManager>().Play("pieceStopped");
        }
    }
}
