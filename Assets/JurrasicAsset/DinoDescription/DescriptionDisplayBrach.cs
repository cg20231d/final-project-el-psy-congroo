using UnityEngine;

public class DescriptionDisplayBrach : MonoBehaviour
{
    private bool showText = false;
    private string dinosaurDescription = "\n\n\nSpecies: Brachiosaurus\n\n" +
        "Description:\n" +
        "Brachiosaurus was a genus of large, herbivorous dinosaurs that lived during the Late Jurassic period, approximately 154 to 153 million years ago. They were known for their distinctive long necks and relatively short tails. Brachiosaurus was one of the tallest and heaviest dinosaurs, with some individuals reaching up to 85 feet in length. Their long necks allowed them to reach vegetation at great heights, and they likely lived in both lowland and upland environments.";

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
