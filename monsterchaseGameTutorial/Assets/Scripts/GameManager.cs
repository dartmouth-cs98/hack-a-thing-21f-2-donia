using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance; 

    [SerializeField]
    private GameObject[] characters; 

    private int _charIndex; 
    public int CharIndex 
    {
        get { return _charIndex; }
        set { _charIndex = value; }
    }

    public void testFunc()
    {
        Debug.Log("test func!");
    }

    private void Awake()
    {
        if (instance == null) {
            instance = null; 
            DontDestroyOnLoad(gameObject); 
        } else {
            Destroy(gameObject); 
        }
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnLevelFinishedLoading; 
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnLevelFinishedLoading; 
    }

    void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Gameplay") {
            // Debug.Log("player in level loading " + CharIndex);
            Instantiate(characters[CharIndex]);
        }
    }


}
