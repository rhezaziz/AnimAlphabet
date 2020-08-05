using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AnimalController : MonoBehaviour
{
    public Text textInfo;
    public GameObject panelScan;
    

    DefaultTrackableEventHandler control;
    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MainMenu.namaScene = "menu";
            SceneManager.LoadScene("Loading");
        }

        //Debug.Log(control.nama);?\
        //Debug.Log(DefaultTrackableEventHandler.nameObject);
        if(Controller.track == true)
        {
            textInfo.text = Controller.nameObject;
            panelScan.SetActive(false);
        }
        else
        {
            textInfo.text = "";
            panelScan.SetActive(true);
            
        }

        
    }
}
