using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform movePoint;
    public float gridSize = 1.2836f;

    public LayerMask movementBlock;
    public PartManager partManager;

    public bool movementEnabled = false;
    public bool onCorrectForm = false;

    public GameObject correctForm;
    public LayerMask correctLayer;

    public Sand sand;
    public LayerMask sandMask;
    public bool canSandMove;

    public Animator animator;
    public float zapDelay = 0.1f;
    public float respawnDelay = 1f;

    public bool victoryNoiseTrigger = false;

    // Start is called before the first frame update
    void Start()
    {
        movePoint.parent = null;
        partManager = FindObjectOfType<PartManager>();
        animator = GetComponent<Animator>();

        if(animator != null)
        {
            print("Got Animator");
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

        if (movementEnabled == true)
        {
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))//Left
            {

                if (!Physics2D.OverlapCircle(new Vector3(movePoint.position.x - gridSize, movePoint.position.y, movePoint.position.z), 0.2f, movementBlock))
                {
                    if (Physics2D.OverlapCircle(new Vector3(movePoint.position.x - gridSize, movePoint.position.y, movePoint.position.z), 0.2f, sandMask))
                    {
                        sand = Physics2D.OverlapCircle(new Vector3(movePoint.position.x - gridSize, movePoint.position.y, movePoint.position.z), 0.2f, sandMask).GetComponent<Sand>();

                        if (sand != null)
                        {
                            sand.SandLeftCheck();
                            canSandMove = sand.sandMove;

                            if (canSandMove == true)
                            {
                                FindObjectOfType<AudioManager>().Play("objectSlide");
                                movePoint.position = new Vector3(movePoint.position.x - gridSize, movePoint.position.y, movePoint.position.z);
                            }
                        }
                    }
                    else
                    {
                        FindObjectOfType<AudioManager>().Play("objectSlide");
                        movePoint.position = new Vector3(movePoint.position.x - gridSize, movePoint.position.y, movePoint.position.z);
                        FindObjectOfType<DialogueManager>().objectMoveTrigger();
                    }

                }
                else
                {
                    FindObjectOfType<AudioManager>().Play("pieceStopped");
                }

                if (onCorrectForm == true)
                {
                    partManager.numOfParts++;
                    onCorrectForm = false;
                }

            }

            else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) //Down
            {
                if (!Physics2D.OverlapCircle(new Vector3(movePoint.position.x, movePoint.position.y - gridSize, movePoint.position.z), 0.2f, movementBlock))
                {
                    if (Physics2D.OverlapCircle(new Vector3(movePoint.position.x, movePoint.position.y - gridSize, movePoint.position.z), 0.2f, sandMask))
                    {
                        sand = Physics2D.OverlapCircle(new Vector3(movePoint.position.x, movePoint.position.y - gridSize, movePoint.position.z), 0.2f, sandMask).GetComponent<Sand>();

                        if (sand != null)
                        {
                            sand.SandDownCheck();
                            canSandMove = sand.sandMove;

                            if (canSandMove == true)
                            {
                                FindObjectOfType<AudioManager>().Play("objectSlide");
                                movePoint.position = new Vector3(movePoint.position.x, movePoint.position.y - gridSize, movePoint.position.z);
                            }
                        }


                    }
                    else
                    {
                        FindObjectOfType<AudioManager>().Play("objectSlide");
                        movePoint.position = new Vector3(movePoint.position.x, movePoint.position.y - gridSize, movePoint.position.z);
                        FindObjectOfType<DialogueManager>().objectMoveTrigger();
                    }
                }
                else
                {
                    FindObjectOfType<AudioManager>().Play("pieceStopped");
                }

                if (onCorrectForm == true)
                {
                    partManager.numOfParts++;
                    onCorrectForm = false;
                }
            }

            else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) //Right
            {
                if (!Physics2D.OverlapCircle(new Vector3(movePoint.position.x + gridSize, movePoint.position.y, movePoint.position.z), 0.2f, movementBlock))
                {
                    if (Physics2D.OverlapCircle(new Vector3(movePoint.position.x + gridSize, movePoint.position.y, movePoint.position.z), 0.2f, sandMask))
                    {
                        sand = Physics2D.OverlapCircle(new Vector3(movePoint.position.x + gridSize, movePoint.position.y, movePoint.position.z), 0.2f, sandMask).GetComponent<Sand>();

                        if (sand != null)
                        {
                            sand.SandRightCheck();
                            canSandMove = sand.sandMove;

                            if (canSandMove == true)
                            {
                                FindObjectOfType<AudioManager>().Play("objectSlide");
                                movePoint.position = new Vector3(movePoint.position.x + gridSize, movePoint.position.y, movePoint.position.z);
                            }
                        }

                    }
                    else
                    {
                        FindObjectOfType<AudioManager>().Play("objectSlide");
                        movePoint.position = new Vector3(movePoint.position.x + gridSize, movePoint.position.y, movePoint.position.z);
                        FindObjectOfType<DialogueManager>().objectMoveTrigger();
                    }
                }
                else
                {
                    FindObjectOfType<AudioManager>().Play("pieceStopped");
                }

                if (onCorrectForm == true)
                {
                    partManager.numOfParts++;
                    onCorrectForm = false;
                }
            }

            else if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) //Up
            {
                if (!Physics2D.OverlapCircle(new Vector3(movePoint.position.x, movePoint.position.y + gridSize, movePoint.position.z), 0.2f, movementBlock))
                {
                    if (Physics2D.OverlapCircle(new Vector3(movePoint.position.x, movePoint.position.y + gridSize, movePoint.position.z), 0.2f, sandMask))
                    {
                        sand = Physics2D.OverlapCircle(new Vector3(movePoint.position.x, movePoint.position.y + gridSize, movePoint.position.z), 0.2f, sandMask).GetComponent<Sand>();

                        if (sand != null)
                        {
                            sand.SandUpCheck();
                            canSandMove = sand.sandMove;

                            if (canSandMove == true)
                            {
                                FindObjectOfType<AudioManager>().Play("objectSlide");
                                movePoint.position = new Vector3(movePoint.position.x, movePoint.position.y + gridSize, movePoint.position.z);
                            }
                        }

                    }
                    else
                    {
                        FindObjectOfType<AudioManager>().Play("objectSlide");
                        movePoint.position = new Vector3(movePoint.position.x, movePoint.position.y + gridSize, movePoint.position.z);
                        FindObjectOfType<DialogueManager>().objectMoveTrigger();
                    }
                }
                else
                {
                    FindObjectOfType<AudioManager>().Play("pieceStopped");
                }

                if (onCorrectForm == true)
                {
                    partManager.numOfParts++;
                    onCorrectForm = false;
                }

            }

        }                      

                    if (Physics2D.OverlapCircle(transform.position, 0.2f, correctLayer))
                    {
                        onCorrectForm = true;
                    }
                    else
                    {
                        onCorrectForm = false;
                    }

        if(onCorrectForm == true && victoryNoiseTrigger == false)
        {
            FindObjectOfType<AudioManager>().Play("correctSlot");
            victoryNoiseTrigger = true;
        }
        else if (onCorrectForm == false)
        {
            //print("false triggered");
            victoryNoiseTrigger = false;
        }


    }

 
    public void OnMouseDown()
    {
        //print("Object Clicked");

        partManager.MovementDisable();
        movementEnabled = true;
        FindObjectOfType<AudioManager>().Play("selected");
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Electricity")
        {
            FindObjectOfType<AudioManager>().Play("explosion");
            animator.SetBool("isZapped", true);
            StartCoroutine(RespawnCoroutine());
            FindObjectOfType<DialogueManager>().explosionTrigger();
        }
    }

    public IEnumerator RespawnCoroutine()
    {
        yield return new WaitForSeconds(zapDelay);
        this.gameObject.SetActive(false);

    }
}