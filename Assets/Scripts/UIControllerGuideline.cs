using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace DefaultNamespace
{
    public class UIControllerGuideline : UIController
    {
        private GameObject closeButton;
        public Text text1;
        public Text text2;
        NpcCharacteristics characteristics;

        void Start()
        {
            base.Start();
            closeButton = GameObject.FindGameObjectWithTag("Close Button");
        }

        public void ShowCanvas(NpcCharacteristics nc)
        {
            characteristics = nc;
            text1.text = nc.text1;
            text2.text = nc.text2;
            base.ShowCanvas();
            EventSystem.current.SetSelectedGameObject(closeButton);
        }

        public void BtnClicked()
        {
            base.HideCanvas();
            characteristics.guidelineRead = true;
        }
    }
}