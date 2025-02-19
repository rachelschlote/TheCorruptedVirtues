using UnityEngine;

[System.Serializable]
public class Quest
{
    public bool isActive;

    public string title;
    public string description;
    public int expereinceReward;
    public int goldReward;

    public QuestGoal goal;

    public void Complete()
    {
        isActive = false;
        Debug.Log("Quest Completed!");
    }
}
