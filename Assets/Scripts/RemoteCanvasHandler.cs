using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RemoteCanvasHandler : MonoBehaviour
{
    [SerializeField]TextMeshProUGUI resultText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void NonCaptionButtonClicked()
    {
        resultText.text = "No Use";
    }
    
    public void CaptionButtonClicked()
    {
        resultText.text = "Hehe Caption";
    }
}
