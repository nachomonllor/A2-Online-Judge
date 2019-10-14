https://a2oj.com/p?ID=161
fuente:
http://www.geeksforgeeks.org/find-the-next-lexicographically-greater-word-than-a-given-word/

    // Find the next lexicographically greater permutation of a word
#include <iostream>
#include <algorithm>
using namespace std;
 
int main()
{
    
    int p;
    scanf("%d", &p);
    
    while(p--) {
    
        string s;// = "521";
        cin >> s;
        
        bool val = next_permutation(s.begin(), s.end());
        if (val == false)
            cout << "DONE" << endl;
        else
            cout << s << endl;
    }
        
    //system("pause");
    return 0;
}
