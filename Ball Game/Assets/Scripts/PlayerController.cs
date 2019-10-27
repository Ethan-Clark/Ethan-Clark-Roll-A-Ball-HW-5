using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public Text countText;
    public float speed;
    public Text WinText;
    private Rigidbody rb;
    private int count;
    float m = BallSpeedSlider.speed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        count = 0;

        SetcountText();
        WinText.text = "";
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal * m, 0.0f, moveVertical * m);

        rb.AddForce(movement * speed);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetcountText();
            if (count >= 8)
            {
                WinText.text = "You Win!";
            }
        }
    }
    void SetcountText()
    {
        countText.text = "Count: " + count.ToString();
    }

}








