using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatforms : MonoBehaviour
{
    public Vector3 startPosition;
    public Vector3 finishPosition;

    public float duration = 9.0f;
    public float platformDelay = 2.0f;

    public enum PlatformState
    {
        Start, End, Active, Reverse
    };
    public PlatformState platformState = PlatformState.Start;


    void Start()
    {
        startPosition = transform.position;
    }


    void LateUpdate()
    {
        switch (platformState)
        {
            case PlatformState.Start:
                StartCoroutine("ActivatePlatform");
                break;
            case PlatformState.End:
                StartCoroutine("ReversePlatform");
                break;
        }
    }


    IEnumerator ActivatePlatform()
    {
        
        platformState = PlatformState.Active;

        float timeElasped = 0f;

        while (timeElasped < duration)
        {
            transform.position = Vector3.Lerp(startPosition, finishPosition, timeElasped / duration);
            timeElasped += Time.deltaTime;

            yield return null;
        }
        transform.position = finishPosition;
        platformState = PlatformState.End;
    }



    IEnumerator ReversePlatform()
    {
        

        platformState = PlatformState.Reverse;

        float timeElasped = 0f;

        while (timeElasped < duration)
        {
            transform.position = Vector3.Lerp(finishPosition, startPosition, timeElasped / duration);
            timeElasped += Time.deltaTime;

            yield return null;
        }
        transform.position = startPosition;
        platformState = PlatformState.Start;
    }

}
