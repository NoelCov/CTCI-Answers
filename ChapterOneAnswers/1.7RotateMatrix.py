def RotateMatrix(matrix):

    if (len(matrix) > len(matrix[0] or len(matrix) < len(matrix[0]))):
        return False

    # 1) Turn rows into columns
    for i in range(len(matrix)):
        for j in range(i, len(matrix)):
            temp = matrix[i][j]
            matrix[i][j] = matrix[j][i]
            matrix[j][i] = temp

    # 2) Re-order items in rows
    for i in range(len(matrix)):
        left = 0
        right = len(matrix) - 1
        while(left < right):
            temp2 = matrix[i][left]
            matrix[i][left] = matrix[i][right]
            matrix[i][right] = temp2
            left += 1
            right -= 1
    
    return matrix

arr = [
    [7,4,1,0],
    [8,5,2,8],
    [9,6,3,9],
    [1,2,3,0],
]

print(arr)
arr = RotateMatrix(arr)
print(arr)