using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Material collectedObjMat;
    public PlayerState playerState;
    public LevelState levelState;

    public Transform partcilePrefab;

    public List<GameObject> collidedList;

    public Transform collectedPoolTransform;

    public GameObject[] total;

    public static PlayerManager instance;

    public void Start()
    {
        instance = this;
        total = GameObject.FindGameObjectsWithTag("SphereObj");
    }
    public enum PlayerState
    {
        Stop,
        Move
    }
    public enum LevelState 
    {
        NotFinished,
        Finished
    }

    public void CallMakeSphere () {
        foreach (GameObject obj in collidedList) {
            obj.GetComponent<CollectedObjController>().MakeSphere();
        }
        
    }
}
