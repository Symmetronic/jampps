using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviourScript : MonoBehaviour
{
    public GameObject player;
    public Animator anim;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void reset()
    {
        anim.SetBool("run_up", false);
        anim.SetBool("run_down", false);
        anim.SetBool("run_left", false);
        anim.SetBool("run_right", false);
        anim.SetBool("idle_down", false);
        anim.SetBool("idle_up", false);
        anim.SetBool("idle_left", false);
        anim.SetBool("idle_right", false);
    }
    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKey(""))
        if (Input.GetKey("w"))
        {
            reset();
            player.transform.Translate(0, (float)0.1, 0);
            System.Threading.Thread.Sleep(20);
            anim.SetBool("run_up", true);
        }
        if (Input.GetKey("a"))
        {
            reset();
            anim.SetBool("run_up", false);
            player.transform.Translate((float)-0.1, 0, 0);
            System.Threading.Thread.Sleep(20);
            anim.SetBool("run_left", true);
        }
        if (Input.GetKey("s"))
        {
            reset();
            player.transform.Translate(0, (float)-0.1, 0);
            System.Threading.Thread.Sleep(20);
            anim.SetBool("run_down", true);
        }
        if (Input.GetKey("d"))
        {
            reset();
            player.transform.Translate((float)0.1, 0, 0);
            System.Threading.Thread.Sleep(20);
            anim.SetBool("run_right", true);
        }

        if(!Input.GetKey("w")&& !Input.GetKey("a")&&!Input.GetKey("s")&&!Input.GetKey("d"))
        {
            reset();

        }
    }

}
 

