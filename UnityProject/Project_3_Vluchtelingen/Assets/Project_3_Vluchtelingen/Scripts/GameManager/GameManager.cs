using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    [Header("AI Settings:")]

    [Tooltip("This defines the speed the NPC rotates at.")]
    [Range(0, 10f)]
    public float npcRotationSpeed = 5;

    [Tooltip("This is the movement speed of this NPC.")]
    [Range(0, 50f)]
    public float npcWalkingSpeed = 5;

    [Tooltip("This is the max amount of seconds the NPC will wait after collision with the Player.")]
    [Range(0, 5f)]
    public float npcWalkingTimerMaximum = 2;

    [Tooltip("The NPC will follow this specific GameObject.")]
    public GameObject target;

    [Header("Player Settings:")]

    [Tooltip("This is the Position of the Player.")]
    public Transform playerPositionAndRotation;

}
