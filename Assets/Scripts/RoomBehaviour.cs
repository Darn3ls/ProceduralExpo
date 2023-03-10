using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomBehaviour : MonoBehaviour
{
    public GameObject[] walls; //0-Up, 1-Down, 2-Right, 3-Left
    public GameObject[] doors;
    public bool[] doorStatus;

    // Start is called before the first frame update
    void Start()
    {
        UpdateRoom(doorStatus);
    }

    // Using bool to know when door is open or closed
    void UpdateRoom(bool[] status)
    {
        for (int i = 0; i < status.Length; i++)
        {
            doors[i].SetActive(status[i]);
            walls[i].SetActive(!status[i]);
            
        }
    }
}
