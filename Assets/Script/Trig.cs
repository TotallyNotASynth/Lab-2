using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Trig : MonoBehaviour
{
    public InputField playerName;
    public string name;
    

    public void SetName()
    {
        name = playerName.text;
        Debug.Log("name of player is " + name);
    }
    public void Progress()
    {
        PlayerPrefs.SetString("ThisPlayer", name);
        SceneManager.LoadScene("Scene1");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
