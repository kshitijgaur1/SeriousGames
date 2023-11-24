using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NpcCharacteristics : MonoBehaviour
{
    private Transform player;
    [SerializeField] private float interactionDistance = 2;
    private DialogueTrigger dialogueTrigger;
    public DialogueManager dialogueManager;
    public bool taskDone = false;
    public string text1;
    public string text2;
    public bool guidelineRead = false;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        dialogueTrigger = GetComponent<DialogueTrigger>();
        dialogueManager = FindObjectOfType<DialogueManager>();
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);
        if (distanceToPlayer <= interactionDistance && Input.GetKeyDown(KeyCode.Space))
        {
            if (dialogueManager.isActive == false)
            {
                dialogueTrigger.StartDialog();
            }
            else
            {
                dialogueManager.NextMessage();
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Debug.Log("Triggered Collider");
        // if (other.gameObject.tag == "Player")
        // {
        //     // GetComponent<DialogueTrigger>().StartDialog();
        // }

    }
    
    void OnTriggerStay2D(Collider2D other)
    {
        // Debug.Log("Triggered Collider Stay");
        // if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.Space))
        // {
        //     GetComponent<DialogueTrigger>().StartDialog();
        // }

    }
}
