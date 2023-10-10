using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour
{
    [SerializeField]
    GameObject _gold;

    public void OnGold()
    {
        _gold.SetActive(true);
    }

    public void OffGold()
    {
        _gold.SetActive(false);
    }
}
