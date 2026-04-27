#include <iostream>
#include <vector>
#include <algorithm>
#include <string>
#include <cmath>

using namespace std;

// создание минорной матрицы путем удаления столбца и строки
vector<vector<int>> deleteRowAndCol(vector<vector<int>> matrix, int row, int col) { 
    vector<vector<int>> output;
    for (int i = 0; i < matrix.size(); i++) {
        if (i != row) {
            vector<int> empty_vect = {};
            output.push_back(empty_vect);
            for (int j = 0; j < matrix[i].size(); j++) {
                if (j != col) {
                    output[i > row ? i - 1 : i].push_back(matrix[i][j]);
                }
            }
        }
    }
    return output;
}
// рекурсивное вычисление определитея
int determinateRecur(vector<vector<int>> matrix) {
    int output = 0;
    if (matrix.size() == 2) {
        return matrix[0][0] * matrix[1][1] - matrix[1][0] * matrix[0][1]; // базовый случай - двумерная матрица второго порядка
    }
    // матрицы высших порядков обрабатываются тут:
    else {
            for (int j = 0; j < matrix[0].size(); j++) {
                output += (pow(-1, 2 + j)) * matrix[0][j] * determinateRecur(deleteRowAndCol(matrix, 0, j)); // реккурентная формула вида ((-1)^(n+m)) * M(n, m) * det(minorM(n, m)) + ...

        }
    }
    return output;
}

int main() {
    vector<vector<int>> matrix = { {4, 2}, {1, 0} }; // 6
    vector<vector<int>> matrix3 = { {2, 3, 1}, {0, 5, 1}, {2, 4, 2} }; // 8
    vector<vector<int>> matrix4 = { {1, 1, 1, 1}, {2, 1, -1, 1}, {1, -1, 2, 1}, {3, -2, 1, -1} }; // 19

    cout << determinateRecur(matrix4);

    return 0;
}