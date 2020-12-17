using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperScript : MonoBehaviour
{
    public Transform movepoint;
    public float moveSpeed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        movepoint.parent = null; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movepoint.position, moveSpeed * Time.deltaTime);
    }
}
