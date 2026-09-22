using System;
using Unity.VisualScripting;
using UnityEngine;

public class BasePlatform : MonoBehaviour
{
    private BoxCollider col;
    private void OnTriggerEnter(Collider other)
    {
        ScoringManager.SINGLETON.playerSpeed = 0;
        ScoringManager.SINGLETON.IncreaseScore(1);
        ScoringManager.SINGLETON.currentPlatform = gameObject;
    }
}
