using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class door : MonoBehaviour {
    [SerializeField] string sceneName;
    [SerializeField] AudioClip stairsSound;


    AudioSource AudioSource;
	// Use this for initialization
	void Start () {
        AudioSource.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        AudioSource.PlayOneShot(stairsSound);
        Invoke("changeLevel",1.0f);
    }


    private void changeLevel()
    {
        SceneManager.LoadScene(sceneName);
    }
}
