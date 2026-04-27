#include <iostream>
#include <cmath>
using namespace std;
int main()

{
    setlocale(LC_ALL, "Russian");

    double x;

    double y;

    double d;

    double c;

    double r;

    cout << ("ВВЕДИТЕ ЧИСлО ");

    cin >> x;

    cout << ("ВВЕДИТЕ ЧИСЛО ");

    cin >> y;

    cout << ("ВВЕДИТЕ ЧИСЛО ");

    cin >> d;

    cout << ("ВВЕДИТЕ ЧИСЛО ");

    cin >> c;

    

    if (x > 1 && y > 2) {
        r = x * sqrt(pow(d * y, 3));
        cout << r << endl;
    }
    else if (x < 0) {
        double MinEl = y;
            if (MinEl < x) {
                MinEl = x;
            }
        if (MinEl < c) {
            MinEl = c;
        }
        r = MinEl;
        cout << r << endl;
    }
    else {
        double MaxEl = pow(log10(d * x), 2);
        if (MaxEl < pow(y * c, 2)) {
            MaxEl = pow(y * c, 2);
            r = MaxEl;
            cout << r << endl;
        }
        
        system("pause");



    }
}



