def isUnique(s):
    s = s.lower() # O(n)
    s = sorted(s) # O(n log n)
    for i in range(len(s) - 1): #O(n)
        if (s[i] == s[i + 1]):
            return False
    return True

    #Time Complexity O(n log n) (I think lol)
    #Space Complexity O(1)

print(isUnique("Lnoe"))