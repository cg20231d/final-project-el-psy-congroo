using UnityEngine;

public class DescriptionDisplayTri : MonoBehaviour
{
    private bool showText = false;
    private string dinosaurDescription = "\n\n\nSpecies: Triceratops\n\n" +
        "Description:\n" +
        "Triceratops was a genus of large, herbivorous dinosaurs that lived during the Late Cretaceous period, approximately 68 to 66 million years ago. Known for its distinctive frill and three facial horns, Triceratops was a quadrupedal dinosaur with a robust body. It measured around 9 meters (30 feet) in length and weighed several tons. Triceratops likely used its horns and frill for defense against predators and possibly in mating displays.";

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
