using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelPage : MonoBehaviour
{
    
    public void Win()
    {
        GameObject.Find("/Canvas/LevelPage/WinPanel").gameObject.SetActive(true);
        
    }

    public void Lose()
    {
        GameObject.Find("/Canvas/LevelPage/LosePanel").gameObject.SetActive(true);
    }

    public void returnMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    
}
