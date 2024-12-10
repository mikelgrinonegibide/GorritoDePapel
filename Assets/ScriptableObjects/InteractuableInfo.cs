using UnityEngine;

public enum ActionTypes
{
    Look,
    Use,
    Go
}

[CreateAssetMenu(menuName = "Interactuable Item/Basic")]
public class InteractuableInfo : ScriptableObject
{
    public string Name;
    public ActionTypes Action;

}