using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSwap : MonoBehaviour
{
    // Here is an array for the characters you can play.
    private GameObject[] characterList;

    // Here is an int that tells which index we are on (aka. which character we are on right now).
    private int index;


    // Start is called before the first frame update
    void Start()
    {
        index = PlayerPrefs.GetInt("CharacterSelected");

        // Here I define how many characters there are in the array, and there are two. I could also instead write [transform.childCount], if I didn't know exactly how many characters I would want to have and to have my code more dynamic.
        characterList = new GameObject[2];

        // Here I make a for loop, that loops through all of the game objects in the array (2 characters).
        for (int i = 0; i < 2; i++)
        {
            characterList[i] = transform.GetChild(i).gameObject;
        }

        // Here I make a foreach loop, that loops through each character in the array again, but we make sure that they are invisible, but still there in memory for the program.
        // In other words, what I want is, when a specific character is being shown, the other one will be invisible, till it is its own turn.
        foreach (GameObject character in characterList)
        {
            character.SetActive(false);
        }

        // Here the character that has been chosen, will be shown and the other one will be invisible.
        // So if you start a new game, and then die, and you get back to the character swap scene, then the character that you both played and chose in the beginning will be shown as the first one.
        if (characterList[index])
        {
            characterList[index].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Here we write the code for the left button. So when the left button is being pressed, it will go though the indices backwards.
    public void ToggleLeftButton()
    {
        // Here we make the current character invisible.
        characterList[index].SetActive(false);

        // Here we go backwards through the indices, when pressing the left button.
        index--;

        // Here we check if the index is under 0, it will go backwards through the character list array.
        if (index < 0)
        {
            index = characterList.Length - 1;
        }

        // Here we make the current character visible.
        characterList[index].SetActive(true);
    }

    // Here we write the code for the right button. So when the right button is being pressed, it will go though the indices forward.
    public void ToggleRightButton()
    {
        // Here we make the current character invisible.
        characterList[index].SetActive(false);

        // Here we go forward through the indices, when pressing the right button.
        index++;

        // Here we check if the index is equal to the character list array's length, it will go back to index 0.
        if (index == characterList.Length)
        {
            index = 0;
        }

        // Here we make the current character visible.
        characterList[index].SetActive(true);
    }

    // Here we write the code for the confirm button. So when the confirm button is being pressed, it will confirm the chosen character and bring it over to the BattleGround scene.
    public void ToggleConfirmButton()
    {
        // Here we assign which character we have chosen, that we want to bring over to the BattleGround scene.
        PlayerPrefs.SetInt("CharacterSelected", index);

        // Here we assign which scene we want to go to, when pressing the confirm button, that is the BattleGround scene.
        SceneManager.LoadScene("BattleGround (testing)");
    }
}
