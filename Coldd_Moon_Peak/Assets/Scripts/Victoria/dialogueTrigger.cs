using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogueTrigger : MonoBehaviour
{
    public bool dialogueActive = false;
    public bool redTalks = false;
    public GameObject redChar;
    public GameObject blueChar;
    public Image redCharI;
    public Image blueCharI;
    public Color m_InactiveColor;
    public Color m_ActiveColor;
    public Canvas dialoguePanel;
    public int chatValue = 8;
    private void Start()
    {
        redCharI = redChar.GetComponent<Image>();
        blueCharI = blueChar.GetComponent<Image>();
        m_InactiveColor = Color.grey;
        m_ActiveColor = Color.white;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            chatValue = 8;
            dialogueActive = true;
        }
        if (!dialogueActive)
        {
            dialoguePanel.enabled = false;
        }
        else
        {
            dialoguePanel.enabled = true;
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
