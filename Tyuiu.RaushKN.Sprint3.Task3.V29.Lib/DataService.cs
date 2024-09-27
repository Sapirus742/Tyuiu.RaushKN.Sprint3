using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RaushKN.Sprint3.Task3.V29.Lib
{
    public class DataService : ISprint3Task3V29
    {
        public string DeleteCharInString(string value, char item)
        {
            string delString = "";

            foreach (char h in value)
            { 
                if (h == item) continue;
                else delString += h;
            }
            return delString;
        }
    }
}
