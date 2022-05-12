using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class Exit : MonoBehaviour
{
   [YarnCommand("end")]
   public void End()
    {
        SceneManager.LoadScene("WinScreen");
    }
}
