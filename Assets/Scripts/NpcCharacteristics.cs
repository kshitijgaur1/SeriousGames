using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcCharacteristics : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Triggered Collider");
        if (other.gameObject.tag == "Player")
        {
            // GetComponent<DialogueTrigger>().StartDialog();
        }

    }
    
    void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("Triggered Collider Stay");
        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<DialogueTrigger>().StartDialog();
        }

    }
}
