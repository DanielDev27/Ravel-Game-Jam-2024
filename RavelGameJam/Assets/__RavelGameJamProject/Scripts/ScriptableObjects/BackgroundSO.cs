using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BackgroundSO", menuName = "RavelGameJam/BackgroundSO", order = 0)]
public class BackgroundSO : ScriptableObject
{
    [SerializeField] public Scene scene;
    [SerializeField] public string backgroundName;
    [SerializeField] public Sprite[] backgroundArt;
    [SerializeField] private AudioSource environmentAmbience;
}

public enum Scene
{
    Scene1,
    Scene2,
    Scene3,
    Scene4,
    Scene5,
    Scene6,
    Scene7,
    Scene8,
    Scene9,
    Epilogue,
}
