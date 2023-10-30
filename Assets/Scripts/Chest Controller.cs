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

    public RectTransform itemScreen; // Reference to the item screen.

    private SpriteRenderer spriteRenderer;
    private PlayerMovement playerMovement;

    private void Start()
    {
        spriteRenderer = GetComponent <SpriteRenderer>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        GameObject npcObject = GameObject.FindGameObjectWithTag("Grandma");
        playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent <PlayerMovement>();

        if (npcObject != null)
        {
            dt = npcObject.GetComponent<DialogueTrigger>();
        }

        itemScreen.localScale = Vector3.zero; // Initialize item screen to be hidden.

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
            OpenImage(); // Call the OpenImage method to display the item screen.
        }
        else
        {
            spriteRenderer.sprite = closedChestSprite;
            CloseImage(); // Call the CloseImage method to hide the item screen.
        }
    }

    private void OpenImage()
    {
        itemScreen.LeanScale(Vector3.one, 0.2f).setEaseInOutExpo();
        playerMovement.enabled = false;
    }

    private void CloseImage()
    {
        itemScreen.LeanScale(Vector3.zero, 0.2f).setEaseInOutExpo();
        playerMovement.enabled = true;
    }
}
