using UnityEngine;
using UnityEngine.EventSystems;

namespace DefaultNamespace
{
    public class UIControllerGuideline : UIController
    {
        private GameObject closeButton;

        void Start()
        {
            base.Start();
            closeButton = GameObject.FindGameObjectWithTag("Close Button");
        }

        public void ShowCanvas()
        {
            base.ShowCanvas();
            EventSystem.current.SetSelectedGameObject(closeButton);
        }
    }
}