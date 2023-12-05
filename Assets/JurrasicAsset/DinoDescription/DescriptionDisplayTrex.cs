using UnityEngine;

public class DescriptionDisplayTrex : MonoBehaviour
{
    private bool showText = false;
    private string dinosaurDescription = "\n\n\nSpecies: Tyrannosaurus rex\n\n" +
        "Description:\n" +
        "Tyrannosaurus rex, often abbreviated as T-Rex, was one of the largest carnivorous dinosaurs that lived during the Late Cretaceous period, around 68 to 66 million years ago. It is one of the most well-known dinosaurs and is characterized by its massive skull, powerful jaws, and tiny, two-fingered arms. T-Rex was a bipedal predator, and it likely used its robust teeth to crush bones and its powerful hind limbs for swift movement.";

    void OnMouseDown()
    {
        if (!showText)
        {
            showText = true;
            Debug.Log("Mouse Clicked");
        }
    }

    void OnGUI()
    {
        if (showText)
        {
            // Calculate percentages of the screen dimensions for button position and size
            float buttonWidthPercentage = 0.7f;  // 20% of the screen width
            float buttonHeightPercentage = 0.7f; // 5% of the screen height
            float buttonX = Screen.width * 0.5f - (Screen.width * buttonWidthPercentage * 0.5f);
            float buttonY = Screen.height * 0.5f - (Screen.height * buttonHeightPercentage * 0.5f);

            // If you've clicked the object, show this button
            if (GUI.Button(new Rect(buttonX, buttonY, Screen.width * buttonWidthPercentage, Screen.height * buttonHeightPercentage), " "))
            {
                // If you click this button, set showText to false
                showText = false;
            }

            // Display dinosaur description within the button
            GUIStyle style = new GUIStyle(GUI.skin.label);
            style.wordWrap = true;
            style.fontSize = 80; // Set the font size as needed
            GUI.Label(new Rect(buttonX, buttonY, Screen.width * buttonWidthPercentage, Screen.height * buttonHeightPercentage), dinosaurDescription, style);
        }
    }

    void Update()
    {
        if (showText && Input.GetKeyDown(KeyCode.Escape))
        {
            // If the Esc key is pressed, hide the button
            showText = false;
        }
    }
}
