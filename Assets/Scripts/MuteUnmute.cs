using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteUnmute : MonoBehaviour
{
    [SerializeField]private AudioSource audioSource;
    [SerializeField]private Button muteButton;
    [SerializeField]private Image muteImage;
    [SerializeField] private Image unmuteImage;
    private bool isMuted = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void toggleSound()
    {
        if (isMuted)
        {
            audioSource.mute = false;
            isMuted = false;
            muteButton.image.sprite = unmuteImage.sprite;
        }
        else
        {
            audioSource.mute = true;
            isMuted = true;
            muteButton.image.sprite = muteImage.sprite;
        }
    }
}
