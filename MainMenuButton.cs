using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    public void GoToMainMenu()
    {
        Debug.Log("Main Menu Button was pressed.");

        SceneManager.LoadScene("MainMenu");
    }
}
