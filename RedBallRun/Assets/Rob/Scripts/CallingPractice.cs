using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallingPractice : MonoBehaviour
{
    public int Hp;

    void Start()
    {
        Hp = GameObject.FindObjectOfType<CallingPracticeTwo>().Health;
    }
}
