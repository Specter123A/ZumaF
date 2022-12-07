using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public TMP_Text scoreText;
    

    int score=0;
    


    public void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text ="Score:   " + score.ToString(); 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPoint()
    {
        score+=5;
        scoreText.text = "Score:   " + score.ToString(); 
    }

}
