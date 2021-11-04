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
        sentence[0] = eachLine[3];
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
        //Words.text = eachLine[3];
        Debug.Log(eachLine[4]);
        Debug.Log(eachLine[10]);

        Debug.Log(eachLine[0]);
        //int kWords = eachLine.Count;
        //Debug.Log(eachLine[kWords - 1]);
    }
}
