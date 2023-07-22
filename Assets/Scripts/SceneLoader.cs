using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    [SerializeField] private string game = "GameScene";
    [SerializeField] private string mainMenu = "MainMenu";


    public void StartGameButton()
    {
        SceneManager.LoadScene(game);
    }



}
