#include <iostream>
#include <string>
#include <fstream>
using namespace std;

class Point{
    public:
    void set(int newx,int newy,int newz){
        x = newx;
        y = newy;
        z = newz;
    }
    private:
    int x;
    int y;
    int z;
};
class Car{
    public:

    void get(){
        cout << year << endl;
        cout << mounth << endl;
        cout << day << endl;
        cout << name << endl;
    }
    void set(int newyear,int newmounth,int newday,string newname){
        year = newyear;
        mounth = newmounth;
        day = newday;
        name = newname;
    }

    private:

    int year,mounth,day;
    string name;
};

int main(){
    Point pointer;
    pointer.set(8,10,1);

    Car bmw;
    bmw.set(2000,12,31,"bmw-2000;12;31");
    bmw.get();

    return 1;
}