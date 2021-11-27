using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour
{
    private bool visible; //bool to trigger the sprite being on and off
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    public GameObject item4;
    public GameObject item5;
    public GameObject item6;
    public Talking dialogueCount;
    private bool isInside;
    public GameObject tint;
    public bool finalDialogueActive;
    float tint_timer;
    public float maxTime = 5f;
    public float timeSpan = 0.1f;
    public float spacekeytime;

    public bool item1bool = false;
    public bool item2bool = false;
    public bool item3bool = false;
    public bool item4bool = false;
    public bool item5bool = false;
    public bool item6bool = false;


    public GameObject eyeClosed;
    public GameObject eyeOpen;

    // Start is called before the first frame update
    void Start()
    {
        finalDialogueActive = false;
        GameObject g = GameObject.FindGameObjectWithTag("Talking");
        dialogueCount = g.GetComponent<Talking>();
        tint.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 0.5f);//sets the opacity of the tint sprite to 50%
                                                                                         //puts all objects with the tag "TintObjecT" into the gameObjects array
        eyeOpen.SetActive(false);                                                 //puts all objects with the tag "TintObjecT" into the gameObjects array
        eyeClosed.SetActive(false);

        //makes all the gameobjects tagged with TintObject invisible at the start
        item1.SetActive(false);
        item2.SetActive(false);
        item3.SetActive(false);
        item4.SetActive(false);
        item5.SetActive(false);
        item6.SetActive(false);
        tint.SetActive(false);//hides tint
        visible = false;
        tint_timer = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        //deactivates items when they've been collided with
        if (item1bool)
        {
            item1.SetActive(false);
        }
        if (item2bool)
        {
            item2.SetActive(false);
        }
        if (item3bool)
        {
            item3.SetActive(false);
        }
        if (item4bool)
        {
            item4.SetActive(false);
        }
        if (item5bool)
        {
            item5.SetActive(false);
        }
        if (item6bool)
        {
            item6.SetActive(false);
        }


        //things underneath will occur when Z is held down
        if (Input.GetKey(KeyCode.Z)) //User holds down Z
        {
            spacekeytime += Time.deltaTime; //Checks if user is holding down the Z key

            if (spacekeytime > timeSpan) //If user is holding down the Z key, the code runs
            {

                if (tint_timer > 0) // Shows Objects with tint
                {
                    if (isInside)
                    {
                        eyeClosed.SetActive(false);
                        eyeOpen.SetActive(true);
                    }
                    if (!isInside)
                    {
                        eyeClosed.SetActive(true);
                        eyeOpen.SetActive(false);
                    }
                    if(dialogueCount.dialogueCount==1)
                    {
                        if (!item1bool)
                        {
                            item1.SetActive(true);
                        }
                        if (!item2bool)
                        {
                            item2.SetActive(true);
                        }
                    }
                    if(dialogueCount.dialogueCount == 2)
                    {
                        if (!item3bool)
                        {
                            item3.SetActive(true);
                        }
                        if (!item4bool)
                        {
                            item4.SetActive(true);
                        }
                    }
                    if(dialogueCount.dialogueCount == 3)
                    {
                        if (!item5bool)
                        {
                            item5.SetActive(true);
                        }
                        if (!item6bool)
                        {
                            item6.SetActive(true);
                        }
                    }
                    tint.SetActive(true);
                    tint_timer -= Time.deltaTime;
                }
                else if (tint_timer <= 0) //turns off tint + objects
                {

                    item1.SetActive(false);
                    item2.SetActive(false);
                    item3.SetActive(false);
                    item4.SetActive(false);
                    item5.SetActive(false);
                    item6.SetActive(false);
                    tint.SetActive(false);

                }
            } 
        }

        else //user is NOT holding Z
        {
            spacekeytime = 0;
            item1.SetActive(false);
            item2.SetActive(false);
            item3.SetActive(false);
            item4.SetActive(false);
            item5.SetActive(false);
            item6.SetActive(false);
            tint.SetActive(false);

            eyeClosed.SetActive(false);
            eyeOpen.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "collisionTint")
        {
            isInside = true;
        }
        if (other.gameObject.tag == "item1")
        {
            Debug.Log("You got item 1");
            isInside = false;
            item1bool = true;
            item2bool = true;
            objectQuest++;
        }
        if (other.gameObject.tag == "item2")
        {
            Debug.Log("You got item 2");
            isInside = false;
            item2bool = true;
            item1bool = true;
            objectQuest++;
        }
        if (other.gameObject.tag == "item3")
        {
            Debug.Log("You got item 3");
            isInside = false;
            item3bool = true;
            item4bool = true;
            objectQuest++;
        }
        if (other.gameObject.tag == "item4")
        {
            Debug.Log("You got item 4");
            isInside = false;
            item4bool = true;
            item3bool = true;
            objectQuest++;
        }
        if (other.gameObject.tag == "item5")
        {
            Debug.Log("You got item 5");
            finalDialogueActive = true;
            isInside = false;
            item5bool = true;
            item6bool = true;
            objectQuest++;
        }
        if (other.gameObject.tag == "item6")
        {
            Debug.Log("You got item 6");
            finalDialogueActive = true;
            isInside = false;
            item6bool = true;
            item5bool = true;
            objectQuest++;
        }

    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "collisionTint")
        {
            isInside = false;
        }
    }
}
