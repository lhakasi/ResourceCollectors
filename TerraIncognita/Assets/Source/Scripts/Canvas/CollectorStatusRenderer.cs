using UnityEngine;
using TMPro;

public class CollectorStatusRenderer : MonoBehaviour
{
    private const string �������� = nameof(��������); 
    private const string ������� = nameof(�������); 

    [SerializeField] private Collector _collector;
    [SerializeField] private TMP_Text _statusRenderer;    
    
    void Update()
    {
        if (_collector.IsWorking)        
            _statusRenderer.text = ��������;        
        else        
            _statusRenderer.text = �������;        
    }
}
