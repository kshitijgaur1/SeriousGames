using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class TimeHandler : MonoBehaviour
{
    public float timeStamp = 0;
    [SerializeField] private TextMeshProUGUI timeTextField;

    // Start is called before the first frame update
    void Start()
    {
        timeStamp = 0;
    }

    // Update is called once per frame
    private void Update()
    {
        timeStamp += Time.deltaTime;
        // Debug.Log(timeStamp);
        timeTextField.text = System.TimeSpan.FromSeconds(timeStamp).ToString("hh':'mm':'ss");
    }
}