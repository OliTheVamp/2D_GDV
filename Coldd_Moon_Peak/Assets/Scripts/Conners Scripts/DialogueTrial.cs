using UnityEngine;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine.UI;
using System.IO;


public class DialogueTrial : MonoBehaviour
{
    public TextAsset dictionaryTextFile;
    public Text Words;
    private string theWholeFileAsOneLongString;
    private string[] sentence;
    private int index;
    private int currentIndex;
    private List<string> eachLine;
    void Start()
    {
        string[] sentence = new string[5];
        theWholeFileAsOneLongString = dictionaryTextFile.text;

        eachLine = new List<string>();
        eachLine.AddRange(theWholeFileAsOneLongString.Split("\n"[0]));
        //foreach (char Letter in sentence[index].ToCharArray())
        //{
        //    Words.text += Letter;
        //}
        //Words.text = eachLine[3];

        sentence[0] = eachLine[0];
        foreach (char Letter in sentence[index].ToCharArray())
        {
            if (Letter != '|')
            {
                Words.text += Letter;
            }
            else
            {
                break;
            }
        }

        currentIndex = 0;

        //Words.text = eachLine[3];
        Debug.Log(eachLine[4]);
        Debug.Log(eachLine[10]);

        Debug.Log(eachLine[0]);

        /*if (Input.GetKeyDown(KeyCode.F))
        {
            i++;
        }*/
        //int kWords = eachLine.Count;
        //Debug.Log(eachLine[kWords - 1]);

        //malkin sense of it rn
     }
}
/*
    private void Update()
    {

        sentence[index] = eachLine[currentIndex];
        foreach (char Letter in sentence[index].ToCharArray())
        {
            if (Letter != '|')
            {
                Words.text += Letter;
            }
            else
            {
                break;
            }
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            currentIndex += 1;
            Debug.Log("you pressed. current index" + currentIndex);
        }
    }
}*/
