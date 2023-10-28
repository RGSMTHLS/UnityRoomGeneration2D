using UnityEngine;

public class Room : MonoBehaviour
{
    [SerializeField] GameObject topDoor;
    [SerializeField] GameObject bottomDoor;
    [SerializeField] GameObject leftDoor;
    [SerializeField] GameObject rightDoor;

    private bool isTopDoorOpen = false;
    private bool isBottomDoorOpen = false;
    private bool isLeftDoorOpen = false;
    private bool isRightDoorOpen = false;

    public Vector2Int RoomIndex { get; set; }

    public void OpenDoor(Vector2Int direction)
    {
        if (direction == Vector2Int.up)
        {
            topDoor.SetActive(true);
            isTopDoorOpen = true;
        }
        if (direction == Vector2Int.down)
        {
            bottomDoor.SetActive(true);
            isBottomDoorOpen = true;
        }
        if (direction == Vector2Int.left)
        {
            leftDoor.SetActive(true);
            isLeftDoorOpen = true;
        }
        if (direction == Vector2Int.right)
        {
            rightDoor.SetActive(true);
            isRightDoorOpen = true;
        }
    }

    internal bool IsDoorOpen(Vector2Int direction)
    {
        if (direction == Vector2Int.up)
        {
            return isTopDoorOpen;
        }
        else if (direction == Vector2Int.down)
        {
            return isBottomDoorOpen;
        }
        else if (direction == Vector2Int.left)
        {
            return isLeftDoorOpen;
        }
        else if (direction == Vector2Int.right)
        {
            return isRightDoorOpen;
        }
        return false;
    }
}
