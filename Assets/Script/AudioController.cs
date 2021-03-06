﻿
using UnityEngine;
using System;


[RequireComponent(typeof(AudioSource))]
public class AudioController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    AudioClip FoundTracking;

    [SerializeField]
    AudioClip LostTracking;

    AudioSource audioSource;
   public soundData listSuara;


    

    void Start()
    {
        audioSource = GetComponent<AudioSource>();    
    }
    private void Update()
    {
        Debug.Log(MainMenu.namaScene);
        if(Controller.track == false)
        {
            audioSource.Stop();
        }
    }


    public void playFoundTracking()
    {
        audioSource.PlayOneShot(FoundTracking);
    }

    public void playLostTracking()
    {
        audioSource.PlayOneShot(LostTracking);
    }



    //button audio 
    public void playAlphabet()
    {
            int x;
            Int32.TryParse(Controller.nameObject, out x);

            audioSource.PlayOneShot(listSuara.suara[x]);
    }



    public void playAnimal()
    {
        if (Controller.nameObject == "serigala")
        {
            audioSource.PlayOneShot(listSuara.suara[0]);
        }
        else if (Controller.nameObject == "jerapah")
        {
            audioSource.PlayOneShot(listSuara.suara[1]);
        }
        else if (Controller.nameObject == "kura")
        {
            audioSource.PlayOneShot(listSuara.suara[2]);
        }
    }
}