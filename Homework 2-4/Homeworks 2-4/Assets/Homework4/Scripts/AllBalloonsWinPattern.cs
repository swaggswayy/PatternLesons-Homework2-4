using System.Collections.Generic;
using UnityEngine;

public class AllBalloonsWinPattern : IPlayMode
{
    private int _countBrokenBalloons;
    private int _countBalloonsForWin;

    public void Init(List<Balloon> balloons)
    {
        foreach (Balloon balloon in balloons)
            balloon.BreakBalloon += OnBreakBalloon;
        _countBalloonsForWin = balloons.Count;
    }

    public void OnBreakBalloon(Balloon.Colors color)
    {
        _countBrokenBalloons++;
        if (_countBrokenBalloons == _countBalloonsForWin) Win();
    }

    public void Win()
    {
        Debug.Log("Win");
    }
}
