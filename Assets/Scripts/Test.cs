using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Test : MonoBehaviour
{

    public static MenuManager Instance;
    public static string userName;
    public InputField userNameField;
    public int highScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButton()
    {
        //userName = userNameField.text;
        ChangeName();
        Debug.Log(userNameField.text);
        SceneManager.LoadScene("main", LoadSceneMode.Single);
    }

    public void ChangeName()
    {
        userName = userNameField.text;
    }


}
