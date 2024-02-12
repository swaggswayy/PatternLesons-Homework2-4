using System.Collections.Generic;
using UnityEngine;

public class ModeManager : MonoBehaviour
{
    [SerializeField] private List<Balloon> _balloons;
    private IPlayMode _playMode;

    public void AllBalloonsMode()
    {
        if (_playMode != null) return;
        _playMode = new AllBalloonsWinPattern();
        _playMode.Init(_balloons);
    }

    public void ColorBalloonsMode()
    {
        if(_playMode != null) return;
        _playMode = new ColorBalloonWinPattern();
        _playMode.Init(_balloons);
    }
}
