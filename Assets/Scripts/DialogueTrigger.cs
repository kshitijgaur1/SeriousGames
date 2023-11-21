using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

	public Message[] messages;
	public Message[] messages2;
	public Actor[] actors;
	// public bool taskDone=false;

    public void StartDialog()
    {
		NpcCharacteristics nc = GetComponent<NpcCharacteristics>();
		if (!nc.taskDone)
		{
			FindObjectOfType<DialogueManager>().OpenDialogue(messages, actors, nc);
		}
		else
		{
            FindObjectOfType<DialogueManager>().OpenDialogue(messages2, actors, nc);
        }
    }

}

[System.Serializable]
public class Message
{
	public int actorId;
	public string message;
}

[System.Serializable]
public class Actor
{
	public string name;
	public Sprite sprite;
}
