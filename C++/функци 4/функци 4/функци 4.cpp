// функци 4.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
using namespace std;
double mediana (double, double, double);
int main()


{

  setlocale(LC_ALL, "Russian");

    double a1;
    cout << "Введите a1:" << endl;
    cin >> a1;

    double a2;
    cout << "Введите a2:" << endl;
    cin >> a2;

    double a3;
    cout << "Введите a3:" << endl;
    cin >> a3;

    double m = mediana(a1, a2, a3);
    cout << " ОТВЕТ: " << +m <<endl;
   

} 


 double mediana (double A1, double A2, double A3)

{
    double m = 0.5 * sqrt (2 * pow(A2, 2) + 2 * pow(A3, 2) - pow(A1, 2));
    return m;
}