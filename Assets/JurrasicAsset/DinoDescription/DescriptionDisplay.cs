using UnityEngine;

public class DescriptionDisplay : MonoBehaviour
{
    private bool showText = false;
    private string dinosaurDescription = "\n\n\nSpecies: Velociraptor\n\n" +
        "Description:\n" +
        "Velociraptors were a genus of small, predatory dinosaurs that lived during the Late Cretaceous period, approximately 75 to 71 million years ago. Contrary to popular depictions in movies, velociraptors were not as large as portrayed, standing about 1.6 feet tall at the hip and measuring around 6 feet in length. They were bipedal with long, slender legs and a distinctive sickle-shaped claw on each foot, which they likely used for hunting and capturing prey.";

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
