using namespace std;
#include <iostream>
template <typename T>
T Sum(T a , T b){
    return a+b;
}
int fact(int n){
    if (n==0)
        return 0;
    if (n==1)
        return 1;
    return n * fact(n-1);
}
int main() {
    cout << Sum(1,2) << endl;
    cout << fact(6) << endl;
    // условие?дейсвии при true:при false
    int a = 5;
    a<10?cout<<"a < 10"<<endl:cout<<"a > 10"<<endl;
}