using UnityEngine;

public class SquadMember : MonoBehaviour
{
    private float _moveSpeed = 5.0f;
    private Vector3 _targetPosition;
    void Start()
    {
        _targetPosition = this.transform.position;
    }

    public void SetTargetPosition(Vector3 toPosition)
    {
        Debug.Log("Destination : " + toPosition);
        toPosition.y = 0.5f;
        _targetPosition = toPosition;
    }

    void Update()
    {
        if (Vector3.Distance(this.transform.position, _targetPosition) > 1)
        {
            //Reached destination
            transform.position = Vector3.MoveTowards(this.transform.position, _targetPosition, _moveSpeed * Time.deltaTime);
        }
    }
}
