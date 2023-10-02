using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenItem : MonoBehaviour
{
    public RectTransform itemScreen;
    public ChestController chestController;
    private Transform player;
    [SerializeField] private float interactionDistance = 1;
    PlayerMovement playerMovement;
    bool isOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        itemScreen.localScale = Vector3.zero;
        chestController = GetComponent<ChestController>();
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);
        if (distanceToPlayer <= interactionDistance && Input.GetKeyDown(KeyCode.Space) && !chestController.isOpen && chestController.hasKey)
        {
            itemScreen.LeanScale(Vector3.one, 0.2f).setEaseInOutExpo();
            playerMovement.enabled = false;
        }
        else if (distanceToPlayer <= interactionDistance && Input.GetKeyDown(KeyCode.Space) && chestController.isOpen)
        {
            itemScreen.LeanScale(Vector3.zero, 0.2f).setEaseInOutExpo();
            playerMovement.enabled = true;
        }

    }
}
