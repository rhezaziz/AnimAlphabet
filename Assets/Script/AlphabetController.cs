using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;

public class AlphabetController : MonoBehaviour
{
    public GameObject panelScan;
    void Start()
    {
        
    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MainMenu.namaScene = "menu";
            SceneManager.LoadScene("Loading");
        }

        if(Controller.track == false)
        {
            panelScan.SetActive(true);
        }else if(Controller.track == true)
        {
            panelScan.SetActive(false);
        }
    }



}
