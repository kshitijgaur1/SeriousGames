using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

	public Message[] messages;
	public Message[] messages2;
	public Actor[] actors;
	public bool taskDone=false;

    public void StartDialog()
    {
		Debug.Log(taskDone);
		if (!taskDone)
		{
			FindObjectOfType<DialogueManager>().OpenDialogue(messages, actors);
		}
		else
		{
            FindObjectOfType<DialogueManager>().OpenDialogue(messages2, actors);
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
