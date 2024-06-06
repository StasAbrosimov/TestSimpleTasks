using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTasks
{
    public class AAABBBSolution
    {
        public string solution(int Aa, int Ab, int Bb)
        {
            if (Aa <= 0 && Ab <= 0 && Bb <= 0) { return ""; }


            var AA = new AAABBB() { count = Aa, literal = "AA" };
            var AB = new AAABBB() { count = Ab, literal = "AB" };
            var BB = new AAABBB() { count = Bb, literal = "BB" };
            
            var exit = false;
            var resultString = new StringBuilder();

            void addLiteral(AAABBB literal, StringBuilder rs)
            {
                rs.Append(literal.literal);
                literal.count--;
            }

            if (BB.count > 0 && (BB.count <= AA.count))
            {
                addLiteral(AA, resultString);
            }
            else if (BB.count > 0)
            {
                addLiteral(BB, resultString);
            }
            else if (AB.count > 0)
            {
                addLiteral(AB, resultString);
            }
            else if (AA.count > 0)
            {
                addLiteral(AA, resultString);
            }

            do
            {
                exit = true;

                if (resultString[resultString.Length - 1] == 'B')
                {
                    if (BB.count > 0 && AA.count > 0)
                    {
                        addLiteral(AA, resultString);
                        exit = false;
                    }
                    else if (AB.count > 0)
                    {
                        addLiteral(AB, resultString);
                        exit = false;
                    }
                    else if(AA.count > 0)
                    {
                        addLiteral(AA, resultString);
                        exit = false;
                    }
                }
                else if(BB.count > 0)
                {
                    addLiteral(BB, resultString);
                    exit = false;
                }

            } while (!exit);

            return resultString.ToString();
        }


        private class AAABBB
        {
            public int count;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
            public string literal;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        }

        public bool CheckLine(string line)
        {
            if (string.IsNullOrEmpty(line)) return true;

            var result = true;

            var letter = line[0];
            var letterInRow = 1;
            if (line.Length > 1)
            {
                for (int i = 1; i < line.Length; i++)
                {
                    var curLetter = line[i];
                    if (curLetter == letter)
                    {
                        letterInRow++;
                        if (letterInRow == 3)
                        {
                            result = false; break;
                        }
                    }
                    else
                    {
                        letter = line[i];
                        letterInRow = 1;
                    }
                }
            }

            return result;
        }
    }
}
