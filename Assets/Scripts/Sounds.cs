using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioSource pedestalsound;

    public void PlayPedestalSound()
    {
        pedestalsound.Play();
    }
}
