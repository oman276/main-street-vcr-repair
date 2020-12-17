using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalSlidingBlock : MonoBehaviour
{

    public LeftSlideTrigger leftTrigger;
    public RightSlideTrigger rightTrigger;

    public float currentX;
    public float targetX;
    public float moveSpeed = 5f;
    public float gridSize = 1.2836f;

    // Start is called before the first frame update
    void Start()
    {
        currentX = transform.position.x;
        targetX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, new Vector3(targetX, transform.position.y, transform.position.z), moveSpeed * Time.deltaTime);
        currentX = transform.position.x;
    }

    public void LeftTrigger()
    {
        FindObjectOfType<AudioManager>().Play("slidingBlock");
        targetX = targetX - gridSize;
        FindObjectOfType<DialogueManager>().horizontalBlockTrigger();
    }

    public void RightTrigger()
    {
        FindObjectOfType<AudioManager>().Play("slidingBlock");
        targetX = targetX + gridSize;
        FindObjectOfType<DialogueManager>().horizontalBlockTrigger();
    }
}
