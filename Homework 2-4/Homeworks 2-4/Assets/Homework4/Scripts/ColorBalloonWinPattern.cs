using System.Collections.Generic;
using UnityEngine;

public class ColorBalloonWinPattern : IPlayMode
{
    private int _countGreenBalloons;
    private int _countRedBalloons;
    private int _countBlueBalloons;
    private int _countBrokenGreenBalloons;
    private int _countBrokenRedBalloons;
    private int _countBrokenBlueBalloons;

    public void Init(List<Balloon> balloons)
    {
        foreach (Balloon balloon in balloons)
        {
            balloon.BreakBalloon += OnBreakBalloon;
            if (balloon.Color == Balloon.Colors.Red) _countRedBalloons++;
            else if (balloon.Color == Balloon.Colors.Green) _countGreenBalloons++;
            else if (balloon.Color == Balloon.Colors.Blue) _countBlueBalloons++;
        }
    }
    public void OnBreakBalloon(Balloon.Colors color)
    {
        if (color == Balloon.Colors.Blue) _countBrokenBlueBalloons++;
        else if (color == Balloon.Colors.Green) _countBrokenGreenBalloons++;
        else if (color == Balloon.Colors.Red) _countBrokenRedBalloons++;
        if (_countBrokenBlueBalloons == _countBlueBalloons ||
            _countBrokenGreenBalloons == _countGreenBalloons ||
            _countBrokenRedBalloons == _countRedBalloons) Win();
    }

    public void Win()
    {
        Debug.Log("Win");
    }
}
