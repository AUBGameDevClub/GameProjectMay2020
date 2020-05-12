using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_6_4 : MonoBehaviour
{
    enum scenes {MAIN_MENU, SETTINGS, CHAPTER_SELECT, CHAPTER_1, CHAPTER_2, CHAPTER_3, CHAPTER_4, CHAPTER_5, CHAPTER_6, LEVEL_1_1, LEVEL_1_2, LEVEL_1_3, LEVEL_1_4, LEVEL_1_5, LEVEL_2_1, LEVEL_2_2, LEVEL_2_3, LEVEL_2_4, LEVEL_2_5, LEVEL_3_1, LEVEL_3_2, LEVEL_3_3, LEVEL_3_4, LEVEL_3_5, LEVEL_4_1, LEVEL_4_2, LEVEL_4_3, LEVEL_4_4, LEVEL_4_5, LEVEL_5_1, LEVEL_5_2, LEVEL_5_3, LEVEL_5_4, LEVEL_5_5, LEVEL_6_1, LEVEL_6_2, LEVEL_6_3, LEVEL_6_4, LEVEL_6_5,  CREDITS}

    public void SceneSwitcher(){

        SceneManager.LoadScene( (int) scenes.LEVEL_6_4 ); //Move to World 1 Level Select

    }

}
