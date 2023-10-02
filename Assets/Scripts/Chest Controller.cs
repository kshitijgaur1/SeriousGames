using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    [SerializeField]
    private float interactionDistance = 1f; // Distance at which the player can interact with the chest.
    public Sprite openChestSprite; 
    public Sprite closedChestSprite;

    private bool isOpen = false;
    public bool hasKey;
    private Transform player;

    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        player = GameObject.FindGameObjectWithTag("Player").transform;

        SetChestState(false);
    }

    private void Update()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        if (distanceToPlayer <= interactionDistance && hasKey && Input.GetKeyDown(KeyCode.Space))
        {
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
