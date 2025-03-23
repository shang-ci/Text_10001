using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CardLibrarySO", menuName = "Card/CardLibrarySO")]
public class CardLibrarySO : ScriptableObject
{
    public List<CardLibraryEntry> entryList;
}

[System.Serializable]
public struct CardLibraryEntry
{
    public Card_item cardData;
    public int amount;
}