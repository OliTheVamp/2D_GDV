using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    bool item1;
    bool item2;
    bool item3;
    bool item4;
    bool item5;
    bool item6;
    public bool finalDialogueActive;
    // Start is called before the first frame update
    void Start()
    {
        finalDialogueActive = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "item1")
        {
            Destroy(other.gameObject);
            Debug.Log("You got item 1");
            item1 = true;
        }
        if (other.gameObject.tag == "item2")
        {
            Destroy(other.gameObject);
            Debug.Log("You got item 2");
            item2 = true;
        }
        if (other.gameObject.tag == "item3")
        {
            Destroy(other.gameObject);
            Debug.Log("You got item 3");
            item3 = true;
        }
        if (other.gameObject.tag == "item4")
        {
            Destroy(other.gameObject);
            Debug.Log("You got item 4");
            item4 = true;
        }
        if (other.gameObject.tag == "item5")
        {
            Destroy(other.gameObject);
            finalDialogueActive = true;
            Debug.Log("You got item 5");
            item5 = true;
        }
        if (other.gameObject.tag == "item6")
        {
            Destroy(other.gameObject);
            finalDialogueActive = true;
            Debug.Log("You got item 6");
            item6 = true;
        }
        
    }
}
