using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameEvents
{
    public static Action<float> InputedShootHook;
    public static Action InputedJump;
    public static Action<int> AvailableHooksChanged;
    public static Action<bool> OnSlopeChanged;
}
