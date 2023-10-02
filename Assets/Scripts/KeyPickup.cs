using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public GameObject chestWithKey;
    private Transform player;
    [SerializeField]
    private float interactionDistance = 1f;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        Pickup();
    }

    private void Pickup()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);
        if (distanceToPlayer <= interactionDistance)
        {
            ChestController chestController = chestWithKey.GetComponent<ChestController>();
            if (chestController != null)
            {
                Debug.Log("key Picked");
                chestController.hasKey = true;
            }

            Destroy(gameObject);
        }
    }
}
