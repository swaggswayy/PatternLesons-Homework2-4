using UnityEngine;
using System.Collections.Generic;
public interface IPlayMode
{
    void Init(List<Balloon> balloons);
    void OnBreakBalloon(Balloon.Colors color);

    void Win();
}
