using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideScript : MonoBehaviour
{
    private bool visible; //bool to trigger the sprite being on and off
    public GameObject[] gameObjects; //creates an array to hold gameobjects
    public GameObject tint;
    public float tint_timer = 10;

    // Start is called before the first frame update
    void Start()
    {
        tint.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 0.5f);//sets the opacity of the tint sprite to 50%
        //puts all objects with the tag "TintObjecT" into the gameObjects array
        gameObjects = GameObject.FindGameObjectsWithTag("TintObject");

        //makes all the gameobjects tagged with TintObject invisible at the start
        for (int i = 0; i < gameObjects.Length; i++)
        {
            gameObjects[i].SetActive(false);
        }
        tint.SetActive(false);//hides tint
        visible = false;

    }

    // Update is called once per frame
    void Update()
    {
        //things underneath will occur when spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(visible == false)//turns on all the gameobjects if visible is false
            {
                for (int i = 0; i < gameObjects.Length; i++)
                {
                    gameObjects[i].SetActive(true);
                }
                tint.SetActive(true);
                visible = true;
            }
            else if(visible == true)//turns off all gameobjects if visible is true
            {
                for (int i = 0; i < gameObjects.Length; i++)
                {
                    gameObjects[i].SetActive(false);
                }
                tint.SetActive(false);
                visible = false;
            }
        }
    }
}
