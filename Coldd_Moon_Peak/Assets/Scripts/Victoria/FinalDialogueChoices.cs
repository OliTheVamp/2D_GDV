using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinalDialogueChoices : MonoBehaviour
{
    public bool roundOneChosen = false;
    public bool roundTwoChosen = false;
    public bool roundThreeChosen = false;

    public int choicesCorrect = 0;

    public Button choiceOne;
    public Button choiceTwo;
    public Button choiceThree;
    public Button choiceFour;
    public Button choiceFive;
    public Button choiceSix;
    void OnEnable()
    {
        choiceOne.gameObject.SetActive(true);
        choiceTwo.gameObject.SetActive(true);
        choiceThree.gameObject.SetActive(false);
        choiceFour.gameObject.SetActive(false);
        choiceFive.gameObject.SetActive(false);
        choiceSix.gameObject.SetActive(false);
    }
    void Update() {
    if (!roundOneChosen)
        {
            choiceOne.gameObject.SetActive(true);
            choiceTwo.gameObject.SetActive(true);
        }
        if (!roundTwoChosen && roundOneChosen)
        {
            choiceThree.gameObject.SetActive(true);
            choiceFour.gameObject.SetActive(true);
            choiceOne.gameObject.SetActive(false);
            choiceTwo.gameObject.SetActive(false);
        }

        if (!roundThreeChosen && roundTwoChosen)
        {
            choiceFive.gameObject.SetActive(true);
            choiceSix.gameObject.SetActive(true);
            choiceThree.gameObject.SetActive(false);
            choiceFour.gameObject.SetActive(false);
        }
        if (roundThreeChosen && choicesCorrect == 3)
            winScreen();
        else
            loseScreen();

    }
    public void CorrectButton()
    {
        choicesCorrect++;
        if (!roundThreeChosen && roundTwoChosen)
        {
            roundThreeChosen = true;
        }
        if (!roundTwoChosen && roundOneChosen)
        {
            roundTwoChosen = true;
        }
        if (!roundOneChosen)
        {
            roundOneChosen = true;
        }
    }
    public void IncorrectButton()
    {
        if (!roundThreeChosen && roundTwoChosen)
        {
            roundThreeChosen = true;
        }
        if (!roundTwoChosen && roundOneChosen)
        {
            roundTwoChosen = true;
        }
        if (!roundOneChosen)
        {
            roundOneChosen = true;
        }
    }

    void winscreen()
    {
        SceneManager.LoadScene(3);
    }

    void losescreen()
    {
        SceneManager.LoadScene(2);
    }
        /*
    public GameObject dialoguePanel;
    public GameObject dialogueText;

    public GameObject[] choices;
    public Text[] choicesText;

    bool finalDialoguePlaying

    void Start()
    {
        finaldialoguePlaying = false;
        dialoguePanel.SetActive = false;

        choicesText = new Text[choices.Length];
        int index = 0;
        foreach(GameObject choice in choices)
        {
            choicesText[index] = choice.GetComponentInChildren<Text>();
            index ++
        }
    }

    void DisplayChoices()
    {

    }*/
}
