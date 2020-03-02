using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Death : MonoBehaviour
{
  public AudioSource DeathSound;
    //player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D col){
      if(col.CompareTag("Player")){
        DeathSound.Play();
        col.GetComponent<Renderer>().enabled = false;
        StartCoroutine(Wait());

      }
    }
    IEnumerator Wait(){

      yield return new WaitForSeconds(0.5f);
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      print("YES");
    }
}
