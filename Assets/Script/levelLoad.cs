using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelLoad : MonoBehaviour
{
    public Slider slider;
    float currentTime = 0f;
    public Text textProggres;
   public void LoadLevel(int sceneIndex)
    {
        //StartCoroutine(LoadAsync(sceneIndex));
    }


    void Update()
    {
        

        currentTime += 1 * Time.deltaTime;
        //float progres = Mathf.Clamp01(operation.progress / .9f + currentTime);

        float progres = Mathf.Clamp01((int)currentTime / 10f);
        //currentTime -= 1 * Time.deltaTime;
        //float progres -= 
      
        slider.value = progres;
        textProggres.text = progres * 100 + "%";
        if (currentTime >= 10f)
        {
            SceneManager.LoadScene("Demo_scene");
            //Debug.Log("berhasil");
            //AsyncOperation operation = SceneManager.LoadSceneAsync(1);
            //if (!operation.isDone)
            //{

            //    float prog = Mathf.Clamp01(operation.progress / .9f);
            //    slider.value = progres;
            //    textProggres.text = progres * 100f + "%";

            //}
        }

    }

}
