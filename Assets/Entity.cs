using UnityEngine;

public class Entity
{
    public Sprite sprite;

    virtual public void OnClick(GameObject cell)
    {
    }

    public static Entity getRandom()
    {
        int r = Random.Range(0, 4);
        switch (r)
        {
            case 0: return EmptyCell.getRandom(); 
            case 1: return Material.getForrest(); 
            case 2: return Material.getMountain();
            case 3: return new Block(Block.BlockType.Water);
        }
        return null;
    }
}
