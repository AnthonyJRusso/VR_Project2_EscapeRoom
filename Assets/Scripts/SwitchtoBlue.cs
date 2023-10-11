using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class SwitchtoBlue : MonoBehaviour
{
    //Check use reference box and get XRI Left/Right Hand Interaction/Activate
    public InputActionProperty actionInput;
    public GameObject BlueWorld;
    public GameObject RedWorld;
    public AudioSource teleport;
    // Start is called before the first frame update
    void Start()
    {
        BlueWorld.SetActive(false);
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
        BlueWorld.SetActive(true);
        RedWorld.SetActive(false);
        teleport.Play();
    }

}
