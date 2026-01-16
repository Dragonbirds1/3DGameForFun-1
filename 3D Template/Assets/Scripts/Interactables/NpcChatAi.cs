using System.Collections;
using UnityEngine;

public class NpcChatAi : MonoBehaviour
{
    /// <summary>
    /// This class will handle NPC AI chat interactions.
    /// The NPC will be able to respond to player inputs using AI.
    /// The AI will respond using a chatBot system.
    /// </summary>
    
    public string npcName = "NPC";
    // Run the chatbot like chatGPT or other similar systems.
    public string chatBotSystem = "DefaultChatBot";
    public string currentConversation = "";
    public int maxConversationLength = 1000;
    public int currentConversationLength = 0;
    public float responseDelay = 1.0f; // Delay in seconds before the NPC responds.
    public bool isResponding = false;
    public float typingSpeed = 0.05f; // Speed at which the NPC "types" the response.
    public string lastPlayerInput = "";
    public string lastNpcResponse = "";
    public int timeTillNextResponses = 0; // Time in seconds until the NPC can respond again.
    public int maxTimeTillNextResponses = 10; // Max time in seconds until the NPC can respond again.
    // TextMeshPro or UI Text component to display the NPC's dialogue can be added here.
    public TMPro.TextMeshProUGUI npcDialogueText;
    // Input field for player to type their messages can be added here.
    public TMPro.TMP_InputField playerInputField;
    // KeyCode to submit player input.
    public KeyCode submitInputKey;
    // More settings can be added later.


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(submitInputKey) && !isResponding)
        {
            string playerInput = playerInputField.text;
            if (!string.IsNullOrEmpty(playerInput))
            {
                OnPlayerInput(playerInput);
                playerInputField.text = "";
            }
        }
        if (timeTillNextResponses > 0)
        {
            timeTillNextResponses -= 1;
        }


    }

    void OnPlayerInput(string playerInput)
    {
        // Handle player input and generate NPC response.
        lastPlayerInput = playerInput;
        if (!isResponding && timeTillNextResponses <= 0)
        {
            isResponding = true;
            Invoke(nameof(GenerateNpcResponse), responseDelay);
        }
    }

    void GenerateNpcResponse()
    {
        // Generate the NPC's response using the chatBotSystem.
        string response = "This is a placeholder response."; // Replace with actual AI response generation.
        // Update conversation history.
        currentConversation += npcName + ": " + response + "\n";
        currentConversationLength += response.Length;
        
        lastNpcResponse = response;
        DisplayNpcResponse(response);
    }

    void DisplayNpcResponse(string response)
    {
        // Display the NPC's response with typing effect.
        // Here we can use a coroutine to simulate typing.
        StartCoroutine(TypeResponce(response));
        // Make the NPC dialogue text visible and update it.
        npcDialogueText.gameObject.SetActive(true);
        npcDialogueText.text = "";


    }

    void ResetConversation()
    {
        // Reset the current conversation.
    }

    void UpdateTimeTillNextResponse()
    {
        // Update the time until the next response.
    }

    void SaveConversationHistory()
    {
        // Save the conversation history for future reference.
    }

    IEnumerator TypeResponce(string response)
    {
        // Make the NPC "type" the response character by character.
        // Make sure to update the NPC dialogue text with each character.
        string displayedText = "";
        foreach (char c in response)
        {
            displayedText += c;
            // Update the NPC's dialogue UI here with displayedText.
            npcDialogueText.text = displayedText;
            yield return new WaitForSeconds(typingSpeed);
        }
        isResponding = false;
        timeTillNextResponses = maxTimeTillNextResponses;
    }
}
