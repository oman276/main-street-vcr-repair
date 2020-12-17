using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug : MonoBehaviour
{
    public Transform lookPoint;
    public bool facingRight = true;
    public LayerMask movementBlock;
    public float moveSpeed = 6f;


    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, lookPoint.position, moveSpeed * Time.deltaTime);

        if(Physics2D.OverlapCircle(lookPoint.position, 0.1f, movementBlock))
        {
            if(facingRight == true)
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
                facingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                facingRight = true;
            }
        }
        
    }


}
