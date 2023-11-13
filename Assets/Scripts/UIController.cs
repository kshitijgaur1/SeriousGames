using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] public Canvas canvas;

    PlayerMovement playerMovement;

    // Start is called before the first frame update
    protected void Start()
    {
        canvas.enabled = false;
        playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    public void ShowCanvas()
    {
        canvas.enabled = true;
        playerMovement.enabled = false;
    }

    public void HideCanvas()
    {
        canvas.enabled = false;
        playerMovement.enabled = true;
    }


    public void BtnClicked()
    {
        HideCanvas();
    }
}