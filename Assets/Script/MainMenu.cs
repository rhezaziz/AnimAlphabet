using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public static string namaScene;
    public void Hewan(string nama){
        namaScene = nama;
        SceneManager.LoadScene("Animal");
    }

    public void ABC(string nama){
        namaScene = nama;
        SceneManager.LoadScene("Alphabet");
    }
}
