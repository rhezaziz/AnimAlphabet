using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;

public class AlphabetController : MonoBehaviour
{
    // Start is called before the first frame update
    public Text test;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Demo_scene");
        }
        int x;

        //Int32.TryParse(testing, out x);
        Int32.TryParse(DefaultTrackableEventHandler.nameObject, out x);

        //Debug.Log(x + 1);
        int y = x + 1;
        test.text = "" + y;
    }
}
