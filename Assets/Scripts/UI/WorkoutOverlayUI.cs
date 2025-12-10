using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WorkoutOverlayUI : MonoBehaviour
{
    [Header("UI Elements")]
    public TMP_Text repCounterText;
    public TMP_Text timerText;
    public TMP_Text feedbackText;
    public Image qualityIndicator;
    
    private int currentReps = 0;
    private float sessionTime = 0f;
    
    void Update()
    {
        // Mettre à jour le timer chaque frame
        sessionTime += Time.deltaTime;
        
        int minutes = (int)(sessionTime / 60);
        int seconds = (int)(sessionTime % 60);
        
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    
    // Fonction appelée quand une rep est détectée
    public void AddRep()
    {
        currentReps++;
        repCounterText.text = "Reps: " + currentReps;
        Debug.Log("✅ Rep ajoutée ! Total : " + currentReps);
    }
    
    // Afficher un message de feedback
    public void ShowFeedback(string message, Color color)
    {
        feedbackText.text = message;
        feedbackText.color = color;
        
        // Cacher le message après 2 secondes
        Invoke("HideFeedback", 2f);
    }
    
    void HideFeedback()
    {
        feedbackText.text = "";
    }
    
    // Changer la couleur de l'indicateur
    public void UpdateQuality(Color color)
    {
        qualityIndicator.color = color;
    }
}