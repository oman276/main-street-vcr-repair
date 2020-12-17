using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
    public float currentScene = 0;
    public static DialogueManager instance;

    public string currentDialogue;

    public bool rotatingBlockBool = false;
    public bool horizontalBlockBool = false;
    public bool verticalBlockBool = false;
    public bool explosionBool = false;
    public bool redButtonBool = false;
    public bool objectMoveBool = false;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
            return;
        }

        DontDestroyOnLoad(gameObject);
        currentDialogue = ("test");

    }

    // Update is called once per frame
    void Update()
    {
        if (currentScene != SceneManager.GetActiveScene().buildIndex)
        {
            currentScene = SceneManager.GetActiveScene().buildIndex;

            if(currentScene == 1) //Intro
            {
                print("intro");
                FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
                currentDialogue = ("introduction");
                FindObjectOfType<AudioManager>().Play(currentDialogue);
                
            }
            else if (currentScene == 2){ //Intro1
                FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
                currentDialogue = ("level1intro");
                FindObjectOfType<AudioManager>().Play(currentDialogue);
            }
            else if(currentScene == 3) //Stage1
            {
                FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
                currentDialogue = ("level1start");
                FindObjectOfType<AudioManager>().Play(currentDialogue);

            }
            else if (currentScene == 4) //Intro2
            {
                FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
                currentDialogue = ("level2intro");
                FindObjectOfType<AudioManager>().Play(currentDialogue);
            }
            else if (currentScene == 5) //Stage2
            {
                FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
                currentDialogue = ("level2start");
                FindObjectOfType<AudioManager>().Play(currentDialogue);
            }
            else if (currentScene == 6) //Intro3
            {
                FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
                currentDialogue = ("level3intro");
                FindObjectOfType<AudioManager>().Play(currentDialogue);
            }
            else if (currentScene == 7) //Stage3
            {
                FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
                currentDialogue = ("level3start");
                FindObjectOfType<AudioManager>().Play(currentDialogue);
            }
            else if (currentScene == 8) //Intro4
            {
                FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
                currentDialogue = ("level4intro");
                FindObjectOfType<AudioManager>().Play(currentDialogue);
            }
            else if (currentScene == 9) //Stage4
            {
                FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
                currentDialogue = ("level4start");
                FindObjectOfType<AudioManager>().Play(currentDialogue);
            }
            else if (currentScene == 10) //Intro5
            {
                FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
                currentDialogue = ("level5intro");
                FindObjectOfType<AudioManager>().Play(currentDialogue);
            }
            else if (currentScene == 11) //Stage5
            {
                FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
                currentDialogue = ("level5start");
                FindObjectOfType<AudioManager>().Play(currentDialogue);
            }
            else if (currentScene == 12) //Intro6
            {
                FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
                currentDialogue = ("level6intro");
                FindObjectOfType<AudioManager>().Play(currentDialogue);
            }
            else if (currentScene == 13) //Stage6
            {
                FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
                currentDialogue = ("level6start");
                FindObjectOfType<AudioManager>().Play(currentDialogue);
            }
            else if (currentScene == 14) //Intro7
            {
                FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
                currentDialogue = ("level7intro");
                FindObjectOfType<AudioManager>().Play(currentDialogue);

            }
            else if (currentScene == 15) //Stage7
            {
                FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
                currentDialogue = ("level7start");
                FindObjectOfType<AudioManager>().Play(currentDialogue);
            }
            else if (currentScene == 16) //Intro8
            {
                FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
                currentDialogue = ("level8intro");
                FindObjectOfType<AudioManager>().Play(currentDialogue);
            }
            else if (currentScene == 17) //Stage8
            {
                FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
                currentDialogue = ("level8start");
                FindObjectOfType<AudioManager>().Play(currentDialogue);
            }
            else if (currentScene == 18) //Intro9
            {
                FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
                currentDialogue = ("level9intro");
                FindObjectOfType<AudioManager>().Play(currentDialogue);
            }
            else if (currentScene == 19) //Stage9
            {
                FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
                currentDialogue = ("level9start");
                FindObjectOfType<AudioManager>().Play(currentDialogue);
            }
            else if (currentScene == 20) //Intro10
            {
                FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
                currentDialogue = ("level10intro");
                FindObjectOfType<AudioManager>().Play(currentDialogue);
            }
            else if (currentScene == 21) //Stage10
            {
                FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
                currentDialogue = ("level10start");
                FindObjectOfType<AudioManager>().Play(currentDialogue);
            }
            else if (currentScene == 22) //Intro11
            {
                FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
                currentDialogue = ("level11intro");
                FindObjectOfType<AudioManager>().Play(currentDialogue);
            }
            else if (currentScene == 23) //Stage11
            {
                FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
                currentDialogue = ("level11start");
                FindObjectOfType<AudioManager>().Play(currentDialogue);
            }
            else if (currentScene == 24) //Intro12
            {
                FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
                currentDialogue = ("level12intro");
                FindObjectOfType<AudioManager>().Play(currentDialogue);
            }
            else if (currentScene == 25) //Stage12
            {
                FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
                currentDialogue = ("level12start");
                FindObjectOfType<AudioManager>().Play(currentDialogue);
            }
            else if (currentScene == 26) //Intro13
            {
                FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
                currentDialogue = ("level13intro");
                FindObjectOfType<AudioManager>().Play(currentDialogue);
            }
            else if (currentScene == 27) //Stage13
            {
                FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
                currentDialogue = ("level13start");
                FindObjectOfType<AudioManager>().Play(currentDialogue);
            }
            else if (currentScene == 28) //Intro14
            {
                FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
                currentDialogue = ("level14intro");
                FindObjectOfType<AudioManager>().Play(currentDialogue);

            }
            else if (currentScene == 29) //Stage14
            {
                FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
                currentDialogue = ("level14start");
                FindObjectOfType<AudioManager>().Play(currentDialogue);
            }
            else if (currentScene == 30) //Intro15
            {
                FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
                currentDialogue = ("level15intro");
                FindObjectOfType<AudioManager>().Play(currentDialogue);
            }
            else if (currentScene == 31) //Stage15
            {
                FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
                currentDialogue = ("level15start");
                FindObjectOfType<AudioManager>().Play(currentDialogue);
            }
            else if(currentScene == 32) //Outro
            {
                FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
                currentDialogue = ("outro");
                FindObjectOfType<AudioManager>().Play(currentDialogue);
            }

        }  
        
    }

    public void StopDialogue()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;

        if(currentScene == 19 || currentScene == 21 || currentScene == 23 || currentScene == 29 || currentScene == 31)
        {
            FindObjectOfType<AudioManager>().StopPlaying("electricity");
        }

        if(currentScene == 25 || currentScene == 27 || currentScene == 29 || currentScene == 31)
        {
            FindObjectOfType<AudioManager>().StopPlaying("bugChatter");
        }
        
        FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);

    }

    public void WinCondition()
    {
        if (currentScene == 3) //Stage1
        {
            FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
            currentDialogue = ("level1exit");
            FindObjectOfType<AudioManager>().Play(currentDialogue);
        }
        else if (currentScene == 5) //Stage2
        {
            FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
            currentDialogue = ("level2exit");
            FindObjectOfType<AudioManager>().Play(currentDialogue);
        }
        else if (currentScene == 7) //Stage3
        {
            FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
            currentDialogue = ("level3exit");
            FindObjectOfType<AudioManager>().Play(currentDialogue);
        }
        else if (currentScene == 9) //Stage4
        {
            FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
            currentDialogue = ("level4exit");
            FindObjectOfType<AudioManager>().Play(currentDialogue);
        }
        else if (currentScene == 11) //Stage5
        {
            FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
            currentDialogue = ("level5exit");
            FindObjectOfType<AudioManager>().Play(currentDialogue);
        }
        else if (currentScene == 13) //Stage6
        {
            FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
            currentDialogue = ("level6exit");
            FindObjectOfType<AudioManager>().Play(currentDialogue);
        }
        else if (currentScene == 15) //Stage7
        {
            FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
            currentDialogue = ("level7exit");
            FindObjectOfType<AudioManager>().Play(currentDialogue);
        }
        else if (currentScene == 17) //Stage8
        {
            FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
            currentDialogue = ("level8exit");
            FindObjectOfType<AudioManager>().Play(currentDialogue);
        }
        else if (currentScene == 19) //Stage9
        {
            FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
            currentDialogue = ("level9exit");
            FindObjectOfType<AudioManager>().Play(currentDialogue);
        }
        else if (currentScene == 21) //Stage10
        {
            FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
            currentDialogue = ("level10exit");
            FindObjectOfType<AudioManager>().Play(currentDialogue);
        }
        else if (currentScene == 23) //Stage11
        {
            FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
            currentDialogue = ("level11exit");
            FindObjectOfType<AudioManager>().Play(currentDialogue);
        }
        else if (currentScene == 25) //Stage12
        {
            FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
            currentDialogue = ("level12exit");
            FindObjectOfType<AudioManager>().Play(currentDialogue);
        }
        else if (currentScene == 27) //Stage13
        {
            FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
            currentDialogue = ("level13exit");
            FindObjectOfType<AudioManager>().Play(currentDialogue);
        }
        else if (currentScene == 29) //Stage14
        {
            FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
            currentDialogue = ("level14exit");
            FindObjectOfType<AudioManager>().Play(currentDialogue);
        }
        else if (currentScene == 31) //Stage15
        {
            FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
            currentDialogue = ("level15exit");
            FindObjectOfType<AudioManager>().Play(currentDialogue);
        }

    }

    public void rotatingBlockTrigger()
    {
        if(rotatingBlockBool == false)
        {
            FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
            currentDialogue = ("onRotatingBlock");
            FindObjectOfType<AudioManager>().Play(currentDialogue);
            rotatingBlockBool = true;
        }
    }

    public void horizontalBlockTrigger()
    {
        if (horizontalBlockBool == false)
        {
            FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
            currentDialogue = ("onHorizontal");
            FindObjectOfType<AudioManager>().Play(currentDialogue);
            horizontalBlockBool = true;
        }
    }

    public void verticalBlockTrigger()
    {
        if (verticalBlockBool == false)
        {
            FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
            currentDialogue = ("onVerticalBlock");
            FindObjectOfType<AudioManager>().Play(currentDialogue);
            verticalBlockBool = true;
        }
    }

    public void explosionTrigger()
    {
        if (explosionBool == false)
        {
            FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
            currentDialogue = ("onElectricity");
            FindObjectOfType<AudioManager>().Play(currentDialogue);
            explosionBool = true;
        }
    }

    public void redButtonTrigger()
    {
        if (redButtonBool == false)
        {
            FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
            currentDialogue = ("onButton");
            FindObjectOfType<AudioManager>().Play(currentDialogue);
            redButtonBool = true;
        }
    }

    public void objectMoveTrigger()
    {
        if (objectMoveBool == false)
        {
            FindObjectOfType<AudioManager>().StopPlaying(currentDialogue);
            currentDialogue = ("pieceMoved");
            FindObjectOfType<AudioManager>().Play(currentDialogue);
            objectMoveBool = true;
        }
    }
}
