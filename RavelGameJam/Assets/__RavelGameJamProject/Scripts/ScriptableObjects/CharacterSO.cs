using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterSO", menuName = "RavelGameJam/CharacterSO", order = 0)]
public class CharacterSO : ScriptableObject
{
    [SerializeField] public Character characterEnum;
    [SerializeField] public CharacterType characterType;
    [SerializeField] public string characterName;
    [SerializeField] public Sprite characterArt;
}

public enum Character
{
    Alice,
    MadelieneAlice,
    Officer,
    Lady,
    Mildred,
    MissAtkins,
    Conductor,
    Target,
}

public enum CharacterType
{
    Main,
    Secondary,
}

