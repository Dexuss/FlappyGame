using Game.Data;
using System.Collections.Generic;

namespace Game.Environment
{
    public interface IPipesSettings
    {
        float GetPipesSpeed();
        float GetSecondsIntervalToNextPipe();
        int GetPipesLimit();
        float GetPipesHeightMaxDifference();
        List<PipesData> GetCurrentPipesData();
    }
}