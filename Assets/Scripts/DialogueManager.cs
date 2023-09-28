using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour {

	public Image actorImage;
	public TextMeshProUGUI actorName;
	public TextMeshProUGUI messageText;
	public RectTransform backgroundBox;

	Message[] currentMessages;
	Actor[] currentActors;
	int activeMessage = 0;

	public void OpenDialogue(Message[] messages, Actor[] actors) {
		currentMessages = messages;
		currentActors = actors;
		activeMessage = 0;

		Debug.Log("Started conversation! Loaded messages: " + messages.Length);
	}
	
	void Start () {
		
	}

	
	void Update ()
	{

	}
}
