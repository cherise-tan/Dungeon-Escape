using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour {

    [SerializeField] GameObject sparkleAnimation;

    float levelLoadDelay = 1.7f;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject player = collision.gameObject;

        GameObject sparkles = Instantiate(sparkleAnimation, transform.position, transform.rotation);
        player.SetActive(false);
        
        StartCoroutine(LoadNextLevel());        
    }
    
    IEnumerator LoadNextLevel()
    {
        yield return new WaitForSecondsRealtime(levelLoadDelay);
        var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }   

}
