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
    private int side;
    public bool Type;
    private int currentIndex;
    public float typyingSpeed = 0.02f;
    private List<string> eachLine;
    void Start()
    {
        string[] sentence = new string[5];
        theWholeFileAsOneLongString = dictionaryTextFile.text;

        eachLine = new List<string>();
        eachLine.AddRange(theWholeFileAsOneLongString.Split("\n"[0]));


        sentence[0] = eachLine[0];
        sentence[1] = eachLine[1];
        sentence[2] = eachLine[2];
        sentence[3] = eachLine[3];

        Debug.Log(eachLine[4]);
        Debug.Log(eachLine[10]);

        Debug.Log(eachLine[0]);





    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Type = true;
        }
        if (side == 0)
        {
            //Words.text = eachLine[side];
            foreach (char Letter in eachLine[side].ToCharArray())
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
            Type = false;
            side++;

        }
        if (side == 1 && Type == true)
        {
            Words.text = "";
            //Words.text = eachLine[side];
            foreach (char Letter in eachLine[side].ToCharArray())
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
            Type = false;
            side++;

        }
        if (side == 2 && Type == true)
        {
            Words.text = "";
            //Words.text = eachLine[side];
            foreach (char Letter in eachLine[side].ToCharArray())
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
            Type = false;
            side++;

        }
        if (side == 3 && Type == true)
        {
            Words.text = "";
            //Words.text = eachLine[side];
            foreach (char Letter in eachLine[side].ToCharArray())
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
            Type = false;
            side++;

        }
        if (side == 4 && Type == true)
        {
            Words.text = "";
            //Words.text = eachLine[side];
            foreach (char Letter in eachLine[side].ToCharArray())
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
            Type = false;
            side++;

        }
        if (side == 5 && Type == true)
        {
            Words.text = "";
            //Words.text = eachLine[side];
            foreach (char Letter in eachLine[side].ToCharArray())
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
            Type = false;
            side++;

        }
        if (side == 6 && Type == true)
        {
            Words.text = "";
            //Words.text = eachLine[side];
            foreach (char Letter in eachLine[side].ToCharArray())
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
            Type = false;
            side++;

        }
        if (side == 7 && Type == true)
        {
            Words.text = "";
            //Words.text = eachLine[side];
            foreach (char Letter in eachLine[side].ToCharArray())
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
            Type = false;
            side++;

        }
        if (side == 8 && Type == true)
        {
            Words.text = "";
            //Words.text = eachLine[side];
            foreach (char Letter in eachLine[side].ToCharArray())
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
            Type = false;
            side++;

        }
        if (side == 9 && Type == true)
        {
            Words.text = "";
            //Words.text = eachLine[side];
            foreach (char Letter in eachLine[side].ToCharArray())
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
            Type = false;
            side++;

        }
        if (side == 10 && Type == true)
        {
            Words.text = "";
            //Words.text = eachLine[side];
            foreach (char Letter in eachLine[side].ToCharArray())
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
            Type = false;
            side++;

        }
        if (side == 11 && Type == true)
        {
            Words.text = "";
            //Words.text = eachLine[side];
            foreach (char Letter in eachLine[side].ToCharArray())
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
            Type = false;
            side++;

        }
       
    }
}


    
