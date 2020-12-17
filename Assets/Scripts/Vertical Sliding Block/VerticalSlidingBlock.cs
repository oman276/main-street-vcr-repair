using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalSlidingBlock : MonoBehaviour
{
    public UpTrigger upTrigger;
    public DownTrigger downTrigger;

    public float currentY;
    public float targetY;
    public float moveSpeed = 5f;
    public float gridSize = 1.2836f;

    // Start is called before the first frame update
    void Start()
    {
        currentY = transform.position.y;
        targetY = transform.position.y;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, targetY, transform.position.z), moveSpeed * Time.deltaTime);
        
    }

    public void UpTrigger()
    {
        FindObjectOfType<AudioManager>().Play("slidingBlock");
        targetY = targetY + gridSize;
        FindObjectOfType<DialogueManager>().verticalBlockTrigger();
    }

    public void DownTrigger()
    {
        FindObjectOfType<AudioManager>().Play("slidingBlock");
        targetY = targetY - gridSize;
        FindObjectOfType<DialogueManager>().verticalBlockTrigger();
    }
}
