using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControllerScript : MonoBehaviour
{
    public void ChangeSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        FindObjectOfType<AudioManagerScript>().PlayAudio("menuClick");
    }
}
