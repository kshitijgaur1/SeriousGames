using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController: MonoBehaviour
{
    [SerializeField]public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas.enabled = false;
    }

    public void ShowCanvas()
    {
        canvas.enabled = true;
    }
    
    public void HideCanvas()
    {
        canvas.enabled = false;
    }
    

    public void BtnClicked()
    {
        HideCanvas();
    }
}
