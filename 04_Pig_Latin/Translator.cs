using System;

namespace _04_Pig_Latin
{
    internal class Translator
    {
        string result;
        internal string Translate(string v)
        {
            char firstletter = v[0];
            //if ((firstletter == 'a') || (firstletter == 'o') || (firstletter == 'i') || (firstletter == 'u') || (firstletter == 'e'))
            char letter2 = v[1];
            char letter3 = v[2];
            char letter4 = v[3];


            bool answer = false;
            char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };

            foreach (char vowel in vowels)
            {

                if (firstletter == vowel)
                {
                    answer = true;
                }


            }
            if (answer == true)
            {
                return v + "ay";
            }
            else
            {
                foreach (char vowel in vowels) {
                    if (letter2 == vowel)
                    {
                        answer = true;
                    }
                }
                if (answer == true)
                {
                    return v.Substring(1) + firstletter + "ay";
                }
                else
                {
                    foreach (char vowel in vowels)
                    {
                        if (letter3 == vowel)
                        { answer = true;
                        }
                    }
                    if (answer == true)
                    {
                        return v.Substring(2) + firstletter + letter2 + "ay";
                    }

                    else
                    {
                        foreach (char vowel in vowels)
                        {
                            if (letter4 == vowel)
                            {
                                answer = true;
                            }
                        }
                        if (answer == true)
                        { return v.Substring(3) + firstletter + letter2 + letter3 + "ay";
                        }
                    }
                }
                return result;
            }


            //if (char.IsLetter(a));
            //v = k;
            // k =k.Substring(0, 1);

            //if k = 'a' || k = 'o' || k = 'i' || k = 'u' || k = 'e';



            //return v.Substring(1) + firstletter + "ay";
        }
    } }
