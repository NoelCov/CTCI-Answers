def PalindromePermutation(s):
    hash = {}
    s = s.lower().replace(" ", "") 

    for letter in range(len(s)):
        print(s[letter])
        if s[letter] in hash:
            hash[s[letter]] += 1
        else:
            hash[s[letter]] = 1

    counter = 0
    for _ in hash.values():
        if (_ % 2 != 0):
            counter += 1

    return counter <= 1
    
    # Run Time O(n)

print(PalindromePermutation("dogegod"))