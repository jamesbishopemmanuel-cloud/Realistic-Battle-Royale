using UnityEngine;


public class WeatherSystem : MonoBehaviour
{

    public string weather =
    "Sunny";


    public void ChangeWeather(
    string newWeather)
    {
        weather = newWeather;


        Debug.Log(
        "Weather: "
        + weather);
    }

}