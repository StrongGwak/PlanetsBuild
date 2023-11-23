using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionManager : MonoBehaviour
{
    public Toggle Mute;
    public Toggle PM;
    public Slider BGV;
    public Slider EV;

    public SoundSetting soundSetting;
    public GameController gameController;

    public AudioSource musicSource;

    public AudioSource effectSound;

    private void OnEnable()
    {
        Mute.onValueChanged.AddListener(delegate { OnBGMToggle(); });
        PM.onValueChanged.AddListener(delegate { OnPMToggle(); });
        BGV.onValueChanged.AddListener(delegate { OnBGVChange(); });
        EV.onValueChanged.AddListener(delegate { OnEVChange(); });
    }

    public void OnBGMToggle()
    {
        musicSource.mute = soundSetting.mute = Mute.isOn;
    }

    public void OnPMToggle()
    {
        gameController.pianomode = PM.isOn;
    }

    public void OnBGVChange()
    {
        musicSource.volume = soundSetting.backgroundvolume = BGV.value;
    }

    public void OnEVChange()
    {
        effectSound.volume = soundSetting.effectvolume = EV.value;
    }
}
