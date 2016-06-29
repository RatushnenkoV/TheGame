using UnityEngine;
using System.Collections;

public class CellContent : MonoBehaviour {

    Entity entity;

    public void OnMouseDown()
    {
        var e = entity;
        e.OnClick(gameObject);
    }

    public void SetEntity(Entity newEntity)
    {
        entity = newEntity;
        GetComponent<SpriteRenderer>().sprite = entity.sprite;
    }

}
