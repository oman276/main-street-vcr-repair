using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireScript : MonoBehaviour
{
    private bool moving = false;
    public bool isPowered = false;

    private float startPosX;
    private float startPosY;

    public MoveSystem moveSystem;
    public WireScript wireScript;


    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
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

    private void OnTriggerStay2D(Collider2D collision)
    {
        print("Touching Object");

        moveSystem = collision.gameObject.GetComponent<MoveSystem>();
        wireScript = collision.gameObject.GetComponent<WireScript>();

        if (moveSystem != null)
        {
            if (moveSystem.isPowered == true)
            {
                print("POWERED!!!!");
                animator.SetBool("isActive", true);
                isPowered = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(isPowered == true)
        {
            animator.SetBool("isActive", false);
            isPowered = false;
        }
    }
}
