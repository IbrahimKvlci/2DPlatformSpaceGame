using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planets : MonoBehaviour
{
    List<GameObject> _planets=new List<GameObject>();
    List<GameObject> _activePlanets=new List<GameObject>();

    private void Awake()
    {
        Object[] sprites = Resources.LoadAll("Gezegenler");

        for (int i = 1; i < sprites.Length; i++)
        {
            GameObject planet = new GameObject();
            SpriteRenderer sRenderer=planet.AddComponent<SpriteRenderer>();
            sRenderer.sprite = (Sprite)sprites[i];
            Color spriteColor = sRenderer.color;
            spriteColor.a = 0.5f;
            sRenderer.color = spriteColor;
            planet.name = sprites[i].name;
            sRenderer.sortingLayerName = "Planet";
            Vector2 position = planet.transform.position;
            position.x = -10;
            planet.transform.position = position;
            _planets.Add(planet);
        }
    }

    public void PlacePlanet(float refY)
    {
        float height = ScreenCalculator._instance.Height;
        float width=ScreenCalculator._instance.Width;

        //1.Area
        float xValue1 = Random.Range(0, width);
        float yValue1 = Random.Range(refY, height+ refY);
        GameObject planet1 = RandomPlanet();
        planet1.transform.position = new Vector3(xValue1, yValue1);

        //2.Area
        float xValue2 = Random.Range(0, -width);
        float yValue2 = Random.Range(refY, height+refY);
        GameObject planet2 = RandomPlanet();
        planet2.transform.position = new Vector3(xValue2, yValue2);

        //3.Area
        float xValue3 = Random.Range(0, -width);
        float yValue3 = Random.Range(refY, -height+ refY);
        GameObject planet3 = RandomPlanet();
        planet3.transform.position = new Vector3(xValue3, yValue3);

        //4.Area
        float xValue4 = Random.Range(0, width);
        float yValue4 = Random.Range(refY, -height+ refY);
        GameObject planet4 = RandomPlanet();
        planet4.transform.position = new Vector3(xValue4, yValue4);
    }

    GameObject RandomPlanet()
    {
        if (_planets.Count > 0)
        {
            int random;
            if (_planets.Count == 1)
            {
                random = 0;
            }
            else
            {
                random=Random.Range(0, _planets.Count-1);
            }
            GameObject planet = _planets[random];
            _planets.Remove(planet);
            _activePlanets.Add(planet);
            return planet;
        }
        else
        {
            for (int i = 0; i < 8; i++)
            {
                _planets.Add(_activePlanets[i]);
            }
            _activePlanets.RemoveRange(0, 8);
            int random = Random.Range(0, 8);
            GameObject planet = _planets[random];
            _planets.Remove(planet);
            _activePlanets.Add(planet);
            return planet;
        }
    }
}
