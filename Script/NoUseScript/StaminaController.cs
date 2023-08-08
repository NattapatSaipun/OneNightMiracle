using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaController : MonoBehaviour
{
    [Header("Stamina Main Paramiter")]
    public float playerStamina = 100.0f;
    [SerializeField] private float maxStamina = 100.0f;
    [HideInInspector] public bool hasRegenerate = true;
    [HideInInspector] public bool weAreSprinting = false;

    [Header("Stamina Regen Parameter")]
    [Range(0, 50)] [SerializeField] private float staminaDrian = 0.5f;
    [Range(0, 50)] [SerializeField] private float staminaRegen = 0.5f;

    [Header("Stamina Speed Parameter")]
    [SerializeField] private int slowRunSpeed = 4;
    [SerializeField] private int nomalRunSpeed = 8;

    [Header("Stamina UI Element")]
    [SerializeField] private Image staminaProgressUI = null;
    [SerializeField] private CanvasGroup sliderCanvasGroup = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
