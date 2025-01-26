using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "OneOffAudioData", menuName = "Scriptable Objects/OneOffAudioData")]
public class OneOffAudioData : ScriptableObject
{
    [SerializeField]
    List<AudioClip> audioClips;

    [SerializeField]
    Vector2 volumeRange;

    [SerializeField]
    Vector2 pitchRange;

    public void RandomizeSource(AudioSource source)
    {
        source.clip = audioClips.GetRandom();
        source.volume = volumeRange.Random();
        source.pitch = pitchRange.Random();
    }
}
