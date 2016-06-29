using UnityEngine;

class Block: Entity
{
    public enum BlockType { Water}

    BlockType type;

    public Block(BlockType type)
    {
        setType(type);
    }

    void setType(BlockType type)
    {
        this.type = type;
        sprite = Resources.Load(type.ToString(), typeof(Sprite)) as Sprite;
    }
}