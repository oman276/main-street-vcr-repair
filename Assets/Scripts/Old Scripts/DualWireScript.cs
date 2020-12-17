using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualWireScript : MonoBehaviour
{
    public float IDnum;

    public DualWireBase dualWireBase;

    public MoveSystem moveSystem;
    public WireScript wireScript;
    public Animator animator;

    public bool isPowered;

    // Start is called before the first frame update
    void Start()
    {
        dualWireBase = GetComponentInParent<DualWireBase>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(dualWireBase.isPoweredTotal == true)
        {
            animator.SetBool("baseIsPowered", true);
        }
        else
        {
            animator.SetBool("baseIsPowered", false);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        print("Touching Object");

        moveSystem = collision.gameObject.GetComponent<MoveSystem>();
        //wireScript = collision.gameObject.GetComponent<WireScript>();

        if (moveSystem != null)
        { 
            if (moveSystem.isAlwaysPowered == true || moveSystem.isPowered == true)
            {
                print("POWERED!!!!");
                isPowered = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (isPowered == true)
        {
            isPowered = false;
        }
    }

}
