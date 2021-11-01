using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathSystem : MonoBehaviour
{
    public enum SeedType {Random, Custom}
    [Header("Random Related Stuff")]
    public SeedType seedType = SeedType.Random;
    System.Random random;

    public int seed = 0;

    [Space]
    public bool animatedPath;
    public List<MyGridCell> gridCellList = new List<MyGridCell>();
    public int pathLength = 10;
    [Range(1.0f, 10.0f)]
    public float cellSize = 1.0f;

    public Transform StartLocation;


    void Start() {
        if(seedType == SeedType.Random) {
            random = new System.Random();
        }
        else if(seedType == SeedType.Custom){
            random = new System.Random(seed);
        }

    }

    void CreatePath() {
        gridCellList.Clear();
        //Vector2 currentPosition = new Vector2 (-15.0f, -9.0f);
        Vector2 currentPosition = StartLocation.transform.position;
        gridCellList.Add(new MyGridCell(currentPosition));

        for(int i = 0; i < pathLength; i++){
            int n = random.Next(100);

            if(n.isBetween(0,49)) {
                currentPosition = new Vector2(currentPosition.x + cellSize, currentPosition.y);
            }
            else {
                currentPosition = new Vector2 (currentPosition.x, currentPosition.y + cellSize);
            }

            gridCellList.Add(new MyGridCell(currentPosition));
        }
    
    }
    

    private void OnDrawGizmos() {
        for (int i = 0; i < gridCellList.Count; i++) {
            Gizmos.color = Color.white;
            Gizmos.DrawWireCube(gridCellList[i].location, Vector2.one * cellSize);
            Gizmos.color = new Color (0.5f, 0.5f, 0.5f, 0.5f);
            Gizmos.DrawCube(gridCellList[i].location, Vector2.one * cellSize);
         }
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            SetSeed();
            CreatePath();
        }
    }
}
