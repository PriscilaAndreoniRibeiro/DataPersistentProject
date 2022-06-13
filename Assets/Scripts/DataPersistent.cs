using UnityEngine;
using System.Collections.Generic;
using System.IO;

public class DataPersistent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public static DataPersistent Instance;
    public string PlayerName;

    public string PlayerWithHighScore = "Marcos";
    public int BestScore = 30;

    public void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadHighScore();
    }
    [System.Serializable]
    class SaveData
    {
        public string PlayerName;
        public int BestScore;
        public string PlayerWithHighScore;
    }

    public void SaveHighScore()
    {
        SaveData data = new SaveData();
        data.PlayerName = PlayerName;
        data.BestScore = BestScore;
        data.PlayerWithHighScore = PlayerWithHighScore;
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            PlayerWithHighScore = data.PlayerWithHighScore;
            PlayerName = data.PlayerName;
            BestScore = data.BestScore;
        }
    }
}