
#include <iostream>
using namespace std;
int main()
{
	setlocale(LC_ALL, "Russian");

	double x;

	double y;

	cout << ("ВВЕДИТЕ ЧИСлО \n") << endl;

	cin >> x;

	cout << ("ВВЕДИТЕ ЧИСЛО ");

	cin >> y;

	double b = 3.14;

	double c = cos(b / 7) * (pow(sin(x - (8 * y)), 2) / 2.7 * (x - b));

	cout << c;


}