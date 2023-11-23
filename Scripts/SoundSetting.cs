using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundSetting : MonoBehaviour
{
    public bool mute;
    public bool pianomode;
    public float backgroundvolume;
    public float effectvolume;

    private void Start()
    {
        pianomode = false;
    }
}
