using UnityEngine;

public class MusicZone : MonoBehaviour
{
    public AudioSource musicSource;
    private bool isPlaying = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (isPlaying)
            {
             
                musicSource.Pause();
                Debug.Log("Music paused.");
                isPlaying = false;
            }
            else
            {
               
                musicSource.UnPause();
                if (!musicSource.isPlaying)
                    musicSource.Play(); 
                Debug.Log("Music playing.");
                isPlaying = true;
            }
        }
    }
}