using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowData : MonoBehaviour
{
  
    public InputField PlayerNameInput;

    public Text rounds;
    public Text ballSpeed;
    public Text objectSpeed;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
     
        rounds.text = "Rounds: " + PlayerPrefs.GetInt("rounds");
        ballSpeed.text = "Ball Speed: " + PlayerPrefs.GetFloat("BallSpeed");
        objectSpeed.text = "Cube Speed: " + PlayerPrefs.GetFloat("SliderValue");

    }
    
}
