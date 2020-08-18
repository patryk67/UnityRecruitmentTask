using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class PlayRandomSound : MonoBehaviour
{
    AudioSource audioSource;
    AudioClip[] randomSounds;
    int randomSoundID;
    List<int> numbersToChooseFrom;

    public Toggle toggle1;
    public Toggle toggle2;
    public Toggle toggle3;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        randomSounds = Resources.LoadAll<AudioClip>("Sounds");
    }

    public void PlaySound()
    {
        numbersToChooseFrom = new List<int>(new int[] {0, 1, 2});

        if (!toggle1.isOn) { numbersToChooseFrom.Remove(0); }
        if (!toggle2.isOn) { numbersToChooseFrom.Remove(1); }
        if (!toggle3.isOn) { numbersToChooseFrom.Remove(2); }

        if (numbersToChooseFrom.Any())
        {
            randomSoundID = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];

            Debug.Log("\"Play Random Sound\" button has been pressed \n Playing sound with ID: " + (randomSoundID+1));
            audioSource.PlayOneShot(randomSounds[randomSoundID]);
        }
        else
        {
            Debug.Log("There're no sounds to play");
        }
    }
}
