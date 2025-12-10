using UnityEngine;
using TMPro;

public class HistoryController : MonoBehaviour
{
    public Transform contentPanel; // Le "Content" du Scroll View
    public GameObject sessionPrefab; // On va créer un prefab
    
    void Start()
    {
        DisplayHistory();
    }
    
    void DisplayHistory()
    {
        User user = DataManager.Instance.CurrentUser;
        
        if (user == null || user.history.Count == 0)
        {
            Debug.Log("📭 Pas d'historique");
            return;
        }
        
        foreach (Session session in user.history)
        {
            // Créer un objet texte pour chaque session
            GameObject sessionObj = new GameObject("SessionItem");
            sessionObj.transform.SetParent(contentPanel, false);
            
            TMP_Text text = sessionObj.AddComponent<TextMeshProUGUI>();
            text.text = string.Format("📅 {0:dd/MM/yyyy} - {1} reps - Score: {2:F0}%",
                session.date, session.totalReps, session.avgScore * 100);
            text.fontSize = 24;
            text.color = Color.white;
        }
        
        Debug.Log("📊 Historique affiché : " + user.history.Count + " séances");
    }
}