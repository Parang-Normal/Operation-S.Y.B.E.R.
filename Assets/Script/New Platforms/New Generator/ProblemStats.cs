using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MissingNumber
{
    FirstDigit,
    SecondDigit
}

[System.Serializable]
public class ProblemStats 
{
    [Tooltip("The Missing Number to be solved by the player")]
    public MissingNumber Problem;

    [Tooltip("The Operation to be used")]
    public Operations Operation;

    [Tooltip("Minimum value to randomize for First Digit")]
    public int FirstDigit_MinValue = 0;

    [Tooltip("Maximum value to randomize for First Digit")]
    public int FirstDigit_MaxValue = 1;

    [Tooltip("The value of the First Digit")]
    public int FirstDigit_Value = 0;

    [Tooltip("Minimum value to randomize for Second Digit")]
    public int SecondDigit_MinValue = 0;

    [Tooltip("Maximum value to randomize for Second Digit")]
    public int SecondDigit_MaxValue = 1;

    [Tooltip("The value of the Second Digit")]
    public int SecondDigit_Value = 0;

    [Tooltip("Minimum value to randomize for Result")]
    public int Result_MinValue = 0;

    [Tooltip("Maximum value to randomize for Result")]
    public int Result_MaxValue = 1;

    [Tooltip("The value of the Result")]
    public int Result_Value = 0;

    [Tooltip("Use Divisibility in randomizing result")]
    public bool UseDivisibility = false;

    [Tooltip("The divisor of the Result")]
    public int Divisor = 0;

    [Tooltip("The increment added to active answer block")]
    public int Increment = 1;
}
