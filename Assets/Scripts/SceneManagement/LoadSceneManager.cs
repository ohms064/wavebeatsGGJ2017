using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneManager : MonoBehaviour {
    [HideInInspector]
    public Scenes currentScene = Scenes.MAIN_MENU;
    [HideInInspector]
    public static LoadSceneManager instance;

    public Scenes nextScene;

    public void LoadNextScene() {
        SceneManager.LoadScene((int)nextScene);
        currentScene = nextScene;
    }

    public void ReloadScene() {
        SceneManager.LoadScene((int)currentScene);
    }

    public void Close() {
        Application.Quit();
    }
}
