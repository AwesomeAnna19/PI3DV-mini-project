using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatingHealthBar : MonoBehaviour
{
    // Here I make a slider component from Unity, that acts like a health bar.
    [SerializeField] private Slider slider;

    // Here I make a function that takes the current "health" value and the max "health" value as two arguments.
    public void UpdateHealthBar(float currentValue, float maxValue)
    {
        // This code then takes the two arguments and divide them by each other, and then puts them as the slider's value.
        slider.value = currentValue / maxValue;
    }
}
