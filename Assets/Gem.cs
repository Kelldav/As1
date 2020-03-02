using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
  public AudioSource Collect;
public int gemValue = 1;
  void Start(){}
  void Update(){}

  private void OnTriggerEnter2D(Collider2D other){
    if(other.gameObject.CompareTag("Player")){
      Collect.Play();
      ScoreKeeper.instance.ChangeScore(gemValue);

    }
  }
}
