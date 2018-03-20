using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    /// <summary>
    /// Different Scene integers are found in the build setting, under build and run setting. then open the a new scene and it would generate a new integer
    /// </summary>
    /// <param name="ChangingScene"></param>
    public void Changescene (int ChangingScene) //calling the int for the scene
    {
        SceneManager.LoadScene(ChangingScene); //changing the scene from one another
    }
	
}
