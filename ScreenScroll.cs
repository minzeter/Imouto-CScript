using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenScroll : MonoBehaviour
{
    [SerializeField] private float scrollSpeed = 1.0f;
    [SerializeField] private Camera _camera;
    [SerializeField] private SpriteRenderer[] sprites;
   
    void Update()
    {
        float minX = _camera.ViewportToWorldPoint(new Vector2(0, 0)).x;

        foreach ( SpriteRenderer sr in sprites )
        {
            sr.transform.position += Vector3.left * scrollSpeed * Time.deltaTime;

            if (sr.bounds.max.x < minX)
            {
                Vector2 position = sr.transform.position;
                position.x += sprites.Length * sr.bounds.size.x;
                sr.transform.position = position;
            }

        }
    }
}
