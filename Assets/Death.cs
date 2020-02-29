using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Death : MonoBehaviour
{
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      }
    }
}
