using UnityEngine;

public class PruevasAudio : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip AudioP;
    [SerializeField] private AudioClip AudioO;
    [SerializeField] private AudioClip AudioL;
    [SerializeField] private AudioClip AudioK;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            Sound(AudioP);
        }
        else if(Input.GetKeyDown(KeyCode.O))
        {
            Sound(AudioO);
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            Sound(AudioL);
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            Sound(AudioK);
        }
    }


    private void Sound(AudioClip audio)
    {
        audioSource.clip = audio;
        audioSource.Play();
    }
}
