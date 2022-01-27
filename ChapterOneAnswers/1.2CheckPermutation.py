def CheckPermutation(s1, s2):
    if len(s1) != len(s2):
        return False
    
    s1 = s1.lower() # O(n)
    s1 = sorted(s1) # O(n log n)
    s1 = ''.join(s1) # O(n)
    
    s2 = s1.lower() 
    s2 = sorted(s2)
    s2 = ''.join(s2)

    if s1 == s2:
        return True
    return False
    
    # Space Complexity O(1)
    # Time Complexity O(n log n)

print(CheckPermutation("Noel", "Lleon"))