using Game.Data;
using System.Collections.Generic;

public interface IPipesSettings
{
    float GetPipesSpeed();
    float GetSecondsIntervalToNextPipe();
    int GetPipesLimit();
    float GetPipesHeightMaxDifference();
    List<PipesData> GetCurrentPipesData();
}