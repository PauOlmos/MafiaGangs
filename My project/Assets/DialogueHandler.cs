using DialogueEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHandler : MonoBehaviour
{
    public static void StartDialogue(GameObject npcConversation)
    {
        NPCConversation conversation = npcConversation.GetComponent<NPCConversation>();

        ConversationManager _conversationManager = FindObjectOfType<ConversationManager>();

        _conversationManager.StartConversation(conversation);
        
    }
}
