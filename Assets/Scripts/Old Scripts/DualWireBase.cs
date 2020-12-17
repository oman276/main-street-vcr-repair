using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualWireBase : MonoBehaviour
{
    public bool isPowered1 = false;
    public bool isPowered2 = false;

    public bool isPoweredTotal = false;

    private bool moving = false;

    private float startPosX;
    private float startPosY;

    public DualWireScript wireNode1;
    public DualWireScript wireNode2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moving)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, this.gameObject.transform.localPosition.z);
        }

        if(wireNode1.isPowered == true)
        {
            isPowered1 = true;
        }
        else
        {
            isPowered1 = false;
        }

        if(wireNode2.isPowered == true)
        {
            isPowered2 = true;
        }
        else
        {
            isPowered2 = false;
        }

        if(isPowered1 == true || isPowered2 == true)
        {
            isPoweredTotal = true;
        }
        else
        {
            isPoweredTotal = false;
        }

    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;

            moving = true;
        }
    }

    private void OnMouseUp()
    {
        moving = false;
    }

}
