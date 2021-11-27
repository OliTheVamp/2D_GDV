﻿using UnityEngine;
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
    private string FileTwoV2LongString;//
    private string FileThreeLongString;
    private string FileThreeV2LongString;
    private string FileFourLongString;//
    private string FileFourV2LongString;
    private string FileFiveLongString;
    private string FileSixLongString;//

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


        //sentence[0] = eachLine[0];
        //sentence[1] = eachLine[1];
        //sentence[2] = eachLine[2];
        //sentence[3] = eachLine[3];
    } 
  
    void FileTwoSetup()
    {
        string[] sentenceFileTwo = new string[5];
        FileTwoLongString = TextFileTwo.text;

        eachLineFileTwoV2 = new List<string>();
        eachLineFileTwoV2.AddRange(FileTwoLongString.Split("\n"[0]));


        //sentenceFileTwo[0] = eachLineFileTwo[0];
        //sentenceFileTwo[1] = eachLineFileTwo[1];
        //sentenceFileTwo[2] = eachLineFileTwo[2];
        //sentenceFileTwo[3] = eachLineFileTwo[3];
    }
   
    void FileTwoV2Setup()
    {
        string[] sentenceFileTwoV2 = new string[5];
        FileTwoV2LongString = TextFileTwoV2.text;

        eachLineFileTwoV2 = new List<string>();
        eachLineFileTwoV2.AddRange(FileTwoV2LongString.Split("\n"[0]));


        //sentenceFileTwoV2[0] = eachLineFileTwoV2[0];
        //sentenceFileTwoV2[1] = eachLineFileTwoV2[1];
        //sentenceFileTwoV2[2] = eachLineFileTwoV2[2];
        //sentenceFileTwoV2[3] = eachLineFileTwoV2[3];
    }

    void FileThreeSetup()
    {
        string[] sentenceFileThree = new string[5];
        FileThreeLongString = TextFileThree.text;

        eachLineFileThree = new List<string>();
        eachLineFileThree.AddRange(FileThreeLongString.Split("\n"[0]));


        //sentenceFileThree[0] = eachLineFileThree[0];
        //sentenceFileThree[1] = eachLineFileThree[1];
        //sentenceFileThree[2] = eachLineFileThree[2];
        //sentenceFileThree[3] = eachLineFileThree[3];
    }

    void FileThreeV2Setup()
    {
        string[] sentenceFileThreeV2 = new string[5];
        FileThreeV2LongString = TextFileThreeV2.text;

        eachLineFileThreeV2 = new List<string>();
        eachLineFileThreeV2.AddRange(FileThreeV2LongString.Split("\n"[0]));


        //sentenceFileThreeV2[0] = eachLineFileThreeV2[0];
        //sentenceFileThreeV2[1] = eachLineFileThreeV2[1];
        //sentenceFileThreeV2[2] = eachLineFileThreeV2[2];
        //sentenceFileThreeV2[3] = eachLineFileThreeV2[3];
    }

    void FileFourSetup()
    {
        string[] sentenceFileFour = new string[5];
        FileFourLongString = TextFileFour.text;

        eachLineFileFour = new List<string>();
        eachLineFileFour.AddRange(FileFourLongString.Split("\n"[0]));


        //sentenceFileFour[0] = eachLineFileFour[0];
        //sentenceFileFour[1] = eachLineFileFour[1];
        //sentenceFileFour[2] = eachLineFileFour[2];
        //sentenceFileFour[3] = eachLineFileFour[3];
    }

    void FileFourV2Setup()
    {
        string[] sentenceFileFourV2 = new string[5];
        FileFourV2LongString = TextFileFourV2.text;

        eachLineFileFourV2 = new List<string>();
        eachLineFileFourV2.AddRange(FileFourV2LongString.Split("\n"[0]));


        //sentenceFileFourV2[0] = eachLineFileFourV2[0];
        //sentenceFileFourV2[1] = eachLineFileFourV2[1];
        //sentenceFileFourV2[2] = eachLineFileFourV2[2];
        //sentenceFileFourV2[3] = eachLineFileFourV2[3];
    }

    void FileFiveSetup()
    {
        string[] sentenceFileFive = new string[5];
        FileFiveLongString = TextFileFive.text;

        eachLineFileFive = new List<string>();
        eachLineFileFive.AddRange(FileFiveLongString.Split("\n"[0]));


        //sentenceFileFive[0] = eachLineFileFive[0];
        //sentenceFileFive[1] = eachLineFileFive[1];
        //sentenceFileFive[2] = eachLineFileFive[2];
        //sentenceFileFive[3] = eachLineFileFive[3];
    }

    void FileSixSetup()
    {
        string[] sentenceFileSix = new string[5];
        FileSixLongString = TextFileSix.text;

        eachLineFileFive = new List<string>();
        eachLineFileFive.AddRange(FileFiveLongString.Split("\n"[0]));


        //sentenceFileSix[0] = eachLineFileSix[0];
        //sentenceFileSix[1] = eachLineFileSix[1];
        //sentenceFileSix[2] = eachLineFileSix[2];
        //sentenceFileSix[3] = eachLineFileSix[3];
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
        if (hideObject.item2bool)
            PrintTwoV2();
        if (hideObject.item3bool)
            PrintThree();
        if (hideObject.item4bool)
            PrintThreeV2();
        if (hideObject.item5bool)
            PrintFour();
        if (hideObject.item6bool)
            PrintFourV2();
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
    void PrintThree()
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
    void PrintThreeV2()
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
    void PrintFour()
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
    void PrintFourV2()
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
    void PrintFive()
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
    void PrintSix()
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
}