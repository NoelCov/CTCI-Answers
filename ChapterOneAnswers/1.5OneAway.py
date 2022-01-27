def OneAway(s1, s2):
    s1 = s1.lower()
    s2 = s2.lower()

    if (s1 == s2):
        return True

    lenS1 = len(s1)
    lenS2 = len(s2)
    
    if abs(lenS1 - lenS2) <= 1:
        smallString = s1 if lenS1 < lenS2 else s2
        bigString = s1 if smallString == s2 else s2
        numDiff = 0
        pointer = 0

        for _ in range(len(bigString)):
            if (numDiff > 1):
                return False

            if (bigString[_] == smallString[pointer]):
                pointer += 1
            else:
                numDiff += 1
        return True
    
    else:
        return False
    
    # Time Complexity O(n)
    # Space Complexity O(1)

print(OneAway("Hellllllllllllllllllo", "hello"))