using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


/*
 * This is the class that holds major of the logic behind the cutscenes dialogues.
 */
public class DialogueManager : MonoBehaviour
{
    // The elements for the name of the character and their sentences.
    public Text nameText;
    public Text dialogueText;

    // Animator for moving the dialogue box.
    public Animator animator;

    // Queue to hold the sentences.
    private Queue<string> sentences;
    
    
    void Start()
    {
        sentences = new Queue<string>();
    }

    // Method to start the dialogue for the current character.
    public void StartDialogue(Dialogue dialogue)
    {
        // After starting a dialogue, this line sets the animation to open.
        animator.SetBool("IsOpen", true);

        // Display the name of the character.
        nameText.text = dialogue.name;

        // Clear the queue of the last characters sentences.
        sentences.Clear();

        // Queue the sentences gotten from the character object.
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }


    // Method to display the next sentence for the character.
    public void DisplayNextSentence()
    {
        // If there are no more sentences, call the end of this scene.
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        // Take the sentence from the top of the queue and store it.
        string sentence = sentences.Dequeue();

        // Start a coroutine to display the sentence.
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }


    /*
     * This coroutine displays the sentence letter by letter,
     * creating a pixel-artish feel for the game.
     */
    IEnumerator TypeSentence (string sentence)
    {
        // Empty the text field before writing the new one.
        dialogueText.text = "";

        // Write the letter on to the screen letter by letter and wait 2 milliseconds between the letters.
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            
            yield return new WaitForSeconds(.02f);
        }
    }


    // Method to end the dialogue and advance to the next scene.
    void EndDialogue()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        animator.SetBool("IsOpen", false);
    }
}
