#include <iostream>
#include <vector>
#include <string>
using namespace std;
int main(){
    // int arr[] = {123,312};
    // cout << arr[1] << endl;
    // cout << *(arr+1) << endl;

    vector<int> myvec = {1234,12345,123456,12345};
    for (vector<int>::iterator i = myvec.begin();i != myvec.end(); i++)
    {
        cout << *i << endl;
    }
    for (vector<int>::reverse_iterator i = myvec.rbegin();i != myvec.rend(); i++)
    {
        cout << *i << endl;
    }
    // for (vector<int>::const_iterator i = myvec.cbegin();i != myvec.cend(); i++)
    // {
    //     // *i = 0 !!!
    //     cout << *i << endl;
    // }
    vector<int>::iterator i = myvec.begin();
    advance(i,1);
    myvec.insert(i,999);
    for (vector<int>::iterator i = myvec.begin();i != myvec.end(); i++)
        cout << *i << endl;
    
    vector<int>::iterator del = myvec.begin();
    myvec.erase(del);
    for (vector<int>::iterator i = myvec.begin();i != myvec.end(); i++)
        cout << *i << endl;
    
    int a = 5;
    cout << a++ << endl; // 5
    // a = 6
    cout << ++a << endl; // 7
    // a = 7    
}