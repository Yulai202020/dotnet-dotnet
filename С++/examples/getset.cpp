#include <iostream>
#include <string>
#include <fstream>
using namespace std;

class point
{
private:
    int x,y,z;
public:
    point(int newx,int newy,int newz){
        x = newx ; y = newy ; z = newz;
    }
    point(int newx,int newy){
        x = newx ; y = newy;
    }
    point(int newx){
        x = newx;
    }
    point(){
        x = y = z = 0; 
    }
    int Set(int newx,int newy,int newz){
        x = newx;
        y = newy;
        z = newz;
    }
    int GetX() {return x;}
    int GetY() {return y;}
    int GetZ() {return z;}
};

int main(){

    return 1;
}