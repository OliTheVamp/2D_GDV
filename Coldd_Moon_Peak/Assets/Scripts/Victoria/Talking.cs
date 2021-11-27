using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Talking : MonoBehaviour
{
    public bool dialogueActive { get; private set; }
    public bool redTalks = false;
    public GameObject redChar;
    public GameObject blueChar;
    public Image redCharI;
    public Image blueCharI;
    public Color m_InactiveColor;
    public Color m_ActiveColor;
    public Canvas dialoguePanel;
    public int chatValue = 12;
    public GameObject player;
    public GameObject ghost;
    public bool dialogueSwappable;
    public int dialogueCount = 0;

    [Header("Visual Cue")]
    public GameObject visualCue;
    private bool playerInRange;

    [Header("Final Dialogue")]
    public Hide hideScriptObject;
    public bool finalDialoguePlay;

    public bool printedOne;
    public bool printedTwo;
    public bool printedTwoV2;//
    public bool printedThree;
    public bool printedThreeV2;
    public bool printedFour;//
    public bool printedFourV2;
    public bool printedFive;
    public bool printedSix;//

    private void Awake()
    {
        dialogueActive = false;
        playerInRange = false;
        visualCue.SetActive(false);
        finalDialoguePlay = false;
        dialogueSwappable = false;
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = false;
        }
    }

    private void Start()
    {
        redCharI = redChar.GetComponent<Image>();
        blueCharI = blueChar.GetComponent<Image>();
        m_InactiveColor = Color.grey;
        m_ActiveColor = Color.white;
        printedOne = false;
        printedTwo = false;
        printedTwoV2 = false;//
        printedThree = false;
        printedThreeV2 = false;
        printedFour = false; ;//
        printedFourV2 = false;
        printedFive = false;
        printedSix = false;//
    }

    private void Update()
    {
        if (playerInRange)
        {
            visualCue.SetActive(true);
        }
        else
        {
            visualCue.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (playerInRange)
            {
                dialogueCount++;
                if (hideScriptObject.finalDialogueActive)
                {
                    finalDialoguePlay = true;
                    dialogueActive = true;
                }
                else
                {
                    chatValue = 12;
                    dialogueActive = true;
                    dialogueSwappable = true;
                }
            }
        }
        if (!dialogueActive)
        {
            dialoguePanel.enabled = false;
            player.SetActive(true);
            ghost.SetActive(true);
        }
        else
        {
            dialoguePanel.enabled = true;
            player.SetActive(false);
            player.SetActive(false);
            if (dialogueSwappable)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    redTalks = !redTalks;
                    chatValue--;
                }
                if (chatValue == 0)
                {
                    dialogueActive = false;
                    dialogueSwappable = false;
                }
                else
                {
                    if (redTalks)
                    {

                        redCharI.color = m_ActiveColor;
                        blueCharI.color = m_InactiveColor;
                    }
                    else
                    {
                        redCharI.color = m_InactiveColor;
                        blueCharI.color = m_ActiveColor;
                    }
                }
            }
        }
    }
    void finalDialogue()
    {
        finalDialoguePlay = true;

    }
}