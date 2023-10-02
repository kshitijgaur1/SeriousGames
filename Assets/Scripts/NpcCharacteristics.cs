using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcCharacteristics : MonoBehaviour
{
    private Transform player;
    [SerializeField] private float interactionDistance = 1;
    private DialogueTrigger dialogueTrigger;
    private DialogueManager dialogueManager;
    
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
        if (distanceToPlayer <= interactionDistance && Input.GetKeyDown(KeyCode.Space) && dialogueManager.isActive == false)
        {
            dialogueTrigger.StartDialog();
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
