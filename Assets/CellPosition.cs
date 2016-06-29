using UnityEngine;
using System.Collections;

public class CellPosition : MonoBehaviour {

    int x, y;

    bool Assigned;

    public void Set(int x, int y)
    {
        if (!Assigned)
        {
            this.x = x;    
            this.y = y;    
            Assigned = true;
        }
    }
}
