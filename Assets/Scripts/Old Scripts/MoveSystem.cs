using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSystem : MonoBehaviour
{

    public GameObject correctForm;
    private bool moving = false;

    private float startPosX;
    private float startPosY;

    private Vector3 resetPosition;

    public LevelManager levelManager;


    public bool onTarget = false;
    public bool wasOnTarget = false;
    public bool justRemoved = false;

    public bool isAlwaysPowered = false;
    public bool isPowered = false;

    public WireScript wireScript;

    public DualWireScript dualWireScript;
    public DualWireScript dualWireScript2;

    public bool wireIsAttached = false;
    

    // Start is called before the first frame update
    void Start()
    {
        resetPosition = this.transform.localPosition;

        levelManager = FindObjectOfType<LevelManager>();

        if (Mathf.Abs(this.transform.localPosition.x - correctForm.transform.localPosition.x) <= 0.5f &&
        (this.transform.localPosition.y - correctForm.transform.localPosition.y) <= 0.5f)
        {
            this.transform.localPosition = new Vector3(correctForm.transform.localPosition.x, correctForm.transform.localPosition.y, correctForm.transform.localPosition.z);
            levelManager.elementsOfVCR--;

            onTarget = true;
            wasOnTarget = true;
        }
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

        if(onTarget == false && wasOnTarget == true)
        {
            levelManager.elementsOfVCR++;
            wasOnTarget = false;
        }

        if(isAlwaysPowered == true)
        {
            isPowered = true;
        }
        else
        {
            if (wireIsAttached == true)
            {
                PoweredCheck();
            }
            else
            {
                isPowered = false;
            }
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
            onTarget = false;
        }
    }

    private void OnMouseUp()
    {
        moving = false;

        if(Mathf.Abs(this.transform.localPosition.x - correctForm.transform.localPosition.x) <= 0.5f &&
            Mathf.Abs(this.transform.localPosition.y - correctForm.transform.localPosition.y) <= 0.5f)
        {
            this.transform.localPosition = new Vector3(correctForm.transform.localPosition.x, correctForm.transform.localPosition.y, correctForm.transform.localPosition.z);
            levelManager.elementsOfVCR--;

            onTarget = true;
            wasOnTarget = true;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        dualWireScript = collision.gameObject.GetComponent<DualWireScript>();

        if(dualWireScript != null)
        {
            wireIsAttached = true;
        }
            
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if(wireIsAttached == true)
        {
            wireIsAttached = false;
        }
    }


    public void PoweredCheck()
    {
        if(dualWireScript.isPowered == true)
        {
            isPowered = true;
        }
        else
        {
            isPowered = false;
        }
    }

}
