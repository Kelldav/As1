using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreKeeper : MonoBehaviour
{
    // Start is called before the first frame update
    public static ScoreKeeper instance;
    public TextMeshProUGUI text;
    public int score=0;
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
      if(score >= 39){
        text.text = "x"+score.ToString()+ "  YOU WIN!!!!";
        StartCoroutine(TimerCoroutine());
        score=0;
        text.text = "x"+score.ToString();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
      }
    }
    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator TimerCoroutine()
{
    //Print the time of when the function is first called.
    Debug.Log("Started Coroutine at timestamp : " + Time.time);

    //yield on a new YieldInstruction that waits for 5 seconds.
    yield return new WaitForSeconds(5);

    //After we have waited 5 seconds print the time again.
    Debug.Log("Finished Coroutine at timestamp : " + Time.time);
}
}
