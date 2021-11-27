using UnityEngine;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine.UI;
using System.IO;


public class DialogueTrial : MonoBehaviour
{
    public TextAsset TextFileOne; //Starting script - introduction , gives clue
    public TextAsset TextFileTwo; //Correct item - this is what I remember
    public TextAsset TextFileTwoV2; //Incorrect item This isn't right 
    public TextAsset TextFileThree;
    public TextAsset TextFileThreeV2;
    public TextAsset TextFileFour;
    public TextAsset TextFileFourV2;
    public TextAsset TextFileFive;
    public TextAsset TextFileSix;

    public Text Words;
    private string theWholeFileAsOneLongString;
    private string FileTwoLongString;
    private string[] sentence;
    private string[] sentenceFileTwo;
    private string[] sentenceFileTwoV2;
    private string[] sentenceFileThree;
    private string[] sentenceFileThreeV2;
    private string[] sentenceFileFour;
    private string[] sentenceFileFourV2;
    private string[] sentenceFileFive;
    private string[] sentenceFileSix;

    private int index;
    private int side;
    public bool Type;
    private int currentIndex;
    public float typyingSpeed = 0.02f;
    
    //eachLineLists
    private List<string> eachLine;
    private List<string> eachLineFileTwo;
    private List<string> eachLineFileTwoV2;//
    private List<string> eachLineFileThree;
    private List<string> eachLineFileThreeV2;
    private List<string> eachLineFileFour;//
    private List<string> eachLineFileFourV2;
    private List<string> eachLineFileFive;
    private List<string> eachLineFileSix;//

    public Hide hideObject;
   
    void FileOneSetup()
    {
        string[] sentence = new string[5];
        theWholeFileAsOneLongString = TextFileOne.text;

        eachLine = new List<string>();
        eachLine.AddRange(theWholeFileAsOneLongString.Split("\n"[0]));


        sentence[0] = eachLine[0];
        sentence[1] = eachLine[1];
        sentence[2] = eachLine[2];
        sentence[3] = eachLine[3];
    } 
  
    void FileTwoSetup()
    {
        string[] sentenceFileTwo = new string[5];
        FileTwoLongString = TextFileTwo.text;

        eachLineFileTwo = new List<string>();
        eachLineFileTwo.AddRange(FileTwoLongString.Split("\n"[0]));


        sentenceFileTwo[0] = eachLineFileTwo[0];
        sentenceFileTwo[1] = eachLineFileTwo[1];
        sentenceFileTwo[2] = eachLineFileTwo[2];
        sentenceFileTwo[3] = eachLineFileTwo[3];
    }
   
    void FileTwoV2Setup()
    {

    }

    void FileThreeSetup()
    {

    }

    void FileThreeV2Setup()
    {

    }

    void FileFourSetup()
    {

    }

    void FileFourV2Setup()
    {

    }

    void FileFiveSetup()
    {

    }

    void FileSixSetup()
    {

    }

    void Start()
    {
        FileOneSetup();
        FileTwoSetup();
        FileTwoV2Setup();
        FileThreeSetup();
        FileThreeV2Setup();
        FileFourSetup();
        FileFourV2Setup();
        FileFiveSetup();
        FileSixSetup();
    }

    void Update()
    {
        if (hideObject.item1bool == false && hideObject.item2bool == false)
         Print();
        if (hideObject.item1bool)
         PrintTwo();
    }
    
    void Print() 
    {
        side = 0;
        if (Input.GetKeyDown(KeyCode.Space))
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

    void PrintTwo()
    {
                side = 0;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Type = true;
        }
        if (side == 0)
        {
            //Words.text = eachLine[side];
            foreach (char Letter in eachLineFileTwo[side].ToCharArray())
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
            foreach (char Letter in eachLineFileTwo[side].ToCharArray())
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
            foreach (char Letter in eachLineFileTwo[side].ToCharArray())
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
            foreach (char Letter in eachLineFileTwo[side].ToCharArray())
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
            foreach (char Letter in eachLineFileTwo[side].ToCharArray())
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
            foreach (char Letter in eachLineFileTwo[side].ToCharArray())
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
            foreach (char Letter in eachLineFileTwo[side].ToCharArray())

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
            foreach (char Letter in eachLineFileTwo[side].ToCharArray())
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
            foreach (char Letter in eachLineFileTwo[side].ToCharArray())
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
            foreach (char Letter in eachLineFileTwo[side].ToCharArray())
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
            foreach (char Letter in eachLineFileTwo[side].ToCharArray())
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
            foreach (char Letter in eachLineFileTwo[side].ToCharArray())
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

    void PrintTwoV2()
    {

    }
    void PrintThree()
    {

    }
    void PrintThreeV2()
    {

    }
    void PrintFour()
    {

    }
    void PrintFourV2()
    {

    }
    void PrintFive()
    {

    }
    void PrintSix()
    {

    }
}