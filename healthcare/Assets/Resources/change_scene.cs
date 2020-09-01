using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_scene : MonoBehaviour
{
    public void changemenuscene(string scenename)
    {
        Application.LoadLevel(scenename);
    }
}
