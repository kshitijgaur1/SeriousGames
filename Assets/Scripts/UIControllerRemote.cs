using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

namespace DefaultNamespace
{
    public class UIControllerRemote:UIController
    {
        //select button with tag "Power Button"
        private GameObject powerButton;

        void Start()
        {
            base.Start();
            powerButton = GameObject.FindGameObjectWithTag("Power Button"); 
        }

        public void ShowCanvas()
        {
            base.ShowCanvas();
            EventSystem.current.SetSelectedGameObject(powerButton);
        }
    }
}