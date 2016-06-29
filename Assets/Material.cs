using UnityEngine;

class Material: Entity
{
    public enum MaterialType { Forrest, Mountain};
    MaterialType type;

    const int MaxCount = 3;
    int Count;

    Material()
    {
        Count = MaxCount;
    }

    override public void OnClick(GameObject cell)
    {
        Count--;
        if (Count == 0)
        {
            EmptyCell e = null;
            switch (type)
            {
                case (MaterialType.Forrest): e = new EmptyCell(EmptyCell.EmptyCellType.Grass); break;
                case (MaterialType.Mountain): e = new EmptyCell(EmptyCell.EmptyCellType.Ground); break;
            }
            cell.GetComponent<CellContent>().SetEntity(e);
        }
        Debug.Log("Tap");
    }

    public static Material getForrest()
    {
        Material m = new Material();
        m.type = MaterialType.Forrest;
        m.sprite = Resources.Load("Forrest3", typeof(Sprite)) as Sprite;
        return m;
    }

    public static Material getMountain()
    {
        Material m = new Material();
        m.type = MaterialType.Mountain;
        m.sprite = Resources.Load("Mountain3", typeof(Sprite)) as Sprite;
        return m;
    }

    /*
    public static Material getMeat()
    {
        Material m = new Material();
        m.type = MaterialType.Meat;
        m.sprite = Resources.Load("Meat3", typeof(Sprite)) as Sprite;
        return m;
    }
    */
}

