using UnityEngine;

public class SFX : MonoBehaviour
{
    public AudioClip sfxClip;  
    public float volume = 1f;    
    private AudioSource sfxSource;

    void Start()
    {
       
        GameObject sfxPlayer = new GameObject("2D_SFX_Player_" + gameObject.name);
        sfxPlayer.transform.parent = this.transform;

        sfxSource = sfxPlayer.AddComponent<AudioSource>();
        sfxSource.playOnAwake = false;
        sfxSource.loop = false;

       
        sfxSource.spatialBlend = 0f; 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            sfxSource.PlayOneShot(sfxClip, volume);
            Debug.Log("Played 2D SFX from " + gameObject.name);
        }
    }
}
