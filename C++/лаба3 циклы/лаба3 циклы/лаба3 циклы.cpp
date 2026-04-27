#include <iostream>
using namespace std;
int main()
{
    setlocale(LC_ALL, "Russian");
    double y;

    cout << "Использование цикла for" << endl;
    cout << "--------------------------" << endl << endl;
    for (double p = 0; p <= 10; p += 0.5)
    {
        y = 0.5 * exp(sin(p)) - p;
        cout << y << endl;
    }
    cout << "Использование цикла while" << endl;
    cout << "--------------------------" << endl << endl;

    double x = 0;
    while (x <= 10)
    {
        y = 0.5 * exp(sin(x)) - x - 1;
        x += 0.5;
        cout << y << endl;
    }

    cout << "Использование цикла do while" << endl;
    cout << "--------------------------" << endl << endl;

    x = 0;
    do
    {
        y = 0.5 * exp(sin(x)) - x - 1;
        x += 0.5;
        cout << y << endl;
    } while (x <= 10);
}
