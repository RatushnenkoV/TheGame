using UnityEngine;
using System.Collections;

public class BuildGreed : MonoBehaviour {

    public int Width = 10, Height = 10;
    public Vector3 Position;

    float dx = 0.85f, dy = 0.75f;

	// Use this for initialization
	void Start () {
        Build(Position, Width, Height);
	}

    public void Build(Vector3 pos, int width, int height)
    {
        for (int i = -10; i < width + 10; i++)
        {
            for (int j = -10; j < height + 10; j++)
            {
                GameObject cell = Resources.Load("Cell", typeof(GameObject)) as GameObject;

                float x = i * dx, y = j * dy;
                if (j % 2 != 0) { 
                    x += dx/2;
                } 

                cell.transform.position = pos + new Vector3(x, y, 0);
                GameObject cellClone = Instantiate(cell);

                cellClone.GetComponent<CellPosition>().Set(i, j);
                Entity e;
                if (i < 0 || i >= width || j < 0 || j > height)
                    e = new Block(Block.BlockType.Water);
                else
                    e = Entity.getRandom();

                cellClone.GetComponent<CellContent>().SetEntity(e);

                if (i == 0 && j == 0)
                    Camera.main.GetComponent<CameraMotion>().minpos = cellClone.transform.position;
                if (i == width-1 && j == height-1)
                    Camera.main.GetComponent<CameraMotion>().maxpos = cellClone.transform.position;
            }
        }
    }
}
