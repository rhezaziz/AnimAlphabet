using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tentang : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject scrollBar;
    float scroll_pos = 0;
    float[] pos;
    public GameObject btn1, btn2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = new float[transform.childCount];
        float distance = 1f / (pos.Length - 1f);

        for(int i = 0; i < pos.Length; i++)
        {
            pos[i] = distance * i;
        }

        if (Input.GetMouseButton(0))
        {
            scroll_pos = scrollBar.GetComponent<Scrollbar>().value;
        }
        else
        {
            for (int i = 0; i < pos.Length; i++)
            {
                if(scroll_pos < pos[i]+ (distance / 2) && scroll_pos > pos[i] - (distance/2)){
                    scrollBar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollBar.GetComponent<Scrollbar>().value, pos[i], 0.15f);
                }
            }
        }

        if(scroll_pos < 0.5)
        {
            btn1.SetActive(true);
            btn2.SetActive(false);
        }else if(scroll_pos >= 0.5f)
        {
            btn1.SetActive(false);
            btn2.SetActive(true);
        }
    }


    private void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MainMenu.namaScene = "menu";
            SceneManager.LoadScene("Loading");
        }
    }
}
