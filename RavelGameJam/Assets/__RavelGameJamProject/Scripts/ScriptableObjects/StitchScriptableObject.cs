using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "StitchScriptableObject", menuName = "RavelGameJam/StitchSO", order = 0)]
public class StitchScriptableObject : ScriptableObject
{
    // Start is called before the first frame update
    public StitchTypes stitchType;
    public string stitchName;//name of the Scriptable object
    public Sprite stitchUI;//sprite of the scriptable object 
}

public enum StitchTypes//ENumerator of Items class
{
    //Fill in Knitting objects
    RedStitch,
    WhiteStitch,
    Blank
}
