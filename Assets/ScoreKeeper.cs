using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    // Start is called before the first frame update
    public static ScoreKeeper instance;
    public TextMeshProUGUI text;
    int score=0;
    void Start()
    {
      if(instance == null){
        instance=this;
        print("bing");
      }
    }
    public void ChangeScore(int gemValue){
      score+=gemValue;
      text.text = "x"+score.ToString();
      if(score >= 60){
        text.text = "x"+score.ToString()+ "  YOU WIN!!!!";
      }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
