def URLify(s, sLength):
    s = list(s)
    pointer = len(s) - 1

    for _ in range(sLength - 1, -1, -1):
        if (s[_] != " "):
            s[pointer] = s[_]
            pointer -= 1
        else:
            s[pointer] = "0"
            s[pointer - 1] = "2"
            s[pointer - 2] = "%"
            pointer -= 3
    return "".join(s)

print(URLify("Hi Hello world    ", 14))
