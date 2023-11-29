using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIControllerControlsHint : UIController
{
    private GameObject closeButton;

    void Start()
    {
        base.Start();
        closeButton = GameObject.FindGameObjectWithTag("Close Button Controls Hint"); 
    }

    public void ShowCanvas()
    {
        base.ShowCanvas();
        EventSystem.current.SetSelectedGameObject(closeButton);
    }
}