def StringCompression(s):
    newString = ""
    
    currentChar, charCount = s[0], 1

    for char in range(1, len(s)):
        if (currentChar == s[char]):
            charCount += 1
        else:
            newString += currentChar
            newString += str(charCount)

            currentChar = s[char]
            charCount = 1

    newString += currentChar
    newString += str(charCount)

    return newString if len(newString) < len(s) else s
    # Time Complexity O(n)
    # Space Complexity O(n)

print(StringCompression("NNoooelllll"))