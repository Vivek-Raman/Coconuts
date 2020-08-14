using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HUDLoader : MonoBehaviour
{
    public string HUDSceneName = "Game HUD";
    
    private void Start()
    {
        // load HUDScene
        // hook up the scoreManager to the players
        
        //LoadScene();
    }

    [ContextMenu("Load HUD Scene")]
    private void LoadScene()
    {
        Scene gameScene = this.gameObject.scene;
        SceneManager.LoadSceneAsync(HUDSceneName, LoadSceneMode.Additive)
            .completed += operation =>
        {
            Debug.Log("HUD Loaded");
            SceneManager.SetActiveScene(gameScene);
        };
    }
}