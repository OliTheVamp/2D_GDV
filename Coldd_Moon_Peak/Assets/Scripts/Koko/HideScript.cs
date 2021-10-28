using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideScript : MonoBehaviour
{
    public GameObject heart;
    private bool heartBool;
    // Start is called before the first frame update
    void Start()
    {
        heart.SetActive(true);
        heartBool = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(heartBool == false)
            {
                heart.SetActive(true);
                heartBool = true;
            }else if(heartBool == true)
            {
                heart.SetActive(false);
                heartBool = false;
            }
        }
    }
}
