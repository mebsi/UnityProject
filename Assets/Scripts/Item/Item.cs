using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public List<Sprite> sprites;
    protected float speed;
    
    public virtual void Init()
    {
        GetComponent<SpriteAnimation>().SetSprite(sprites, 0.2f);
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.Translate(new Vector2(0f, -(Time.deltaTime * speed)));
    }
}
