using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Audio;

public class Fairy : MonoBehaviour
{
    private void OnEnable()
    {
        //speed up audio
        AudioManager.Instance.SetPitch("Song", 1.2f);
    }

}
