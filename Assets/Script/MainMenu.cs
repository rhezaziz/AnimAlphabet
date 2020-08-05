using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public static string namaScene;
    public Animator serigala, jerapah;


    private void Awake()
    {
        namaScene = "menu";
    }


    private void Update()
    {
        if(namaScene == "menu")
        {
            jerapah.SetBool("Menu", true);
            serigala.SetBool("Menu", true);
        }
    }
    //button klik untuk pindah scene
    public void Play(string nama){
        namaScene = nama;
        SceneManager.LoadScene("Loading");
    }


    public void keluar()
    {
        Application.Quit();
    }
    
}
