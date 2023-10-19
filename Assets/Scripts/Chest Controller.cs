using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    [SerializeField]
    private float interactionDistance = 2f; // Distance at which the player can interact with the chest.
    public Sprite openChestSprite; 
    public Sprite closedChestSprite;

    public bool isOpen = false;
    public bool hasKey;
    private Transform player;
    private DialogueTrigger dt;


    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        GameObject npcObject = GameObject.FindGameObjectWithTag("NPC");
        if (npcObject != null)
        {
            dt = npcObject.GetComponent<DialogueTrigger>();
        }

        SetChestState(false);
    }

    private void Update()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        if (distanceToPlayer <= interactionDistance && hasKey && Input.GetKeyDown(KeyCode.Space))
        {
            dt.taskDone = true;
            ToggleChestState();
        }
    }

    private void ToggleChestState()
    {
        isOpen = !isOpen;
        SetChestState(isOpen);
    }

    private void SetChestState(bool open)
    {
        if (open)
        {
            spriteRenderer.sprite = openChestSprite;
        }
        else
        {
            spriteRenderer.sprite = closedChestSprite;
        }
    }
}
