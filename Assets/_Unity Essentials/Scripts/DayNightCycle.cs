using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Header("Day/Night Cycle Settings")]
    [Tooltip("How many real-world seconds it takes for a full day.")]
    [Min(1f)]
    public float secondsPerDay = 120f;

    [Tooltip("Starting time of day (0 = midnight, 0.5 = midday).")]
    [Range(0f, 1f)]
    public float timeOfDay = 0.25f;

    void Update()
    {
        // Advance the time of day
        timeOfDay += Time.deltaTime / secondsPerDay;

        // Keep time between 0 and 1
        timeOfDay %= 1f;

        // Rotate the directional light
        float sunAngle = timeOfDay * 360f;

        transform.rotation = Quaternion.Euler(
            sunAngle - 90f,
            170f,
            0f
        );
    }
}
