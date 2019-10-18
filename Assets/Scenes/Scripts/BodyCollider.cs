using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*   trying to find methods where this Script can make itself unique. 
     that way I won't need to hard code each sound and body location.
     code one place, Let it be usuable & scalable ^ . ^       */


public class BodyCollider : MonoBehaviour
{
    /************************ DECLARATIONS **************************************************/
    public AudioClip sound;
    public string soundContainer;
    //returns Audiosource component of the GameObject
    private AudioSource source { get { return GetComponent<AudioSource>(); } }



    /**************************************************************************************/


    private void Start()
    { 
    
        gameObject.AddComponent<AudioSource>();
        sound = gameObject.GetComponent<DataStack>().SetAudio(soundContainer);
        source.clip = sound;
        source.playOnAwake = false;

    }


 
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Construct a ray from the current touch coordinates
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("Hit detected");
                PlaySound(sound);
            }
        }
     }



    void PlaySound(AudioClip youHealthyBro)
    {
        source.PlayOneShot(youHealthyBro);
    }



}


