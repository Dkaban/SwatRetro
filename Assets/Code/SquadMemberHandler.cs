using System.Collections.Generic;
using UnityEngine;

public class SquadMemberHandler : MonoBehaviour
{
    public List<GameObject> SquadMemberList;
    public int SelectedSquadMemberIndex = 0;

    #region Singleton Setup
    public static SquadMemberHandler Instance { get; private set; }
    void Awake()
    {
        Instance = this;
    }
    #endregion

    public void MoveSquadMember(Vector3 targetPosition)
    {
        SquadMemberList[SelectedSquadMemberIndex].GetComponent<SquadMember>().SetTargetPosition(targetPosition);
    }
}
