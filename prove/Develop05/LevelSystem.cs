public class LevelSystem
{
    private Dictionary<int, string> _levelTitles;
    private int[] _levelThresholds;

    public LevelSystem()
    {
        _levelThresholds = new int[] { 0, 1000, 2500, 5000, 10000, 20000 };

        _levelTitles = new Dictionary<int, string>
        {
            { 1, "Novice Quester" },
            { 2, "Apprentice Adventurer" },
            { 3, "Skilled Pathfinder" },
            { 4, "Expert Explorer" },
            { 5, "Master of Quests" }
        };


    }
    public int GetCurrentLevel(int score)
    {
        int level = 1;
        for (int i=1; i< _levelThresholds.Length; i++)
        {
            if (score >= _levelThresholds[i])
            {
                level = i + 1;
            }
            else
            {
                break;
            }
        }
        return level;
    }
    public string GetLevelTitle(int level)
    {
        if (_levelTitles.ContainsKey(level))
        {
            return _levelTitles[level];
        }
        else
        {
            return "Unknown Level";
        }
    }
    public int GetNextLevelThreshold(int score)
    {
        int currentLevel = GetCurrentLevel(score);
        if (currentLevel < _levelThresholds.Length - 1)
        {
            return _levelThresholds[currentLevel];
        }
        else
        {
            return -1; // No next level
        }
    }
    public float GetLevelProgress(int score)
    {
        int currentLevel = GetCurrentLevel(score);
        if (currentLevel < _levelThresholds.Length - 1)
        {
            int currentThreshold = _levelThresholds[currentLevel];
            int nextThreshold = _levelThresholds[currentLevel + 1];
            return (float)(score - currentThreshold) / (nextThreshold - currentThreshold);
        }
        else
        {
            return 1.0f; // Max level reached
        }
    }
}