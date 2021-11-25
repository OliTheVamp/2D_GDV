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

    private bool isInside;
    public GameObject tint;
    float tint_timer;
    public float maxTime = 5f;
    public float timeSpan = 0.1f;
    public float spacekeytime;

    private bool item1bool = false;
    private bool item2bool = false;
    private bool item3bool = false;
    private bool item4bool = false;
    private bool item5bool = false;
    private bool item6bool = false;


    public GameObject eyeClosed;
    public GameObject eyeOpen;

    // Start is called before the first frame update
    void Start()
    {
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

        //things underneath will occur when spacebar is held down
        if (Input.GetKey(KeyCode.Z)) //User holds down space
        {
            spacekeytime += Time.deltaTime; //Checks if user is holding down the space key

            if (spacekeytime > timeSpan) //If user is holding down the space key, the code runs
            {

                Debug.Log(tint_timer);

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
                    if (!item1bool)
                    {
                        item1.SetActive(true);
                    }if (!item2bool)
                    {
                        item2.SetActive(true);
                    }
                    
                    if(item1bool && item2bool)
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
                    if(item3bool && item4bool)
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

        else //user is NOT holding space
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
            other.gameObject.SetActive(false);
            Debug.Log("You got item 1");
            isInside = false;
            item1bool = true;
        }
        if (other.gameObject.tag == "item2")
        {
            other.gameObject.SetActive(false);
            Debug.Log("You got item 2");
            isInside = false;
            item2bool = true;
        }
        if (other.gameObject.tag == "item3")
        {
            other.gameObject.SetActive(false);
            Debug.Log("You got item 3");
            isInside = false;
            item3bool = true;
        }
        if (other.gameObject.tag == "item4")
        {
            other.gameObject.SetActive(false);
            Debug.Log("You got item 4");
            isInside = false;
            item4bool = true;
        }
        if (other.gameObject.tag == "item5")
        {
            other.gameObject.SetActive(false);
            Debug.Log("You got item 5");
            isInside = false;
            item5bool = true;
        }
        if (other.gameObject.tag == "item6")
        {
            other.gameObject.SetActive(false);
            Debug.Log("You got item 6");
            isInside = false;
            item6bool = true;
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
