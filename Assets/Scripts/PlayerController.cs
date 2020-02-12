using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Rigidbody nemo;
    public float forwardForce = 10f;
    public float sidewaysForce = 10f;
    private int count;
    public Text countText;
    public Text winText;
    public float restartDelay = 3f;

    //how the game starts
    void Start()
    {
        count = 0;
        SetCountText();
        winText.text = "";
    }

    void Update()
    {

        Application.targetFrameRate = 60;


    //when right key is pressed
        if (Input.GetKey("right"))
        {

            nemo.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

        //when left key is pressed
        if (Input.GetKey("left"))
        {

            nemo.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }


        //when up key is pressed
        if (Input.GetKey("up"))
        {

            nemo.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);

        }


        //when down key is pressed
        if (Input.GetKey("down"))
        {

            nemo.AddForce(0, 0, -forwardForce * Time.deltaTime, ForceMode.VelocityChange);

        }
    }


    void OnTriggerEnter(Collider other)
    {

        //when nemo collides with box
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 100;
            SetCountText();
        }


        //when nemo collides with oval
        if (other.gameObject.CompareTag("Pick Up 1"))
        {
            other.gameObject.SetActive(false);
            count = count + 100;
            SetCountText();
        }


        //when nemo hits the bio-hazard cylinder
        if (other.gameObject.CompareTag("Negative"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    //how to keep count
    void SetCountText ()
    {
        countText.text = "Count: " + count.ToString();
        if (count == 1200)
        {
           winText.text = "You win!";

            Invoke("Restart", 2);

        }

    
      
    }

    //retsart when game ends
    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

   
    

}
