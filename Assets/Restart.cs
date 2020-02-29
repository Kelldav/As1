using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

    public void RestartGame() {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // loads current scene
      print("BING");
    }

}
