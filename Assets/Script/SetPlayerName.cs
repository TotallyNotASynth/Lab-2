using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetPlayerName : MonoBehaviour
{
    public Text playerName;
    public string name;
    // Start is called before the first frame update
    void Start()
    {
        name = PlayerPrefs.GetString("ThisPlayer", "name");
        playerName.text = "Name: " + name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
