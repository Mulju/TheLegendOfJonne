using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClick : MonoBehaviour
{
    // Variables for the gameobjects which can be set in the Unity UI
    public Button startTheStory;
    public Button continueButton;
    public Button firstJonne;
    public Button jesse;
    public Button secondJonne;
    public Button sam;
    public Button storyTeller;
    public Text startText;
    public Text continueText;
    public Text firstJonneText;
    public Text jesseText;
    public Text secondJonneText;
    public Text samText;
    public Text storyTellerText;
    public Text startGameText;
    public GameObject backGroundOne;
    public GameObject backGroundTwo;
    public GameObject cellPhoneOne;
    public GameObject cellPhoneTwo;
    public GameObject cellPhoneThree;
    public GameObject cellPhoneFour;
    public GameObject cellPhoneFive;
    public GameObject cellPhoneSix;

    // A variable to keep count how many times the player has pressed the button for the next line
    int numberOfPresses;

    
    void Start()
    {
        numberOfPresses = 0;
    }

    // A method to control the lines in the dialogue box
    public void ChangeCharacter()
    {
        numberOfPresses++;
        switch (numberOfPresses)
        {
            case 1:
                // First line from the story teller
                startTheStory.gameObject.SetActive(false);
                startText.gameObject.SetActive(false);
                continueButton.gameObject.SetActive(true);
                continueText.gameObject.SetActive(true);
                break;
            case 2:
                // Second line from the story teller
                backGroundOne.gameObject.SetActive(false);
                backGroundTwo.gameObject.SetActive(true);
                cellPhoneOne.gameObject.SetActive(true);
                break;
            case 3:
                // Third line from the story teller
                cellPhoneOne.gameObject.SetActive(false);
                cellPhoneTwo.gameObject.SetActive(true);
                continueButton.gameObject.SetActive(false);
                continueText.gameObject.SetActive(false);
                firstJonne.gameObject.SetActive(true);
                firstJonneText.gameObject.SetActive(true);
                break;
            case 4:
                // Jonne's first line
                cellPhoneTwo.gameObject.SetActive(false);
                cellPhoneThree.gameObject.SetActive(true);
                firstJonne.gameObject.SetActive(false);
                firstJonneText.gameObject.SetActive(false);
                jesse.gameObject.SetActive(true);
                jesseText.gameObject.SetActive(true);
                break;
            case 5:
                // Jesse's line
                cellPhoneThree.gameObject.SetActive(false);
                cellPhoneFour.gameObject.SetActive(true);
                jesse.gameObject.SetActive(false);
                jesseText.gameObject.SetActive(false);
                secondJonne.gameObject.SetActive(true);
                secondJonneText.gameObject.SetActive(true);
                break;
            case 6:
                // Jonne's second line
                cellPhoneFour.gameObject.SetActive(false);
                cellPhoneFive.gameObject.SetActive(true);
                secondJonne.gameObject.SetActive(false);
                secondJonneText.gameObject.SetActive(false);
                sam.gameObject.SetActive(true);
                samText.gameObject.SetActive(true);
                break;
            case 7:
                // Sam's line
                cellPhoneFive.gameObject.SetActive(false);
                cellPhoneSix.gameObject.SetActive(true);
                sam.gameObject.SetActive(false);
                samText.gameObject.SetActive(false);
                storyTeller.gameObject.SetActive(true);
                storyTellerText.gameObject.SetActive(true);
                break;
            case 8:
                // Story tellers fourth line
                cellPhoneSix.gameObject.SetActive(false);
                backGroundOne.gameObject.SetActive(true);
                backGroundTwo.gameObject.SetActive(false);
                storyTeller.gameObject.SetActive(false);
                storyTellerText.gameObject.SetActive(false);
                continueButton.gameObject.SetActive(true);
                continueText.gameObject.SetActive(true);
                startGameText.gameObject.SetActive(false);
                break;
            case 9:
                // Story teller's final line
                continueText.gameObject.SetActive(false);
                startGameText.gameObject.SetActive(true);
                break;
            default:
                break;
        }
    }
}
