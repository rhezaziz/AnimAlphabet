using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class infoController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panelInfo;

    bool klik;
    public Text tulisan;

    public information listInfo;
    
    // Update is called once per frame
    void Update()
    {
        if (klik)
        {
            panelInfo.SetActive(true);
        }else if (!klik)
        {
            panelInfo.SetActive(false);
        }
    }


    public void klikInfo()
    {
        klik = !klik;
        if (MainMenu.namaScene == "Animal") {
            Debug.Log("Info Animal");
            if (DefaultTrackableEventHandler.nameObject == "serigala")
            {
                //cek 
                if (AnimasiController.i == 1)
                    tulisan.text = listInfo.infoSerigala[0];

                else if(AnimasiController.i == 2)
                    tulisan.text = listInfo.infoSerigala[1];

                else if(AnimasiController.i == 3)
                    tulisan.text = listInfo.infoSerigala[2];


            }
            else if (DefaultTrackableEventHandler.nameObject == "jerapah")
            {
                if(AnimasiController.i == 1)
                    tulisan.text = listInfo.infoJerapah[0];

                else if(AnimasiController.i == 2)
                    tulisan.text = listInfo.infoJerapah[1];

                else if(AnimasiController.i == 3)
                    tulisan.text = listInfo.infoJerapah[2];


            }
            else if (DefaultTrackableEventHandler.nameObject == "kura")
            {
                if(AnimasiController.i == 1)
                    tulisan.text = listInfo.infoKura[0];

                else if(AnimasiController.i == 2)
                    tulisan.text = listInfo.infoKura[1];

                else if(AnimasiController.i == 3)
                    tulisan.text = listInfo.infoKura[2];
            }


        }else if (MainMenu.namaScene == "Alphabet")
            {
            Debug.Log("Info Alphabet");
                int x;
                Int32.TryParse(DefaultTrackableEventHandler.nameObject, out x);

            }
    }
    
}
