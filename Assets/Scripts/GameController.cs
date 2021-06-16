using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameController
{
    public static bool CarOnTheRoad { set; get; } = false;

    public static bool DriftEnter { get; set; } = false;
    public static bool GameIsOver { get; set; } = false;
    public static float Score { get; set; } = 0;
}
