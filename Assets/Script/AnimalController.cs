using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AnimalController : MonoBehaviour
{
    public Text textInfo;
    

    DefaultTrackableEventHandler control;
    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Demo_scene");
        }

        //Debug.Log(control.nama);?\
        //Debug.Log(DefaultTrackableEventHandler.nameObject);
        if(DefaultTrackableEventHandler.track == true)
        {
            textInfo.text = DefaultTrackableEventHandler.nameObject;
        }
        else
        {
            textInfo.text = "";
            
        }

        
    }


    public void NextAnim()
    {

    }
}
