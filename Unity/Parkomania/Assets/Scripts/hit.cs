using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class hit : MonoBehaviour {

    public Canvas hitMenu;
    public Button restartText;
    public Button backText;

    // Use this for initialization
    void Start()
    {
        hitMenu = hitMenu.GetComponent<Canvas>();
        restartText = restartText.GetComponent<Button>();
        backText = backText.GetComponent<Button>();
        hitMenu.enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
        hitMenu.enabled = true;
        Time.timeScale = 0;
    }
    public void resrtart()
    {
        hitMenu.enabled = false;
        Time.timeScale = 1;
        SceneManager.LoadScene("first");
    }
    public void Back()
    {
        hitMenu.enabled = false;
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
}
