using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    public Slider slider;
    public Text textProggres;

    void Start()
    {
        if (MainMenu.namaScene == "Alphabet")
        {
            StartCoroutine(LoadAsync(3));
        }
        else if (MainMenu.namaScene == "Animal")
        {
            StartCoroutine(LoadAsync(4));
        }
        else if(MainMenu.namaScene == "tentang")
        {
            StartCoroutine(LoadAsync(5));
        }

        else if(MainMenu.namaScene == "menu")
        {
            StartCoroutine(LoadAsync(1));
        }
    }


    IEnumerator LoadAsync(int index)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(index);

        while (!operation.isDone)
        {
            float progres = Mathf.Clamp01((int)operation.progress / .9f);
            slider.value = progres;
            textProggres.text = progres * 100f + "%";

            yield return null;
        }


    }
}
