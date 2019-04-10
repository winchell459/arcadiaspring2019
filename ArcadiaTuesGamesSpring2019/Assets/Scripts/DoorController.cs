using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour {
    public DoorScript[] Doors;
    public Transform[] DoorsWaypoints;
    private DoorScript CorrectDoor;
    public DoorScript SelectedDoor;

    private bool firstRound = true;
    private bool secondRound = false;

    public GameObject WinningTrigger;

	// Use this for initialization
	void Start () {
        setCorrectDoor();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void setCorrectDoor(){
        int count = Doors.Length;
        int randomIndex = Random.Range(0, count - 1);
        CorrectDoor = Doors[randomIndex];
        WinningTrigger.transform.position = DoorsWaypoints[randomIndex].position;
    }

    public void SelectDoor(DoorScript selection){
        if (SelectedDoor != null){
            SelectedDoor.transform.Find("Spot Light").gameObject.SetActive(false);

        } 

        SelectedDoor = selection;
        SelectedDoor.transform.Find("Spot Light").gameObject.SetActive(true);


        if (firstRound)
        {
            int remaining = Doors.Length;
            foreach (DoorScript ds in Doors)
            {
                if (ds != SelectedDoor && remaining > 2 && ds != CorrectDoor)
                {
                    ds.OpenDoor();
                    remaining -= 1;
                }
            }
            firstRound = false;
            secondRound = true;

        }else if(secondRound){
            SelectedDoor.OpenDoor();
            secondRound = false;
        }else{
            
        }
    }
}
