#include <iostream>
#include <vector>
#include <string>

using namespace std;

vector<string> findSubstring(const string &s)
{
    vector<string> res;
    for (int i = 0; i < s.length(); i++)
    {
        for (int j = i; j < s.length(); j++)
        {
            res.push_back(s.substr(i, j - i + 1));
        }
    }
    return res;
}

int main()
{
    string s = "abc";
    vector<string> res = findSubstring(s);
    for (const string &i : res) {
        cout << i << " ";
    }
    cout << endl;
    return 0;
}
