using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class MenuManager : MonoBehaviour
{
    public TMP_Text bestscore;

    public void Start()
    {
        bestscore.text = "Best Score: " + ScoreManager.Instance.name + ": " + ScoreManager.Instance.HighScore; 
    }
    public void SetName(string name)
    {
        ScoreManager.Instance.currentPlayer = name;
    }
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        ScoreManager.Instance.SaveDataToJson();

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
