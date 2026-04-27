// НВП с восстановлением ответа ++.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <vector>
using namespace std;

int main()
{
    int a[7]  = { 2, 0, 10, 9, 28, 27, 31 };
    int k = 0;
    int j = 0;
    int key = a[0];
   
    for (int i = 0; i < 7; i++)
    {
        if (a[i] < key)
        {

        }
        else
        {
            k++;
            key = a[i];
        }
    }

    vector<int> b(k);
    key = a[0];

    for (int i = 0; i < 7; i++)
    {

        if (a[i] < key)
        {

        }
        else
        {
            b[j] = a[i];
            j++;
            key = a[i];
        }
    }

    for (int i = 0; i < b.size(); i++)
    {
        cout << b[i] << endl;
    }
    

    
   
 
}

