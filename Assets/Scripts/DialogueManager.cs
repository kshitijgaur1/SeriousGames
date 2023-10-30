using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.Serialization;

//TODO : ADD SOME OTHER WAY TO OPEN AND CLOSE DIALOG BOXES, ERROR MOSTLY DUE TO LEAN TWEEN LIBRARY

public class DialogueManager : MonoBehaviour
{

	public Image actorImage;
	public TextMeshProUGUI actorName;
	public TextMeshProUGUI messageText;
	public RectTransform backgroundBox;
	Rigidbody2D playerRigidbody;
	PlayerMovement playerMovement;

	Message[] currentMessages;
	Actor[] currentActors;
	int activeMessage=0;

	public bool isActive = false;
    [FormerlySerializedAs("controller")] public UIControllerGuideline controllerGuideline;


    public void OpenDialogue(Message[] messages, Actor[] actors)
	{
		currentMessages = messages;
		currentActors = actors;
		activeMessage = 0;
		
		
		isActive = true;
		// playerRigidbody.bodyType = RigidbodyType2D.Static;
		playerMovement.animator.SetBool("IsMoving", false);
		playerMovement.enabled = false;

		Debug.Log("Started conversation! Loaded messages: " + messages.Length);
		DisplayMessage();
		backgroundBox.LeanScale(Vector3.one, 0.2f).setEaseInOutExpo();
	}

	void AnimateTextColor()
	{
		LeanTween.textAlpha(messageText.rectTransform, 0, 0);
		LeanTween.textAlpha(messageText.rectTransform, 1, 0.5f);
	}

	void DisplayMessage()
	{
		Message messageToDisplay = currentMessages[activeMessage];
		messageText.text = messageToDisplay.message;

		Actor actorToDisplay = currentActors[messageToDisplay.actorId];
		actorName.text = actorToDisplay.name;
		actorImage.sprite = actorToDisplay.sprite;
		AnimateTextColor(); //NOT WORKING CHECK
	}

	public void NextMessage()
	{
		activeMessage++;
		if (activeMessage >= currentMessages.Length)
		{
			Debug.Log("Ended conversation!");
			backgroundBox.LeanScale(Vector3.zero, 0.2f).setEaseInOutExpo();
			// playerRigidbody.bodyType = RigidbodyType2D.Kinematic;
			playerMovement.animator.SetBool("IsMoving", true);
			playerMovement.enabled = true;
			isActive = false;
			DialogueTrigger dt = FindObjectOfType<DialogueTrigger>();
			if (dt.taskDone)
			{
				controllerGuideline = FindObjectOfType<UIControllerGuideline>();
				controllerGuideline.ShowCanvas();
			}
		}
		else
		{
			DisplayMessage();
		}
	}

	void Start()
	{
		backgroundBox.transform.localScale = Vector3.zero;
		playerRigidbody = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
		playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
		
	}


	/*void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space) && isActive)
			NextMessage();
	}*/
}
