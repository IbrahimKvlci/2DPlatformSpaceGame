using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderControl : MonoBehaviour
{
    Slider _slider;


    void Start()
    {
        _slider = GetComponent<Slider>();
        _slider.value = 3;
    }

    public void SliderValue(int maxValue,int currentValue)
    {
        int sliderValue = maxValue - currentValue;
        _slider.maxValue=maxValue;
        _slider.value=sliderValue;
    }
}
