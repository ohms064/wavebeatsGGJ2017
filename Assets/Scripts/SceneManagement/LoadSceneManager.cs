using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneManager : MonoBehaviour {
    [HideInInspector]
    public Scenes currentScene = Scenes.MAIN_MENU;
    [HideInInspector]
    public static LoadSceneManager instance;
    public Canvas pauseCanvas;
    public AudioSource audioSource;

    public Scenes nextScene;

    void Start() {
        instance = this;
    }

    public void LoadNextScene() {
        SceneManager.LoadScene((int)nextScene, LoadSceneMode.Single);
        currentScene = nextScene;
        Time.timeScale = 1;
    }

    public void LoadNextScene(Scenes newScene) {
        SceneManager.LoadScene((int)newScene, LoadSceneMode.Single);
        currentScene = nextScene;
        Time.timeScale = 1;
    }

    public void ReloadScene() {
        SceneManager.LoadScene((int)currentScene);
    }

    public void Close() {
        Application.Quit();
    }

    public void PauseGame() {
        Time.timeScale = 0;
        pauseCanvas.enabled = true;
        audioSource.Pause();
    }

    public void UnpauseGame() {
        Time.timeScale = 1;
        pauseCanvas.enabled = false;
        audioSource.UnPause();
    }
}
