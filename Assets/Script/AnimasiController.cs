using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Quarternion;

public class AnimasiController : MonoBehaviour
{
    // Start is called before the first frame update

    Animator anim;
    public static int i;
    Transform DObject;

    void Update()
    {
        if (DefaultTrackableEventHandler.nameObject == "jerapah") { 
            DObject = GameObject.Find("Giraffe").GetComponent<Transform>();
            anim = GameObject.Find("Giraffe").GetComponent<Animator>();
    }
        else if (DefaultTrackableEventHandler.nameObject == "serigala") { 
            DObject = GameObject.Find("Wolf").GetComponent<Transform>();
            anim = GameObject.Find("Wolf").GetComponent<Animator>();
    }
        else if (DefaultTrackableEventHandler.nameObject == "kura") {
            DObject = GameObject.Find("Turtle").GetComponent<Transform>();
            anim = GameObject.Find("Turtle").GetComponent<Animator>();
        }
    }

    private void FixedUpdate()
    {
        

        switch (i)
        {
            case 1:
                anim.SetBool("Idle", true);
                anim.SetBool("Walk", false);
                //anim.SetBool("Jump", false);
                break;

            case 2:
                anim.SetBool("Walk", true);
                //anim.SetBool("Idle", false);
                anim.SetBool("Jump", false);
                break;

            case 3:
                anim.SetBool("Jump", true);
                //anim.SetBool("Walk", false);
                anim.SetBool("Idle", false);
                break;

        }
    }

    public void nextAnimation()
    {
        if(i == 3)
        {
            i = 1;
        }
        else
        {
            i++;
        }
    }

    public void prevAnimation()
    {
        if(i == 1)
        {
            i = 3;
        }
        else
        {
            i--;
        }
        
    }

    public void rotate(string arah)
    {
        float x = 20f, y = 20f , z = 20f ;
        if(arah == "kanan")
        {
            //int i = 20;
            DObject.transform.Rotate(-90 + x, 0f + y, 0f + z , Space.Self) ; 
        }
    }
}
