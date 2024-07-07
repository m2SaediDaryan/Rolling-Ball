using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public enum GameState
    {
        PauseGame
    }
public class GameMenu : MonoBehaviour
{
    /*void RefreshState()
    {
        switch (CurrentGameState)
        {
            case GameState.PauseGame:

                Time.timeScale = 0;
                Menu_Pause.SetActive(true);
                UiInGame.SetActive(false);
                break;
        }
    }*/
    public void ExitGame()
    {
        Application.Quit();
    }
    /*public void PauseGame()
    {
        CallRefreshState(GameState.PauseGame);
    }*/
}
