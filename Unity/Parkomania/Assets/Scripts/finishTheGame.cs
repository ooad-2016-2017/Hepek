using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class finishTheGame : MonoBehaviour {

    public Canvas finishMenu;
    public Button restartText;
    public AudioSource asource;

    void Start()
    {
        finishMenu = finishMenu.GetComponent<Canvas>();
        restartText = restartText.GetComponent<Button>();
        asource = asource.GetComponent<AudioSource>();
        finishMenu.enabled = false;
        asource.Pause();
    }

    // Update is called once per frame
    void Update () {
		if (transform.position.x > 87 && transform.position.x < 89 &&
            transform.position.z > 62 && transform.position.z < 65)
        {
            Time.timeScale = 0;
            asource.Play();
            finishMenu.enabled = true;   
        }
	}
    public void RestartLevel()
    {
        asource.Pause();
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
        finishMenu.enabled = false;
    }
}
