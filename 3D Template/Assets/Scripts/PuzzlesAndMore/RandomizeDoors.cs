using UnityEngine;

public class RandomizeDoors : MonoBehaviour
{
    /// <summary>
    /// This script will randomize the 19 doors in this part.
    /// The randomize is for what door can open.
    /// Note that only 1 door can open out of the 19 doors.
    /// </summary>

    public Keypad door1Script, door2Script, door3Script, door4Script, door5Script, door6Script, door7Script, door8Script, door9Script, door10Script, door11Script, door12Script, door13Script, door14Script, door15Script, door16Script, door17Script, door18Script, door19Script;

    public int doorChoice;
    public int doorCount = 19;

    private MeshRenderer meshRenderer;
    private BoxCollider boxCollider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        boxCollider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (doorChoice == 1)
        {
            door1Script.canInteract = true;
            door2Script.canInteract = false;
            door3Script.canInteract = false;
            door4Script.canInteract = false;
            door5Script.canInteract = false;
            door6Script.canInteract = false;
            door7Script.canInteract = false;
            door8Script.canInteract = false;
            door9Script.canInteract = false;
            door10Script.canInteract = false;
            door11Script.canInteract = false;
            door12Script.canInteract = false;
            door13Script.canInteract = false;
            door14Script.canInteract = false;
            door15Script.canInteract = false;
            door16Script.canInteract = false;
            door17Script.canInteract = false;
            door18Script.canInteract = false;
            door19Script.canInteract = false;
        }
        else if (doorChoice == 2)
        {
            door1Script.canInteract = false;
            door2Script.canInteract = true;
            door3Script.canInteract = false;
            door4Script.canInteract = false;
            door5Script.canInteract = false;
            door6Script.canInteract = false;
            door7Script.canInteract = false;
            door8Script.canInteract = false;
            door9Script.canInteract = false;
            door10Script.canInteract = false;
            door11Script.canInteract = false;
            door12Script.canInteract = false;
            door13Script.canInteract = false;
            door14Script.canInteract = false;
            door15Script.canInteract = false;
            door16Script.canInteract = false;
            door17Script.canInteract = false;
            door18Script.canInteract = false;
            door19Script.canInteract = false;
        }
        else if (doorChoice == 3)
        {
            door1Script.canInteract = false;
            door2Script.canInteract = false;
            door3Script.canInteract = true;
            door4Script.canInteract = false;
            door5Script.canInteract = false;
            door6Script.canInteract = false;
            door7Script.canInteract = false;
            door8Script.canInteract = false;
            door9Script.canInteract = false;
            door10Script.canInteract = false;
            door11Script.canInteract = false;
            door12Script.canInteract = false;
            door13Script.canInteract = false;
            door14Script.canInteract = false;
            door15Script.canInteract = false;
            door16Script.canInteract = false;
            door17Script.canInteract = false;
            door18Script.canInteract = false;
            door19Script.canInteract = false;
        }
        else if (doorChoice == 4)
        {
            door1Script.canInteract = false;
            door2Script.canInteract = false;
            door3Script.canInteract = false;
            door4Script.canInteract = true;
            door5Script.canInteract = false;
            door6Script.canInteract = false;
            door7Script.canInteract = false;
            door8Script.canInteract = false;
            door9Script.canInteract = false;
            door10Script.canInteract = false;
            door11Script.canInteract = false;
            door12Script.canInteract = false;
            door13Script.canInteract = false;
            door14Script.canInteract = false;
            door15Script.canInteract = false;
            door16Script.canInteract = false;
            door17Script.canInteract = false;
            door18Script.canInteract = false;
            door19Script.canInteract = false;
        }
        else if (doorChoice == 5)
        {
            door1Script.canInteract = false;
            door2Script.canInteract = false;
            door3Script.canInteract = false;
            door4Script.canInteract = false;
            door5Script.canInteract = true;
            door6Script.canInteract = false;
            door7Script.canInteract = false;
            door8Script.canInteract = false;
            door9Script.canInteract = false;
            door10Script.canInteract = false;
            door11Script.canInteract = false;
            door12Script.canInteract = false;
            door13Script.canInteract = false;
            door14Script.canInteract = false;
            door15Script.canInteract = false;
            door16Script.canInteract = false;
            door17Script.canInteract = false;
            door18Script.canInteract = false;
            door19Script.canInteract = false;
        }
        else if (doorChoice == 6)
        {
            door1Script.canInteract = false;
            door2Script.canInteract = false;
            door3Script.canInteract = false;
            door4Script.canInteract = false;
            door5Script.canInteract = false;
            door6Script.canInteract = true;
            door7Script.canInteract = false;
            door8Script.canInteract = false;
            door9Script.canInteract = false;
            door10Script.canInteract = false;
            door11Script.canInteract = false;
            door12Script.canInteract = false;
            door13Script.canInteract = false;
            door14Script.canInteract = false;
            door15Script.canInteract = false;
            door16Script.canInteract = false;
            door17Script.canInteract = false;
            door18Script.canInteract = false;
            door19Script.canInteract = false;
        }
        else if (doorChoice == 7)
        {
            door1Script.canInteract = false;
            door2Script.canInteract = false;
            door3Script.canInteract = false;
            door4Script.canInteract = false;
            door5Script.canInteract = false;
            door6Script.canInteract = false;
            door7Script.canInteract = true;
            door8Script.canInteract = false;
            door9Script.canInteract = false;
            door10Script.canInteract = false;
            door11Script.canInteract = false;
            door12Script.canInteract = false;
            door13Script.canInteract = false;
            door14Script.canInteract = false;
            door15Script.canInteract = false;
            door16Script.canInteract = false;
            door17Script.canInteract = false;
            door18Script.canInteract = false;
            door19Script.canInteract = false;
        }
        else if (doorChoice == 8)
        {
            door1Script.canInteract = false;
            door2Script.canInteract = false;
            door3Script.canInteract = false;
            door4Script.canInteract = false;
            door5Script.canInteract = false;
            door6Script.canInteract = false;
            door7Script.canInteract = false;
            door8Script.canInteract = true;
            door9Script.canInteract = false;
            door10Script.canInteract = false;
            door11Script.canInteract = false;
            door12Script.canInteract = false;
            door13Script.canInteract = false;
            door14Script.canInteract = false;
            door15Script.canInteract = false;
            door16Script.canInteract = false;
            door17Script.canInteract = false;
            door18Script.canInteract = false;
            door19Script.canInteract = false;
        }
        else if (doorChoice == 9)
        {
            door1Script.canInteract = false;
            door2Script.canInteract = false;
            door3Script.canInteract = false;
            door4Script.canInteract = false;
            door5Script.canInteract = false;
            door6Script.canInteract = false;
            door7Script.canInteract = false;
            door8Script.canInteract = false;
            door9Script.canInteract = true;
            door10Script.canInteract = false;
            door11Script.canInteract = false;
            door12Script.canInteract = false;
            door13Script.canInteract = false;
            door14Script.canInteract = false;
            door15Script.canInteract = false;
            door16Script.canInteract = false;
            door17Script.canInteract = false;
            door18Script.canInteract = false;
            door19Script.canInteract = false;
        }
        else if (doorChoice == 10)
        {
            door1Script.canInteract = false;
            door2Script.canInteract = false;
            door3Script.canInteract = false;
            door4Script.canInteract = false;
            door5Script.canInteract = false;
            door6Script.canInteract = false;
            door7Script.canInteract = false;
            door8Script.canInteract = false;
            door9Script.canInteract = false;
            door10Script.canInteract = true;
            door11Script.canInteract = false;
            door12Script.canInteract = false;
            door13Script.canInteract = false;
            door14Script.canInteract = false;
            door15Script.canInteract = false;
            door16Script.canInteract = false;
            door17Script.canInteract = false;
            door18Script.canInteract = false;
            door19Script.canInteract = false;
        }
        else if (doorChoice == 11)
        {
            door1Script.canInteract = false;
            door2Script.canInteract = false;
            door3Script.canInteract = false;
            door4Script.canInteract = false;
            door5Script.canInteract = false;
            door6Script.canInteract = false;
            door7Script.canInteract = false;
            door8Script.canInteract = false;
            door9Script.canInteract = false;
            door10Script.canInteract = false;
            door11Script.canInteract = true;
            door12Script.canInteract = false;
            door13Script.canInteract = false;
            door14Script.canInteract = false;
            door15Script.canInteract = false;
            door16Script.canInteract = false;
            door17Script.canInteract = false;
            door18Script.canInteract = false;
            door19Script.canInteract = false;
        }
        else if (doorChoice == 12)
        {
            door1Script.canInteract = false;
            door2Script.canInteract = false;
            door3Script.canInteract = false;
            door4Script.canInteract = false;
            door5Script.canInteract = false;
            door6Script.canInteract = false;
            door7Script.canInteract = false;
            door8Script.canInteract = false;
            door9Script.canInteract = false;
            door10Script.canInteract = false;
            door11Script.canInteract = false;
            door12Script.canInteract = true;
            door13Script.canInteract = false;
            door14Script.canInteract = false;
            door15Script.canInteract = false;
            door16Script.canInteract = false;
            door17Script.canInteract = false;
            door18Script.canInteract = false;
            door19Script.canInteract = false;
        }
        else if (doorChoice == 13)
        {
            door1Script.canInteract = false;
            door2Script.canInteract = false;
            door3Script.canInteract = false;
            door4Script.canInteract = false;
            door5Script.canInteract = false;
            door6Script.canInteract = false;
            door7Script.canInteract = false;
            door8Script.canInteract = false;
            door9Script.canInteract = false;
            door10Script.canInteract = false;
            door11Script.canInteract = false;
            door12Script.canInteract = false;
            door13Script.canInteract = true;
            door14Script.canInteract = false;
            door15Script.canInteract = false;
            door16Script.canInteract = false;
            door17Script.canInteract = false;
            door18Script.canInteract = false;
            door19Script.canInteract = false;
        }
        else if (doorChoice == 14)
        {
            door1Script.canInteract = false;
            door2Script.canInteract = false;
            door3Script.canInteract = false;
            door4Script.canInteract = false;
            door5Script.canInteract = false;
            door6Script.canInteract = false;
            door7Script.canInteract = false;
            door8Script.canInteract = false;
            door9Script.canInteract = false;
            door10Script.canInteract = false;
            door11Script.canInteract = false;
            door12Script.canInteract = false;
            door13Script.canInteract = false;
            door14Script.canInteract = true;
            door15Script.canInteract = false;
            door16Script.canInteract = false;
            door17Script.canInteract = false;
            door18Script.canInteract = false;
            door19Script.canInteract = false;
        }
        else if (doorChoice == 15)
        {
            door1Script.canInteract = false;
            door2Script.canInteract = false;
            door3Script.canInteract = false;
            door4Script.canInteract = false;
            door5Script.canInteract = false;
            door6Script.canInteract = false;
            door7Script.canInteract = false;
            door8Script.canInteract = false;
            door9Script.canInteract = false;
            door10Script.canInteract = false;
            door11Script.canInteract = false;
            door12Script.canInteract = false;
            door13Script.canInteract = false;
            door14Script.canInteract = false;
            door15Script.canInteract = true;
            door16Script.canInteract = false;
            door17Script.canInteract = false;
            door18Script.canInteract = false;
            door19Script.canInteract = false;
        }
        else if (doorChoice == 16)
        {
            door1Script.canInteract = false;
            door2Script.canInteract = false;
            door3Script.canInteract = false;
            door4Script.canInteract = false;
            door5Script.canInteract = false;
            door6Script.canInteract = false;
            door7Script.canInteract = false;
            door8Script.canInteract = false;
            door9Script.canInteract = false;
            door10Script.canInteract = false;
            door11Script.canInteract = false;
            door12Script.canInteract = false;
            door13Script.canInteract = false;
            door14Script.canInteract = false;
            door15Script.canInteract = false;
            door16Script.canInteract = true;
            door17Script.canInteract = false;
            door18Script.canInteract = false;
            door19Script.canInteract = false;
        }
        else if (doorChoice == 17)
        {
            door1Script.canInteract = false;
            door2Script.canInteract = false;
            door3Script.canInteract = false;
            door4Script.canInteract = false;
            door5Script.canInteract = false;
            door6Script.canInteract = false;
            door7Script.canInteract = false;
            door8Script.canInteract = false;
            door9Script.canInteract = false;
            door10Script.canInteract = false;
            door11Script.canInteract = false;
            door12Script.canInteract = false;
            door13Script.canInteract = false;
            door14Script.canInteract = false;
            door15Script.canInteract = false;
            door16Script.canInteract = false;
            door17Script.canInteract = true;
            door18Script.canInteract = false;
            door19Script.canInteract = false;
        }
        else if (doorChoice == 18)
        {
            door1Script.canInteract = false;
            door2Script.canInteract = false;
            door3Script.canInteract = false;
            door4Script.canInteract = false;
            door5Script.canInteract = false;
            door6Script.canInteract = false;
            door7Script.canInteract = false;
            door8Script.canInteract = false;
            door9Script.canInteract = false;
            door10Script.canInteract = false;
            door11Script.canInteract = false;
            door12Script.canInteract = false;
            door13Script.canInteract = false;
            door14Script.canInteract = false;
            door15Script.canInteract = false;
            door16Script.canInteract = false;
            door17Script.canInteract = false;
            door18Script.canInteract = true;
            door19Script.canInteract = false;
        }
        else if (doorChoice == 19)
        {
            door1Script.canInteract = false;
            door2Script.canInteract = false;
            door3Script.canInteract = false;
            door4Script.canInteract = false;
            door5Script.canInteract = false;
            door6Script.canInteract = false;
            door7Script.canInteract = false;
            door8Script.canInteract = false;
            door9Script.canInteract = false;
            door10Script.canInteract = false;
            door11Script.canInteract = false;
            door12Script.canInteract = false;
            door13Script.canInteract = false;
            door14Script.canInteract = false;
            door15Script.canInteract = false;
            door16Script.canInteract = false;
            door17Script.canInteract = false;
            door18Script.canInteract = false;
            door19Script.canInteract = true;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            doorChoice = Random.Range(1, doorCount);
            Debug.Log("The Correct Door Is: Door " + doorChoice);
            meshRenderer.enabled = false;
            boxCollider.enabled = false;
        }
    }
}
