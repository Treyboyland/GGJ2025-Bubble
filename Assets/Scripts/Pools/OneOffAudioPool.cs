using UnityEngine;

public class OneOffAudioPool : ObjectPool<OneOffAudio>
{
    public void PlayAudio(OneOffAudioData audioData)
    {
        var audio = GetObject();
        audioData.RandomizeSource(audio.AudioSource);
        audio.gameObject.SetActive(true);
    }
}
