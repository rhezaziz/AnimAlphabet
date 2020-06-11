using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public Text nama;
    public static string infoNama = "";
    public GameObject _panelTracking;
    public static bool tracking = false;
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
        
        
        if (tracking == true && infoNama == "jerapah")
        {
            nama.text = "Jerapah";
            _panelTracking.SetActive(false);
        }else if (tracking == true && infoNama == "serigala")
        {
            nama.text = "Serigala";
            _panelTracking.SetActive(false);
        }
        else if (tracking == true && infoNama == "kura")
        {
            nama.text = "Kura-Kura";
            _panelTracking.SetActive(false);
        }
        else if(tracking == false)
        {
            _panelTracking.SetActive(true);
            nama.text = "Nama";
        }
    }


    //int x = 0;
    //int x = Int32.Parse(TextBoxD1.Text);
    // Int32.TryParse(TextBoxD1.Text, out x);
}