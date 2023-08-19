using namespace std;
#include <iostream>
int main() {
    cout << "Calcutator";
    cout << "First number";
    int num,num1;
    char* operation;
    cin >> num;
    cout << "Second number";
    cin >> num1;
    cout << "*/-+";
    cin >> operation;
    if (operation == "*"){
        cout << num * num1;
    }
    else if (operation == "/"){
        try{
            if (num1 == 0){
                throw 123;
            }
            cout << num / num1;
        }catch(int i){
            cout << "Error n" << i << " - divide by 0 !!!"; 
        }
    }
    else if (operation == "-"){
        cout << num - num1;
    }
    else if (operation == "+"){
        cout << num + num1;
    }
    return 0;
}