// массивы c++.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
using namespace std;

int main()
{
    double x[8] = {-1.5, 0.1, 12, 0, -2.2, 0.5, -1, 0.3};
    int minEl = x[0];
    int maxEl = x[0];

    for (int i = 1; i < 7; i++) {
        if (minEl > x[i]) {
            minEl = x[i];
        }
    }
    for (int i = 0; i < 7; i++) {
        if (x[i] < 0) {
            x[i] = minEl;

        }
    }
    for (int i = 1; i < 7; i++) {
        if (maxEl < x[i]) {
            maxEl = x[i];
        }
    }
    for (int i = 0; i < 7; i++) {
        if (x[i] > 0) {
            x[i] = maxEl;

        }
    }
    for (int i = 0; i < 7; i++) {
        cout << x[i] << endl;
    }
    
    
}

