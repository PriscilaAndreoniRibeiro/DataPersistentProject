using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public string namePlayer;
    public GameObject inputField;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewName(string name)
    {
        //mehtod calls input field nameplayer
        //namePlayer = inputField.GetComponent<Text>().text;
        //Debug.Log(namePlayer);

        MainManager.Instance.NamePlayer = name;

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
