using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectChapter : MonoBehaviour
{
   
    public void SceneSwitcher(){

        SceneManager.LoadScene(2); //Scene 2 refers to the Chapter Select Scene

    }
}
