using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PartManager : MonoBehaviour
{
    public float numOfParts = 5f;

    //public GameObject powerSupply;
    //public GameObject audioChip;

    public ObjectMovement powerSupplyObjectMovement;
    public ObjectMovement audioChipObjectMovement;
    public ObjectMovement videoChipObjectMovement;
    public ObjectMovement videoDrumObjectMovement;
    public ObjectMovement loadingMotorObjectMovement;

    public Button continueButton;

    public bool isOn = false;

    public VHSTape tape;
    public DialogueManager dialogueManager;
    

    // Start is called before the first frame update
    void Start()
    {
        tape = FindObjectOfType<VHSTape>();
        //dialogueManager = FindObjectOfType<DialogueManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(powerSupplyObjectMovement.onCorrectForm && audioChipObjectMovement.onCorrectForm
            && videoChipObjectMovement.onCorrectForm && videoDrumObjectMovement.onCorrectForm && 
            loadingMotorObjectMovement.onCorrectForm)
        {
            if(isOn == false)
            {
                FindObjectOfType<AudioManager>().Play("victoryChime");
                continueButton.gameObject.SetActive(true);
                isOn = true;
                tape.isWin = true;
                FindObjectOfType<DialogueManager>().WinCondition();
            }
            
        }
        else
        {
            continueButton.gameObject.SetActive(false);
            isOn = false;
            tape.isWin = false;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }

    public void MovementDisable()
    {
        powerSupplyObjectMovement.movementEnabled = false;
        audioChipObjectMovement.movementEnabled = false;
        videoChipObjectMovement.movementEnabled = false;
        videoDrumObjectMovement.movementEnabled = false;
        loadingMotorObjectMovement.movementEnabled = false;

    }

    public void LoadNextLevel()
    {
        FindObjectOfType<DialogueManager>().StopDialogue();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
