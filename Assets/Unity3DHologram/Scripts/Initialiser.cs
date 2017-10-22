using UnityEngine;

public class Initialiser : MonoBehaviour {

	void Start ()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
           Application.Quit();
        }
    }
}
