using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ReadPlayerName(string playernameinput)
    {
        MainManager.Instance.PlayerName = playernameinput;
        Debug.Log(MainManager.Instance.PlayerName);
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
