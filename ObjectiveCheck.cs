using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveCheck : MonoBehaviour
{
    public TimeCountdown _timeC;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _timeC.Score(1);
            Destroy(this.gameObject);
        }
    }
}
