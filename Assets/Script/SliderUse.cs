using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderUse : MonoBehaviour
{
    public Slider bellWhistle;
    public GameObject bell;
    public GameObject whistle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bellWhistle.value == 0)
        {
            bell.SetActive(true);
            whistle.SetActive(false);
        }
        else if (bellWhistle.value == 1)
        {
            bell.SetActive(false);
            whistle.SetActive(true);
        }
    }
}
