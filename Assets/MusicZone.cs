using UnityEngine;

public class MusicZone : MonoBehaviour

    public AudioSource musicSource;

    private void OnTriggerEnter(Collider other)
    
        if (other.CompareTag("Player"))
        {
            musicSource.Pause(); 
            Debug.Log("Music paused.");
        }
    }

    private void OnTriggerExit(Collider other)
    
        if (other.CompareTag("Player"))
        {
            musicSource.UnPause(); 
            Debug.Log("Music unpaused.");
        }
    }
}

