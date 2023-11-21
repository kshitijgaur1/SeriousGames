using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RemoteCanvasHandler : MonoBehaviour
{
    [SerializeField]TextMeshProUGUI resultText;
    private NpcCharacteristics nc;
    // Start is called before the first frame update
    void Start()
    {
        resultText.text = "Press Button";
        GameObject npcObject = GameObject.FindGameObjectWithTag("Grandpa");
        if (npcObject != null)
        {
            nc = npcObject.GetComponent<NpcCharacteristics>();
        }
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
        nc.taskDone = true;
    }
}
