using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{
   public void EndFade()
    {
        FindObjectOfType<GameManager>().hasGameStarted = true;
    }
}
