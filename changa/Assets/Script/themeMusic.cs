using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class themeMusic : MonoBehaviour
{
    private void Start()
    {
        Invoke("Play", .5f);
    }
    private void Play()
    {
        FindObjectOfType<AudioManagerCS>().Play("theme");
    }
}
