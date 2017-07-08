using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviourScript : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D rigid;
    public Animator anim;
    ScoreController scoreController;
    GameObject maincamera;

    // Use this for initialization
    void Start()
    {
        scoreController = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreController>();
        maincamera = GameObject.FindGameObjectWithTag("MainCamera");
        maincamera.transform.Translate(0, 0, -10);

        
        // Chapter 1
        if (scoreController.SolvedLightMinigame1() && scoreController.SolvedWaterMinigame1())
        {

        }
        else
        {
            if (scoreController.SolvedLightMinigame1())
            {
                player.transform.Translate((float)-5.2, -4, 0);
                maincamera.transform.Translate((float)-5.2, (float)-4, 0);
                GameObject.FindGameObjectWithTag("Attention_Light1").SetActive(false);

            }
            else
            {
                if (scoreController.SolvedWaterMinigame1())
                {
                    player.transform.Translate((float)-7.312, (float)1, 0);
                    maincamera.transform.Translate((float)-7.334, (float)1, 0);
                    GameObject.FindGameObjectWithTag("Attention_Water1").SetActive(false);
                }
            }
        }
        
        

        // Scene after Snake
        if (scoreController.SolvedSnakeMinigame() && !scoreController.GetEnteredHouse())
        {
            player.transform.position = new Vector3((float)-1.67, (float)3.63, 0);
            maincamera.transform.position = new Vector3((float)-1.67, (float)3.63, -10);
            GameObject.FindGameObjectWithTag("wind_turbine").GetComponent<Animator>().enabled = true;
            GameObject.FindGameObjectWithTag("Attention_Snake").SetActive(false);

        }
        else
        {

            if (scoreController.SolvedWaterMinigame2() && scoreController.GetBike())
            {
                player.transform.position = new Vector3(14, (float)4.6, 0);
                maincamera.transform.position = new Vector3(14, (float)4.6, -10);
            }
        }

        // Rückfahrt
        if (scoreController.SolvedWaterMinigame2() && !scoreController.GetBike())
        {
            player.transform.Translate((float)7.6, (float)-0.5, 0);
            maincamera.transform.Translate((float)7.6, (float)3.4, 0);
            scoreController.SetBike(true);
        }

        if (scoreController.GetEnteredHouse())
        {
            player.transform.position = new Vector3(0, (float)-3.6, 0);
            maincamera.transform.position = new Vector3(0, (float)-3.6, -10);
        }
        if (scoreController.GetAteDinner())
        {
            player.transform.position = new Vector3(-4, (float)2.2, 0);
            maincamera.transform.position = new Vector3(-4, (float)2.2, -10);
            GameObject.FindGameObjectWithTag("Attention_Light2").SetActive(true);
        }
        if (scoreController.SolvedLightMinigame2())
        {
            player.transform.position = new Vector3((float)4.2, (float)1.5, 0);
            maincamera.transform.position = new Vector3((float)4.2, (float)1.5, -10);
            GameObject.FindGameObjectWithTag("Attention_Light2").SetActive(false);
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
 

