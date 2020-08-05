using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class infoController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panelInfo;
    public Button kanan, kiri;
    bool klik = false;
    public Text textInfo;
    public Text tulisan;
    int info = 0;

    public information listInfo;

    // Update is called once per frame
    void Update()
    {

        textInfo.text = "" + Controller.nameObject;
        if (Controller.track == true)
        {
            if (klik)
            {

                panelInfo.SetActive(true);
            }

        
            else if (!klik)
            {

                panelInfo.SetActive(false);
            }
        }
        else
        {
            info = 0;
            
            if (!klik)
            {

                panelInfo.SetActive(false);
            }
            else
            {
                klik = false;
            }
        }


        if (info == 0)
        {
            kiri.interactable = false;
            kanan.interactable = true;
        }
        if (info == 1)
        {
            kanan.interactable = true;
            kiri.interactable = true;
        }
        if (info == 2)
        {
            kanan.interactable = false;
            kiri.interactable = true;
        }
    }

    private void LateUpdate()
    {
        if (MainMenu.namaScene == "Animal")
        {
            if (Controller.nameObject == "serigala")
            {
                tulisan.text = listInfo.infoSerigala[info];

            }
            else if (Controller.nameObject == "jerapah")
            {
                tulisan.text = listInfo.infoJerapah[info];

            }
            else if (Controller.nameObject == "kura")
            {
                tulisan.text = listInfo.infoKura[info];
            }


        }
        else if (MainMenu.namaScene == "Alphabet")
        {
            int x;
            Int32.TryParse(Controller.nameObject, out x);

        }


        
    }


    public void klikInfo()
    {
        klik = !klik;
        
    }


    public void pindah(bool pindah)
    {
        
        if (pindah)
        {
            info += 1;
        }
        else if (!pindah)
        {
            info -= 1;
        }
    }
    
}
