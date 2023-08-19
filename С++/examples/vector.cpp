#include <iostream>
#include <vector>
#include <string>
using namespace std;
int main(){
    int a;
    cout << "Input size list # " << endl;
    cin >> a;
    vector<string> myvec;
    for (int i = 0; i < a; i++)
    {
        cout << "Input data # " << endl;
        string b;
        cin >> b;
        myvec.push_back(b);
    }
    cout << "\n";
    for (int i = 0; i < a; i++)
    {
        cout << myvec[i] << endl;
    }
    
    return 1;
}