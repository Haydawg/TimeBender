using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    GameObject startPos;
    GameObject player;
    public string nextScene;
    int scenes = 0;
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Update()
    {
        if (scenes == 0)
            nextScene = "CyberpunkAllyScene";
        if (scenes == 1)
            nextScene = "PlainScene";
        if (scenes == 2)
            nextScene = "CyberpunkAllyScene";
        if (scenes == 3)
            nextScene = "CityStreetScene";
        if (scenes == 4)
            nextScene = "CyberpunkAllyScene";
    }
    //Load scene via scene number
    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(nextScene);
        scenes++;
    }
    
}
