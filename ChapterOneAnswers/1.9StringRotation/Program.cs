bool isSubstring(string s1, string s2)
{
    // Find s1[0] in s2.
    int s2Index = s2.IndexOf(s1[0]);

    if (s2Index < 0) return false;

    int s1Index = 0;

    for (int i = 0; i < s2.Length; i++)
    {
        if (s2Index == s2.Length) s2Index = 0;

        if (s1[s1Index] != s2[s2Index]) return false;
        
        s1Index++;
        s2Index++;
    }
    return true;

    // Space Complexity O(1);
    // Time Complexity O(n);
}

Console.WriteLine(isSubstring("Noela", "laNoel"));