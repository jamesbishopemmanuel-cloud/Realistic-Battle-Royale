using UnityEngine;


public class GraphicsManager : MonoBehaviour
{

    public void SetLowQuality()
    {
        QualitySettings.SetQualityLevel(0);

        Debug.Log(
        "Low graphics enabled");
    }


    public void SetHighQuality()
    {
        QualitySettings.SetQualityLevel(5);

        Debug.Log(
        "High graphics enabled");
    }

}