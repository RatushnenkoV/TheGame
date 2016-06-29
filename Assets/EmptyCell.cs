using UnityEngine;

class EmptyCell: Entity
{
    public enum EmptyCellType { Grass, Desert, Ground };

    public EmptyCellType type;

    public EmptyCell()
    {
    }

    public EmptyCell(EmptyCellType type)
    {
        setType(type);
    }

    override public void OnClick(GameObject cell)
    {
        Debug.Log("Empty Cell Click!");
    }

    void setType(EmptyCellType type)
    {
        this.type = type;
        sprite = Resources.Load(type.ToString(), typeof(Sprite)) as Sprite;
    }

    new public static EmptyCell getRandom()
    {
        int r = Random.Range(0, 2);
        switch (r)
        {
            case 0: return new EmptyCell(EmptyCellType.Grass);
            case 1: return new EmptyCell(EmptyCellType.Grass);
        }
        return null;
    }
}