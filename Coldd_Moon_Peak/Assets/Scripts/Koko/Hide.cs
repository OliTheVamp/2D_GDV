using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour
{
    private bool visible; //bool to trigger the sprite being on and off
    public GameObject[] gameObjects; //creates an array to hold gameobjects
    public GameObject tint;
    float tint_timer;
    public float maxTime = 5f;
    public float timeSpan = 0.1f;
    public float spacekeytime;

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
                    for (int i = 0; i < gameObjects.Length; i++)
                    {
                        gameObjects[i].SetActive(true);
                    }
                    tint.SetActive(true);
                    tint_timer -= Time.deltaTime;
                }
                else if (tint_timer <= 0) //turns off tint + objects
                {

                        for (int i = 0; i < gameObjects.Length; i++)
                        {
                            gameObjects[i].SetActive(false);
                        }
                        tint.SetActive(false);

                }
            } 
        }
        else //user is NOT holding space
        {
            spacekeytime = 0;
            for (int i = 0; i < gameObjects.Length; i++)
            {
                gameObjects[i].SetActive(false);
            }
            tint.SetActive(false);
        }
    }
}
