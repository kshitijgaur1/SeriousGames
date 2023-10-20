using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    // Start is called before the first frame update
    public Canvas canvas;
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
