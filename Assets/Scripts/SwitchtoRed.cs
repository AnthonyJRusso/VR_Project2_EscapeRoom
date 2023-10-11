using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class SwitchtoRed : MonoBehaviour
{
    //Check use reference box and get XRI Left/Right Hand Interaction/Activate
    public InputActionProperty actionInput;
    public GameObject RedWorld;
    public GameObject BlueWorld;
    public AudioSource energy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable()
    {
        //Runs function when button is pressed down 
        actionInput.action.started += SwitchWorlds;
    }

    private void SwitchWorlds(InputAction.CallbackContext obj)
    {
        RedWorld.SetActive(true);
        BlueWorld.SetActive(false);
        energy.Play();
    }
}
