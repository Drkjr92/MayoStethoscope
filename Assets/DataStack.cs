using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataStack : MonoBehaviour
{

    /*THIS CLASS WILL CONSIST OF ALL GAMEOBJECTS AND AUDIO FILES
    CAN USE THIS CLASS TO SEARCH AND SET AUDIO TO GAMEOBJECTS*/

    AudioClip[] audioList;
    GameObject[] bodyObjects;


    // Start is called before the first frame update
    void Start()
    {
        //gets all audio files in Resources/Audio folder
        audioList = Resources.LoadAll<AudioClip>("Audio/");

        //gets all GameObjects in scene
        bodyObjects = GameObject.FindGameObjectsWithTag("Bodypart");
        foreach(GameObject gos in bodyObjects)
        {
            Debug.Log(gos.name);
        }

    }






    // Update is called once per frame
    void Update()
    {
        
    }
}
