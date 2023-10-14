using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planets : MonoBehaviour
{
    List<GameObject> _planets=new List<GameObject>();

    private void Awake()
    {
        Object[] sprites = Resources.LoadAll("Gezegenler");

        for (int i = 1; i < sprites.Length+1; i++)
        {
            GameObject planet = new GameObject();
            SpriteRenderer sRenderer=planet.AddComponent<SpriteRenderer>();
            sRenderer.sprite = (Sprite)sprites[i];
            planet.name = sprites[i].name;
            sRenderer.sortingLayerName = "Planet";
            _planets.Add(planet);
        }
    }
}
