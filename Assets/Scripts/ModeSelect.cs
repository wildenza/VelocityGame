using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSelect : MonoBehaviour {

    public static int RaceMode; // 0=Race, 1=Score, 2=Time
    public GameObject TrackSelect;

    public void ScoreMode ()
    {
        RaceMode = 1;
        TrackSelect.SetActive(true);
    }


    public void TimeMode()
    {
        RaceMode = 2;
        TrackSelect.SetActive(true);
    }

    public void TheRaceMode()
    {
        RaceMode = 0;
        TrackSelect.SetActive(true);
    }

}
