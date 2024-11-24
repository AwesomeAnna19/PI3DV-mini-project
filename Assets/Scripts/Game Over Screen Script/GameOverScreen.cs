using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public GameObject gameOverUI;

    public void RestartButton()
    {
        SceneManager.LoadScene("BattleGround (testing)");
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("CharacterSwap");
    }
}
