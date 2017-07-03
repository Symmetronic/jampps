using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviourScript : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D rigid;
    public Animator anim;
    ScoreController scoreController;

    // Use this for initialization
    void Start()
    {
        scoreController = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreController>();
        int i = 1;

        if (scoreController.SolvedLightMinigame1() && scoreController.SolvedWaterMinigame1())
        {

        }
        else
        {
            if (scoreController.SolvedLightMinigame1())
            {
                player.transform.Translate((float)-5.2, -4, 0);
                GameObject.FindGameObjectWithTag("MainCamera").transform.Translate((float)-5.2, (float)-4, 0);

            }
            else
            {
                if (scoreController.SolvedWaterMinigame1())
                {
                    player.transform.Translate((float)-7.312, (float)1, 0);
                    GameObject.FindGameObjectWithTag("MainCamera").transform.Translate((float)-7.334, (float)1, 0);
                }
            }
        }

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
        if (Input.GetKey(KeyCode.UpArrow))
        {
            reset();
            //     player.transform.Translate(0, (float)0.06, 0);
       
            rigid.velocity = new Vector2(0, 3);
            anim.SetBool("run_up", true);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            reset();
            //  player.transform.Translate((float)-0.06, 0, 0);
            rigid.velocity = new Vector2(-3, 0);
            anim.SetBool("run_left", true);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            reset();
            //player.transform.Translate(0, (float)-0.06, 0);
            rigid.velocity = new Vector2(0, -3);

            anim.SetBool("run_down", true);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            reset();
            //  player.transform.Translate((float)0.06, 0, 0);
            rigid.velocity = new Vector2(3, 0);

            anim.SetBool("run_right", true);
        }

        if(!Input.GetKey(KeyCode.UpArrow)&& !Input.GetKey(KeyCode.LeftArrow)&&!Input.GetKey(KeyCode.DownArrow)&&!Input.GetKey(KeyCode.RightArrow))
        {
            rigid.velocity = new Vector2(0, 0);


            reset();

        }
    }

}
 

