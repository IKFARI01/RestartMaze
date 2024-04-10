using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class GroundTrigger : MonoBehaviour
{
    [SerializeField] GameObject WinText;
    private void OnTriggerEnter(Collider other)
    {
        WinText.SetActive(true);
    }

}
