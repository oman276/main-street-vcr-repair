using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VHSTape : MonoBehaviour
{
    public Transform restPoint;
    public Transform winPoint;

    public bool isWin = false;
    public float moveSpeed = 7f;

    // Start is called before the first frame update
    void Start()
    {
        restPoint.parent = null;
        winPoint.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        if(isWin == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, winPoint.position, moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, restPoint.position, moveSpeed * Time.deltaTime);
        }
    }
}
