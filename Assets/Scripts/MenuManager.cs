using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;
    public static string userName;
    public InputField userNameField;
    public int highScore;


    // Start is called before the first frame update
    private void Awake()
    {

        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }


        Instance = this;
        DontDestroyOnLoad(gameObject);
        //LoadColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [System.Serializable]
    class SaveData
    {
        public int highScore;
    }

    public void SaveHighScore(int score)
    {
        SaveData highScore = new SaveData();
        highScore.highScore = score;

        string json = JsonUtility.ToJson(highScore);
        File.WriteAllText(Application.persistentDataPath + "savefile.json", json);
    }

    public void LoadHighScore()
    {
        string path = Application.persistentDataPath + "savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            highScore = data.highScore;
        }
    }

    public void StartButton()
    {
        userName = userNameField.text;
        Debug.Log(userName);
        SceneManager.LoadScene("main", LoadSceneMode.Single);
    }


}
