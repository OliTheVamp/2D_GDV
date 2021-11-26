using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    [Header("Visual Cue")]
    public GameObject visualCue;

    private bool playerInRange;

    private void Awake()
    {
        dialogueActive = false;
        playerInRange = false;
        visualCue.SetActive(false);
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
                chatValue = 12;
                dialogueActive = true;
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
            if (Input.GetKeyDown(KeyCode.Space))
            {
                redTalks = !redTalks;
                chatValue--;
            }
            if (chatValue == 0)
            {
                dialogueActive = false;
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
