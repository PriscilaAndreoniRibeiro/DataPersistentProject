using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public GameObject inputField;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ReadPlayerName(inputField.GetComponent<Text>().text);
    }
    public void ReadPlayerName(string playernameinput)
    {
        DataPersistent.Instance.PlayerName = playernameinput;
        Debug.Log(DataPersistent.Instance.PlayerName);
    }


    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    { 
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
