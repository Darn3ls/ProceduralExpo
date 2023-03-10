using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonGenerator : MonoBehaviour
{
    public int numberOfRooms;
    public List<RoomBehaviour> roomsToGenerate;
    public GameObject roomPrefab;
    public float paddingX, paddingZ;
    private GameObject generatedRoom;
    Vector3 lastRoomPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfRooms; i++)
        {
            Vector3 newPosX = new Vector3(lastRoomPosition.x + paddingX, 0, lastRoomPosition.z);
            Vector3 newPosZ = new Vector3(lastRoomPosition.x, 0, lastRoomPosition.z + paddingZ);
            int generatedNumber = Random.Range(0, 10);
            if(generatedNumber%2 == 0)
            {
                generatedRoom = Instantiate(roomPrefab, newPosX, Quaternion.identity);
                lastRoomPosition = generatedRoom.transform.position;
            }
            else
            {
                generatedRoom = Instantiate(roomPrefab, newPosZ, Quaternion.identity);
                lastRoomPosition = generatedRoom.transform.position;
            }
            
            //roomsToGenerate.Add(oldGeneratedRoom.GetComponent<RoomBehaviour>());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
